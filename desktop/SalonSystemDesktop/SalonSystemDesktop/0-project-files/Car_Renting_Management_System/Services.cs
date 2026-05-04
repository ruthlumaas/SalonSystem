using MySql.Data.MySqlClient.Memcached;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Renting_Management_System
{
    public partial class Services : Form
    {
        HttpClient client = new HttpClient();
        string baseUrl = "https://localhost:7020/api/";

        string selectedServiceID = "";
        public Services()
        {
            InitializeComponent();
            client.BaseAddress = new Uri(baseUrl);
        }
        private async void Services_Load_1(object sender, EventArgs e)
        {
            await LoadCategories();
            await LoadServices();
            buttonToGetBlackAndWhite();
        }

        // ================= GET CATEGORY =================
        async Task LoadCategories()
        {
            var res = await client.GetStringAsync("Category");

            DataTable dt = JsonConvert.DeserializeObject<DataTable>(res);

            cmbServiceCategory.Items.Clear();
            cmbSearchCategory.Items.Clear();

            cmbSearchCategory.Items.Add("All");

            foreach (DataRow row in dt.Rows)
            {
                cmbServiceCategory.Items.Add(row["name"].ToString());
                cmbSearchCategory.Items.Add(row["name"].ToString());
            }

            cmbServiceCategory.SelectedIndex = 0;
            cmbSearchCategory.SelectedIndex = 0;
        }

        // ================= GET SERVICES =================
        async Task LoadServices()
        {
            var res = await client.GetStringAsync("Service");

            DataTable dt = JsonConvert.DeserializeObject<DataTable>(res);

            dgvDisplayServices.DataSource = dt;
        }

        private async void btnAddService_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text == "" || txtServicePrice.Text == "")
            {
                new ErrorMsgBox("Please fill all fields").Show();
                return;
            }

            var obj = new
            {
                name = txtServiceName.Text,
                price = Convert.ToDecimal(txtServicePrice.Text),
                duration = Convert.ToInt32(txtServiceDuration.Text),
                categoryId = cmbServiceCategory.SelectedIndex + 1, // simple mapping
                imageUrl = "",
                isActive = true
            };

            var content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

            var res = await client.PostAsync("Service", content);

            if (res.IsSuccessStatusCode)
            {
                new SuccessMSGBox("Added Successfully").Show();
                await LoadServices();
                cleanTextBoxes();
            }
            else
            {
                new ErrorMsgBox("Failed to add service").Show();
            }
        }

        private void dgvDisplayServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDisplayServices.Rows[e.RowIndex];

                txtServiceID.Text = row.Cells["Id"].Value.ToString();
                txtServiceName.Text = row.Cells["Name"].Value.ToString();
                txtServicePrice.Text = row.Cells["Price"].Value.ToString();
                txtServiceDuration.Text = row.Cells["Duration"].Value.ToString();
                cmbServiceCategory.Text = row.Cells["CategoryName"].Value.ToString();

                selectedServiceID = txtServiceID.Text;

                buttonToGetColor();
            }
        }

        // ================= DELETE =================
        private async void btnDeleteServices_Click(object sender, EventArgs e)
        {
            if (selectedServiceID == "")
            {
                new ErrorMsgBox("Select service first").Show();
                return;
            }

            var res = await client.DeleteAsync("Service/" + selectedServiceID);

            if (res.IsSuccessStatusCode)
            {
                new SuccessMSGBox("Deleted Successfully").Show();
                await LoadServices();
                cleanTextBoxes();
            }
            else
            {
                new ErrorMsgBox("Delete failed").Show();
            }
        }

        private async void btnServiceSearch_Click(object sender, EventArgs e)
        {
            var res = await client.GetStringAsync("Service");

            DataTable dt = JsonConvert.DeserializeObject<DataTable>(res);

            var filtered = dt.AsEnumerable()
                .Where(x => x["Name"].ToString().ToLower()
                .Contains(txtServiceSearch.Text.ToLower()));

            if (filtered.Any())
                dgvDisplayServices.DataSource = filtered.CopyToDataTable();
            else
                dgvDisplayServices.DataSource = null;
        }

        // ================= UTIL =================
        void cleanTextBoxes()
        {
            txtServiceID.Text = "";
            txtServiceName.Text = "";
            txtServicePrice.Text = "";
            txtServiceDuration.Text = "";
            txtServiceSearch.Text = "";
            selectedServiceID = "";

            buttonToGetBlackAndWhite();
        }
        void buttonToGetColor()
        {
            btnUpdateSearch.Enabled = true;
            btnDeleteServices.Enabled = true;
        }
        void buttonToGetBlackAndWhite()
        {
            btnUpdateSearch.Enabled = false;
            btnDeleteServices.Enabled = false;
        }

        private async void cmbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = await client.GetStringAsync("Service");

            DataTable dt = JsonConvert.DeserializeObject<DataTable>(res);

            if (cmbSearchCategory.Text == "All")
            {
                dgvDisplayServices.DataSource = dt;
            }
            else
            {
                var filtered = dt.AsEnumerable()
                    .Where(x => x["CategoryName"].ToString() == cmbSearchCategory.Text);

                if (filtered.Any())
                    dgvDisplayServices.DataSource = filtered.CopyToDataTable();
                else
                    dgvDisplayServices.DataSource = null;
            }
        }
    }
}

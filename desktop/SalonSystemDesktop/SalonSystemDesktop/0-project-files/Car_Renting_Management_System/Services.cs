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
using System.IO;
using System.Windows.Forms;

namespace Car_Renting_Management_System
{
    public partial class Services : Form
    {
        HttpClient client = new HttpClient();
        string baseUrl = "https://localhost:7020/api/";

        string selectedServiceID = "";
        string selectedImagePath = "";
        bool isSearchPlaceholder = true;
        public Services()
        {
            InitializeComponent();
            client.BaseAddress = new Uri(baseUrl);
        }
        private async void Services_Load_1(object sender, EventArgs e)
        {
            await GenerateServiceID();
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
        async Task GenerateServiceID()
        {
            var res = await client.GetStringAsync("Service");

            DataTable dt = JsonConvert.DeserializeObject<DataTable>(res);

            if (dt.Rows.Count > 0)
            {
                int lastID = Convert.ToInt32(
                    dt.AsEnumerable().Max(row => row["Id"])
                );

                txtServiceID.Text = (lastID + 1).ToString();
            }
            else
            {
                txtServiceID.Text = "1";
            }
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
                categoryId = cmbServiceCategory.SelectedIndex + 1, 
                imageUrl = selectedImagePath,
                isActive = true
            };

            var content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

            var res = await client.PostAsync("Service", content);

            if (res.IsSuccessStatusCode)
            {
                new SuccessMSGBox("Added Successfully").Show();
                await LoadServices();
                await GenerateServiceID();
                cleanTextBoxes();
            }
            else
            {
                new ErrorMsgBox("Failed to add service").Show();
            }

            buttonToGetBlackAndWhite();
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

                string imagePath = row.Cells["ImageUrl"].Value.ToString();

                string fullPath =
                @"C:\IntegrativeProgrammingAndTechnologies\SalonManagementSystem\SalonSystem\SalonManagementAPI\SalonManagementAPI\wwwroot\"
                + imagePath;

                pbxServiceImage.ImageLocation = fullPath;

                btnAddService.Visible = false;
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
                await GenerateServiceID();
                cleanTextBoxes();
            }
            else
            {
                new ErrorMsgBox("Delete failed").Show();
            }
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

            selectedImagePath = "";
            pbxServiceImage.Image = null;

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

        private void btnBrowseServiceImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.jpg;*.png;*.jpeg";
            
            if (op.ShowDialog() == DialogResult.OK)
            {
                string fileName = System.IO.Path.GetFileName(op.FileName);
                selectedImagePath = "images/services/" + fileName;
                pbxServiceImage.ImageLocation = op.FileName;
            }
        }

        private async void btnUpdateSearch_Click(object sender, EventArgs e)
        {
            if (selectedServiceID == "")
            {
                MessageBox.Show("Select service first");
                return;
            }

            var obj = new
            {
                id = Convert.ToInt32(selectedServiceID),
                name = txtServiceName.Text,
                price = Convert.ToDecimal(txtServicePrice.Text),
                duration = Convert.ToInt32(txtServiceDuration.Text),
                categoryId = cmbServiceCategory.SelectedIndex + 1,
                imageUrl = selectedImagePath,
                isActive = true
            };

            var content = new StringContent(
                JsonConvert.SerializeObject(obj),
                Encoding.UTF8,
                "application/json"
            );

            var res = await client.PutAsync("Service/" + selectedServiceID, content);

            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Updated Successfully");
                await LoadServices();
                await GenerateServiceID();
                cleanTextBoxes();
            }
        }
        private void txtServiceSearch_Leave_1(object sender, EventArgs e)
        {
            if (txtServiceSearch.Text.Trim() == "")
            {
                isSearchPlaceholder = true;

                txtServiceSearch.Text = "Search by ID and Name";
                txtServiceSearch.ForeColor = Color.Gray;
            }
        }

        private void txtServiceSearch_Enter_1(object sender, EventArgs e)
        {
            if (isSearchPlaceholder)
            {
                txtServiceSearch.Text = "";
                txtServiceSearch.ForeColor = Color.White;

                isSearchPlaceholder = false;
            }

            txtServiceSearch.SelectAll();
        }

        private async void txtServiceSearch_TextChanged_1(object sender, EventArgs e)
        {
            var res = await client.GetStringAsync("Service");

            DataTable dt = JsonConvert.DeserializeObject<DataTable>(res);

            var filtered = dt.AsEnumerable()
            .Where(x =>
                x["Name"].ToString().ToLower()
                .Contains(txtServiceSearch.Text.ToLower())
                ||
                x["Id"].ToString()
                .Contains(txtServiceSearch.Text)
            );

            if (filtered.Any())
                dgvDisplayServices.DataSource = filtered.CopyToDataTable();
            else
                dgvDisplayServices.DataSource = null;
        }
    }
}

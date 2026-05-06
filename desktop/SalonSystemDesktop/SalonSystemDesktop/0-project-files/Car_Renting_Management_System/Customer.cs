using MySql.Data.MySqlClient.Memcached;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;

namespace Car_Renting_Management_System
{
    public partial class Customer : Form
    {
        HttpClient client = new HttpClient();

        string baseUrl = "https://localhost:7020/api/";
        string selectedCustomerID = "";
        public Customer()
        {
            InitializeComponent();
            client.BaseAddress = new Uri(baseUrl);
        }

        private async void Customer_Load(object sender, EventArgs e)
        {
            await LoadCustomers();

            btnDeleteServices.Enabled = false;

            txtCustomerID.Enabled = false;
            txtCustomerName.Enabled = false;
            txtCustomerEmail.Enabled = false;
        }
        async Task LoadCustomers()
        {
            var res = await client.GetStringAsync("Customer");

            DataTable dt =
                JsonConvert.DeserializeObject<DataTable>(res);

            dgvDisplayCustomer.DataSource = dt;
        }

        private void dgvDisplayCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvDisplayCustomer.Rows[e.RowIndex].Cells["Id"].Value == null)
                return;

            var row = dgvDisplayCustomer.Rows[e.RowIndex];

            txtCustomerID.Text =
                row.Cells["Id"].Value?.ToString();

            txtCustomerName.Text =
                row.Cells["FullName"].Value?.ToString();

            txtCustomerEmail.Text =
                row.Cells["Email"].Value?.ToString();

            selectedCustomerID =
                txtCustomerID.Text;

            btnDeleteServices.Enabled = true;
        }

        private async void btnDeleteServices_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == "")
            {
                MessageBox.Show("Select customer first");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Delete this customer?",
                    "Confirm",
                    MessageBoxButtons.YesNo
                );

            if (result == DialogResult.Yes)
            {
                var res =
                    await client.DeleteAsync(
                        "Customer/" + selectedCustomerID
                    );

                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Deleted Successfully");

                    await LoadCustomers();

                    CleanFields();
                }
                else
                {
                    MessageBox.Show("Delete failed");
                }
            }
        }

        private async void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            if (
               txtCustomerSearch.Text.Trim() == ""
               ||
               txtCustomerSearch.Text == "Search by ID and Name")
            {
                await LoadCustomers();
                return;
            }
            var res = await client.GetStringAsync("Customer");

            DataTable dt =
                JsonConvert.DeserializeObject<DataTable>(res);

            var filtered =
                dt.AsEnumerable()
                .Where(x =>
                         x["Id"].ToString()
                    .Contains(txtCustomerSearch.Text)

                    ||

                    x["FullName"].ToString()
                    .ToLower()
                    .Contains(
                        txtCustomerSearch.Text.ToLower()
                    )

                    ||

                    x["Email"].ToString()
                    .ToLower()
                    .Contains(
                        txtCustomerSearch.Text.ToLower()
                    )
                );

            if (filtered.Any())
            {
                dgvDisplayCustomer.DataSource =
                    filtered.CopyToDataTable();
            }
            else
            {
                dgvDisplayCustomer.DataSource =
                    dt.Clone();
            }
        }
        void CleanFields()
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtCustomerEmail.Text = "";

            selectedCustomerID = "";

            btnDeleteServices.Enabled = false;
        }

        private void txtCustomerSearch_Enter(object sender, EventArgs e)
        {
            if (txtCustomerSearch.Text == "Search by ID and Name")
            {
                txtCustomerSearch.Text = "";
            }

            txtCustomerSearch.SelectAll();
        }

        private void txtCustomerSearch_Leave(object sender, EventArgs e)
        {
            if (txtCustomerSearch.Text == "")
            {
                txtCustomerSearch.Text = "Search by ID and Name";
            }
        }
    }
}

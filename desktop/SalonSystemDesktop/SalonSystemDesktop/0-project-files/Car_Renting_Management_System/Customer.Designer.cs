namespace Car_Renting_Management_System
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteServices = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustomerSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDisplayCustomer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerName = new MonoFlat.MonoFlat_TextBox();
            this.txtCustomerID = new MonoFlat.MonoFlat_Label();
            this.txtCustomerEmail = new MonoFlat.MonoFlat_TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 46);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(1117, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(455, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Management";
            // 
            // btnDeleteServices
            // 
            this.btnDeleteServices.Activecolor = System.Drawing.Color.Red;
            this.btnDeleteServices.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteServices.BorderRadius = 0;
            this.btnDeleteServices.ButtonText = "Delete";
            this.btnDeleteServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteServices.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteServices.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteServices.Iconimage = global::Car_Renting_Management_System.Properties.Resources.if_Remove_27874;
            this.btnDeleteServices.Iconimage_right = null;
            this.btnDeleteServices.Iconimage_right_Selected = null;
            this.btnDeleteServices.Iconimage_Selected = null;
            this.btnDeleteServices.IconMarginLeft = 0;
            this.btnDeleteServices.IconMarginRight = 0;
            this.btnDeleteServices.IconRightVisible = true;
            this.btnDeleteServices.IconRightZoom = 0D;
            this.btnDeleteServices.IconVisible = true;
            this.btnDeleteServices.IconZoom = 80D;
            this.btnDeleteServices.IsTab = false;
            this.btnDeleteServices.Location = new System.Drawing.Point(696, 387);
            this.btnDeleteServices.Name = "btnDeleteServices";
            this.btnDeleteServices.Normalcolor = System.Drawing.Color.Maroon;
            this.btnDeleteServices.OnHovercolor = System.Drawing.Color.Brown;
            this.btnDeleteServices.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteServices.selected = false;
            this.btnDeleteServices.Size = new System.Drawing.Size(103, 41);
            this.btnDeleteServices.TabIndex = 13;
            this.btnDeleteServices.Text = "Delete";
            this.btnDeleteServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteServices.Textcolor = System.Drawing.Color.White;
            this.btnDeleteServices.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteServices.Click += new System.EventHandler(this.btnDeleteServices_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDeleteServices);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvDisplayCustomer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCustomerEmail);
            this.groupBox1.Location = new System.Drawing.Point(181, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 563);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCustomerSearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 75);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerSearch.DefaultText = "Search by ID and Name";
            this.txtCustomerSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtCustomerSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerSearch.Location = new System.Drawing.Point(6, 19);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.PlaceholderText = "";
            this.txtCustomerSearch.SelectedText = "";
            this.txtCustomerSearch.Size = new System.Drawing.Size(324, 36);
            this.txtCustomerSearch.TabIndex = 63;
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            this.txtCustomerSearch.Enter += new System.EventHandler(this.txtCustomerSearch_Enter);
            this.txtCustomerSearch.Leave += new System.EventHandler(this.txtCustomerSearch_Leave);
            // 
            // dgvDisplayCustomer
            // 
            this.dgvDisplayCustomer.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDisplayCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplayCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgvDisplayCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplayCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisplayCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplayCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDisplayCustomer.DoubleBuffered = true;
            this.dgvDisplayCustomer.EnableHeadersVisualStyles = false;
            this.dgvDisplayCustomer.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.dgvDisplayCustomer.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDisplayCustomer.Location = new System.Drawing.Point(28, 120);
            this.dgvDisplayCustomer.MultiSelect = false;
            this.dgvDisplayCustomer.Name = "dgvDisplayCustomer";
            this.dgvDisplayCustomer.ReadOnly = true;
            this.dgvDisplayCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDisplayCustomer.RowHeadersWidth = 30;
            this.dgvDisplayCustomer.Size = new System.Drawing.Size(771, 259);
            this.dgvDisplayCustomer.TabIndex = 20;
            this.dgvDisplayCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayCustomer_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(52, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 71;
            this.label3.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(53, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 72;
            this.label4.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(52, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 22);
            this.label7.TabIndex = 73;
            this.label7.Text = "Customer Fullname";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCustomerName.ForeColor = System.Drawing.Color.White;
            this.txtCustomerName.Image = null;
            this.txtCustomerName.Location = new System.Drawing.Point(250, 442);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Multiline = false;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = false;
            this.txtCustomerName.Size = new System.Drawing.Size(279, 41);
            this.txtCustomerName.TabIndex = 75;
            this.txtCustomerName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerName.UseSystemPasswordChar = false;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.AutoSize = true;
            this.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.ForeColor = System.Drawing.Color.White;
            this.txtCustomerID.Location = new System.Drawing.Point(247, 411);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(52, 17);
            this.txtCustomerID.TabIndex = 74;
            this.txtCustomerID.Text = "           ";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerEmail.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCustomerEmail.ForeColor = System.Drawing.Color.White;
            this.txtCustomerEmail.Image = null;
            this.txtCustomerEmail.Location = new System.Drawing.Point(250, 497);
            this.txtCustomerEmail.MaxLength = 32767;
            this.txtCustomerEmail.Multiline = false;
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.ReadOnly = false;
            this.txtCustomerEmail.Size = new System.Drawing.Size(279, 41);
            this.txtCustomerEmail.TabIndex = 70;
            this.txtCustomerEmail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerEmail.UseSystemPasswordChar = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1125, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteServices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDisplayCustomer;
        private MonoFlat.MonoFlat_TextBox txtCustomerName;
        private MonoFlat.MonoFlat_Label txtCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private MonoFlat.MonoFlat_TextBox txtCustomerEmail;
    }
}
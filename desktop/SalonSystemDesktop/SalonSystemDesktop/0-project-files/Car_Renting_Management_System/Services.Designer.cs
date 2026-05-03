namespace Car_Renting_Management_System
{
    partial class Services
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
            this.cmbServiceCategory = new MetroFramework.Controls.MetroComboBox();
            this.dgvDisplayServices = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtServicePrice = new MonoFlat.MonoFlat_TextBox();
            this.txtServiceName = new MonoFlat.MonoFlat_TextBox();
            this.cmbSearchCategory = new System.Windows.Forms.ComboBox();
            this.txtServiceDuration = new MonoFlat.MonoFlat_TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServiceSearch = new MonoFlat.MonoFlat_TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServiceID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrowseServiceImg = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbxServiceImage = new System.Windows.Forms.PictureBox();
            this.btnDeleteServices = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnServiceSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddService = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayServices)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxServiceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbServiceCategory
            // 
            this.cmbServiceCategory.FormattingEnabled = true;
            this.cmbServiceCategory.ItemHeight = 23;
            this.cmbServiceCategory.Location = new System.Drawing.Point(502, 94);
            this.cmbServiceCategory.Name = "cmbServiceCategory";
            this.cmbServiceCategory.Size = new System.Drawing.Size(279, 29);
            this.cmbServiceCategory.TabIndex = 61;
            // 
            // dgvDisplayServices
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDisplayServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplayServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgvDisplayServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplayServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisplayServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplayServices.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDisplayServices.DoubleBuffered = true;
            this.dgvDisplayServices.EnableHeadersVisualStyles = false;
            this.dgvDisplayServices.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.dgvDisplayServices.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDisplayServices.Location = new System.Drawing.Point(181, 489);
            this.dgvDisplayServices.MultiSelect = false;
            this.dgvDisplayServices.Name = "dgvDisplayServices";
            this.dgvDisplayServices.ReadOnly = true;
            this.dgvDisplayServices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDisplayServices.RowHeadersWidth = 30;
            this.dgvDisplayServices.Size = new System.Drawing.Size(820, 189);
            this.dgvDisplayServices.TabIndex = 17;
            this.dgvDisplayServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayServices_CellClick);
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.BackColor = System.Drawing.Color.Transparent;
            this.txtServicePrice.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtServicePrice.ForeColor = System.Drawing.Color.White;
            this.txtServicePrice.Image = null;
            this.txtServicePrice.Location = new System.Drawing.Point(502, 188);
            this.txtServicePrice.MaxLength = 32767;
            this.txtServicePrice.Multiline = false;
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.ReadOnly = false;
            this.txtServicePrice.Size = new System.Drawing.Size(279, 41);
            this.txtServicePrice.TabIndex = 2;
            this.txtServicePrice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServicePrice.UseSystemPasswordChar = false;
            // 
            // txtServiceName
            // 
            this.txtServiceName.BackColor = System.Drawing.Color.Transparent;
            this.txtServiceName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtServiceName.ForeColor = System.Drawing.Color.White;
            this.txtServiceName.Image = null;
            this.txtServiceName.Location = new System.Drawing.Point(502, 137);
            this.txtServiceName.MaxLength = 32767;
            this.txtServiceName.Multiline = false;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.ReadOnly = false;
            this.txtServiceName.Size = new System.Drawing.Size(279, 41);
            this.txtServiceName.TabIndex = 1;
            this.txtServiceName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServiceName.UseSystemPasswordChar = false;
            // 
            // cmbSearchCategory
            // 
            this.cmbSearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.cmbSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchCategory.FormattingEnabled = true;
            this.cmbSearchCategory.Location = new System.Drawing.Point(356, 30);
            this.cmbSearchCategory.Name = "cmbSearchCategory";
            this.cmbSearchCategory.Size = new System.Drawing.Size(130, 21);
            this.cmbSearchCategory.TabIndex = 16;
            this.cmbSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSearchCategory_SelectedIndexChanged);
            // 
            // txtServiceDuration
            // 
            this.txtServiceDuration.BackColor = System.Drawing.Color.Transparent;
            this.txtServiceDuration.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtServiceDuration.ForeColor = System.Drawing.Color.White;
            this.txtServiceDuration.Image = null;
            this.txtServiceDuration.Location = new System.Drawing.Point(502, 238);
            this.txtServiceDuration.MaxLength = 32767;
            this.txtServiceDuration.Multiline = false;
            this.txtServiceDuration.Name = "txtServiceDuration";
            this.txtServiceDuration.ReadOnly = false;
            this.txtServiceDuration.Size = new System.Drawing.Size(279, 41);
            this.txtServiceDuration.TabIndex = 3;
            this.txtServiceDuration.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServiceDuration.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(323, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Category ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(324, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(324, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Duration";
            // 
            // txtServiceSearch
            // 
            this.txtServiceSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtServiceSearch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtServiceSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtServiceSearch.Image = null;
            this.txtServiceSearch.Location = new System.Drawing.Point(118, 19);
            this.txtServiceSearch.MaxLength = 32767;
            this.txtServiceSearch.Multiline = false;
            this.txtServiceSearch.Name = "txtServiceSearch";
            this.txtServiceSearch.ReadOnly = false;
            this.txtServiceSearch.Size = new System.Drawing.Size(151, 41);
            this.txtServiceSearch.TabIndex = 11;
            this.txtServiceSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServiceSearch.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteServices);
            this.groupBox2.Controls.Add(this.cmbSearchCategory);
            this.groupBox2.Controls.Add(this.btnUpdateSearch);
            this.groupBox2.Controls.Add(this.btnServiceSearch);
            this.groupBox2.Controls.Add(this.txtServiceSearch);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(6, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 75);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(287, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "List By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(323, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Service ID";
            // 
            // txtServiceID
            // 
            this.txtServiceID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.txtServiceID.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtServiceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceID.ForeColor = System.Drawing.Color.White;
            this.txtServiceID.Location = new System.Drawing.Point(502, 39);
            this.txtServiceID.Multiline = true;
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(279, 34);
            this.txtServiceID.TabIndex = 59;
            this.txtServiceID.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            this.groupBox1.Controls.Add(this.btnAddService);
            this.groupBox1.Controls.Add(this.cmbServiceCategory);
            this.groupBox1.Controls.Add(this.btnBrowseServiceImg);
            this.groupBox1.Controls.Add(this.pbxServiceImage);
            this.groupBox1.Controls.Add(this.txtServiceID);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtServiceDuration);
            this.groupBox1.Controls.Add(this.txtServicePrice);
            this.groupBox1.Controls.Add(this.txtServiceName);
            this.groupBox1.Location = new System.Drawing.Point(181, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 431);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(324, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Service Name";
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
            this.label1.Size = new System.Drawing.Size(272, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Services Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 46);
            this.panel1.TabIndex = 15;
            // 
            // btnBrowseServiceImg
            // 
            this.btnBrowseServiceImg.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBrowseServiceImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBrowseServiceImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseServiceImg.BorderRadius = 0;
            this.btnBrowseServiceImg.ButtonText = "Browse";
            this.btnBrowseServiceImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseServiceImg.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowseServiceImg.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowseServiceImg.Iconimage = global::Car_Renting_Management_System.Properties.Resources.if_folder_saved_search_118905;
            this.btnBrowseServiceImg.Iconimage_right = null;
            this.btnBrowseServiceImg.Iconimage_right_Selected = null;
            this.btnBrowseServiceImg.Iconimage_Selected = null;
            this.btnBrowseServiceImg.IconMarginLeft = 0;
            this.btnBrowseServiceImg.IconMarginRight = 0;
            this.btnBrowseServiceImg.IconRightVisible = true;
            this.btnBrowseServiceImg.IconRightZoom = 0D;
            this.btnBrowseServiceImg.IconVisible = true;
            this.btnBrowseServiceImg.IconZoom = 75D;
            this.btnBrowseServiceImg.IsTab = false;
            this.btnBrowseServiceImg.Location = new System.Drawing.Point(98, 232);
            this.btnBrowseServiceImg.Name = "btnBrowseServiceImg";
            this.btnBrowseServiceImg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBrowseServiceImg.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBrowseServiceImg.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowseServiceImg.selected = false;
            this.btnBrowseServiceImg.Size = new System.Drawing.Size(104, 41);
            this.btnBrowseServiceImg.TabIndex = 13;
            this.btnBrowseServiceImg.Text = "Browse";
            this.btnBrowseServiceImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseServiceImg.Textcolor = System.Drawing.Color.White;
            this.btnBrowseServiceImg.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pbxServiceImage
            // 
            this.pbxServiceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxServiceImage.Location = new System.Drawing.Point(43, 63);
            this.pbxServiceImage.Name = "pbxServiceImage";
            this.pbxServiceImage.Size = new System.Drawing.Size(232, 155);
            this.pbxServiceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxServiceImage.TabIndex = 60;
            this.pbxServiceImage.TabStop = false;
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
            this.btnDeleteServices.Location = new System.Drawing.Point(672, 19);
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
            // btnUpdateSearch
            // 
            this.btnUpdateSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateSearch.BorderRadius = 0;
            this.btnUpdateSearch.ButtonText = "Update";
            this.btnUpdateSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateSearch.Iconimage = global::Car_Renting_Management_System.Properties.Resources.if_db_update_32131;
            this.btnUpdateSearch.Iconimage_right = null;
            this.btnUpdateSearch.Iconimage_right_Selected = null;
            this.btnUpdateSearch.Iconimage_Selected = null;
            this.btnUpdateSearch.IconMarginLeft = 0;
            this.btnUpdateSearch.IconMarginRight = 0;
            this.btnUpdateSearch.IconRightVisible = true;
            this.btnUpdateSearch.IconRightZoom = 0D;
            this.btnUpdateSearch.IconVisible = true;
            this.btnUpdateSearch.IconZoom = 90D;
            this.btnUpdateSearch.IsTab = false;
            this.btnUpdateSearch.Location = new System.Drawing.Point(528, 19);
            this.btnUpdateSearch.Name = "btnUpdateSearch";
            this.btnUpdateSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdateSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateSearch.selected = false;
            this.btnUpdateSearch.Size = new System.Drawing.Size(103, 41);
            this.btnUpdateSearch.TabIndex = 13;
            this.btnUpdateSearch.Text = "Update";
            this.btnUpdateSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSearch.Textcolor = System.Drawing.Color.White;
            this.btnUpdateSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnServiceSearch
            // 
            this.btnServiceSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnServiceSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnServiceSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServiceSearch.BorderRadius = 0;
            this.btnServiceSearch.ButtonText = "Search";
            this.btnServiceSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServiceSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnServiceSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnServiceSearch.Iconimage = global::Car_Renting_Management_System.Properties.Resources.if_folder_saved_search_118905;
            this.btnServiceSearch.Iconimage_right = null;
            this.btnServiceSearch.Iconimage_right_Selected = null;
            this.btnServiceSearch.Iconimage_Selected = null;
            this.btnServiceSearch.IconMarginLeft = 0;
            this.btnServiceSearch.IconMarginRight = 0;
            this.btnServiceSearch.IconRightVisible = true;
            this.btnServiceSearch.IconRightZoom = 0D;
            this.btnServiceSearch.IconVisible = true;
            this.btnServiceSearch.IconZoom = 75D;
            this.btnServiceSearch.IsTab = false;
            this.btnServiceSearch.Location = new System.Drawing.Point(7, 19);
            this.btnServiceSearch.Name = "btnServiceSearch";
            this.btnServiceSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnServiceSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnServiceSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnServiceSearch.selected = false;
            this.btnServiceSearch.Size = new System.Drawing.Size(104, 41);
            this.btnServiceSearch.TabIndex = 12;
            this.btnServiceSearch.Text = "Search";
            this.btnServiceSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceSearch.Textcolor = System.Drawing.Color.White;
            this.btnServiceSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceSearch.Click += new System.EventHandler(this.btnServiceSearch_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddService.BorderRadius = 0;
            this.btnAddService.ButtonText = "ADD SERVICE";
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddService.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddService.Iconimage = global::Car_Renting_Management_System.Properties.Resources.if_db_update_32131;
            this.btnAddService.Iconimage_right = null;
            this.btnAddService.Iconimage_right_Selected = null;
            this.btnAddService.Iconimage_Selected = null;
            this.btnAddService.IconMarginLeft = 0;
            this.btnAddService.IconMarginRight = 0;
            this.btnAddService.IconRightVisible = true;
            this.btnAddService.IconRightZoom = 0D;
            this.btnAddService.IconVisible = true;
            this.btnAddService.IconZoom = 90D;
            this.btnAddService.IsTab = false;
            this.btnAddService.Location = new System.Drawing.Point(502, 285);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddService.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddService.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddService.selected = false;
            this.btnAddService.Size = new System.Drawing.Size(279, 41);
            this.btnAddService.TabIndex = 17;
            this.btnAddService.Text = "ADD SERVICE";
            this.btnAddService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddService.Textcolor = System.Drawing.Color.White;
            this.btnAddService.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1141, 661);
            this.Controls.Add(this.dgvDisplayServices);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Services";
            this.Text = "Services";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayServices)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxServiceImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbServiceCategory;
        private System.Windows.Forms.PictureBox pbxServiceImage;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDisplayServices;
        private MonoFlat.MonoFlat_TextBox txtServicePrice;
        private MonoFlat.MonoFlat_TextBox txtServiceName;
        private System.Windows.Forms.ComboBox cmbSearchCategory;
        private MonoFlat.MonoFlat_TextBox txtServiceDuration;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteServices;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateSearch;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btnServiceSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MonoFlat.MonoFlat_TextBox txtServiceSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowseServiceImg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtServiceID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddService;
    }
}
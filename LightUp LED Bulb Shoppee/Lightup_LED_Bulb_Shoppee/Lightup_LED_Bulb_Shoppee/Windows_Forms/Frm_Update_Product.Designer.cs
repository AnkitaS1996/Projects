
namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    partial class Frm_Update_Product
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Product = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_Warranty = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_Unit_Price = new System.Windows.Forms.Label();
            this.lbl_P_Warranty = new System.Windows.Forms.Label();
            this.txt_Unit_Price = new System.Windows.Forms.TextBox();
            this.txt_Purchase_Price = new System.Windows.Forms.TextBox();
            this.lbl_P_Price = new System.Windows.Forms.Label();
            this.lbl_Watt = new System.Windows.Forms.Label();
            this.cmb_Distributor = new System.Windows.Forms.ComboBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Distributor_Name = new System.Windows.Forms.Label();
            this.txt_Watt = new System.Windows.Forms.TextBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.gb_Search_Product = new System.Windows.Forms.GroupBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.cb_Searchby = new System.Windows.Forms.ComboBox();
            this.lbl_SearchBy = new System.Windows.Forms.Label();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.txt_Product_Name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.gb_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.gb_Search_Product.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pb_Exit);
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1662, 91);
            this.panel1.TabIndex = 5;
            // 
            // pb_Exit
            // 
            this.pb_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Exit.Image = global::Lightup_LED_Bulb_Shoppee.Properties.Resources._77_771475_x_exit_button_icon_symbol_vector_illustration_hong;
            this.pb_Exit.Location = new System.Drawing.Point(1605, 3);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(54, 45);
            this.pb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Exit.TabIndex = 1;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.pb_Exit_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Header.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(583, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(639, 69);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "UPDATE PRODUCT";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_Product
            // 
            this.gb_Product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Product.BackColor = System.Drawing.Color.DarkGray;
            this.gb_Product.Controls.Add(this.txt_Product_Name);
            this.gb_Product.Controls.Add(this.txt_Category);
            this.gb_Product.Controls.Add(this.btn_Clear);
            this.gb_Product.Controls.Add(this.txt_Warranty);
            this.gb_Product.Controls.Add(this.btn_Update);
            this.gb_Product.Controls.Add(this.lbl_Unit_Price);
            this.gb_Product.Controls.Add(this.lbl_P_Warranty);
            this.gb_Product.Controls.Add(this.txt_Unit_Price);
            this.gb_Product.Controls.Add(this.txt_Purchase_Price);
            this.gb_Product.Controls.Add(this.lbl_P_Price);
            this.gb_Product.Controls.Add(this.lbl_Watt);
            this.gb_Product.Controls.Add(this.cmb_Distributor);
            this.gb_Product.Controls.Add(this.lbl_ID);
            this.gb_Product.Controls.Add(this.lbl_Distributor_Name);
            this.gb_Product.Controls.Add(this.txt_Watt);
            this.gb_Product.Controls.Add(this.lbl_Product_Name);
            this.gb_Product.Controls.Add(this.txt_ID);
            this.gb_Product.Controls.Add(this.lbl_Date);
            this.gb_Product.Controls.Add(this.lbl_Category);
            this.gb_Product.Controls.Add(this.dtp_Date);
            this.gb_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product.Location = new System.Drawing.Point(12, 204);
            this.gb_Product.Name = "gb_Product";
            this.gb_Product.Size = new System.Drawing.Size(1647, 282);
            this.gb_Product.TabIndex = 7;
            this.gb_Product.TabStop = false;
            this.gb_Product.Text = "Product Details";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(1435, 190);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(174, 62);
            this.btn_Clear.TabIndex = 26;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_Warranty
            // 
            this.txt_Warranty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Warranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Warranty.Location = new System.Drawing.Point(972, 219);
            this.txt_Warranty.Name = "txt_Warranty";
            this.txt_Warranty.Size = new System.Drawing.Size(205, 34);
            this.txt_Warranty.TabIndex = 24;
            this.txt_Warranty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Warranty_KeyDown);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(1219, 190);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(177, 62);
            this.btn_Update.TabIndex = 22;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_Unit_Price
            // 
            this.lbl_Unit_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Unit_Price.AutoSize = true;
            this.lbl_Unit_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit_Price.Location = new System.Drawing.Point(378, 170);
            this.lbl_Unit_Price.Name = "lbl_Unit_Price";
            this.lbl_Unit_Price.Size = new System.Drawing.Size(155, 36);
            this.lbl_Unit_Price.TabIndex = 11;
            this.lbl_Unit_Price.Text = "Unit Price";
            this.lbl_Unit_Price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_P_Warranty
            // 
            this.lbl_P_Warranty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_P_Warranty.AutoSize = true;
            this.lbl_P_Warranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P_Warranty.Location = new System.Drawing.Point(1009, 170);
            this.lbl_P_Warranty.Name = "lbl_P_Warranty";
            this.lbl_P_Warranty.Size = new System.Drawing.Size(144, 36);
            this.lbl_P_Warranty.TabIndex = 23;
            this.lbl_P_Warranty.Text = "Warranty";
            this.lbl_P_Warranty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Unit_Price
            // 
            this.txt_Unit_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Unit_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Unit_Price.Location = new System.Drawing.Point(354, 222);
            this.txt_Unit_Price.Name = "txt_Unit_Price";
            this.txt_Unit_Price.Size = new System.Drawing.Size(199, 34);
            this.txt_Unit_Price.TabIndex = 15;
            this.txt_Unit_Price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Unit_Price_KeyDown);
            this.txt_Unit_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Unit_Price_KeyPress);
            // 
            // txt_Purchase_Price
            // 
            this.txt_Purchase_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Purchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Purchase_Price.Location = new System.Drawing.Point(631, 219);
            this.txt_Purchase_Price.Name = "txt_Purchase_Price";
            this.txt_Purchase_Price.Size = new System.Drawing.Size(260, 34);
            this.txt_Purchase_Price.TabIndex = 17;
            this.txt_Purchase_Price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Purchase_Price_KeyDown);
            this.txt_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Purchase_Price_KeyPress);
            // 
            // lbl_P_Price
            // 
            this.lbl_P_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_P_Price.AutoSize = true;
            this.lbl_P_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P_Price.Location = new System.Drawing.Point(645, 170);
            this.lbl_P_Price.Name = "lbl_P_Price";
            this.lbl_P_Price.Size = new System.Drawing.Size(231, 36);
            this.lbl_P_Price.TabIndex = 13;
            this.lbl_P_Price.Text = "Purchase Price";
            this.lbl_P_Price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Watt
            // 
            this.lbl_Watt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Watt.AutoSize = true;
            this.lbl_Watt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Watt.Location = new System.Drawing.Point(119, 170);
            this.lbl_Watt.Name = "lbl_Watt";
            this.lbl_Watt.Size = new System.Drawing.Size(96, 36);
            this.lbl_Watt.TabIndex = 20;
            this.lbl_Watt.Text = "Watts";
            this.lbl_Watt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmb_Distributor
            // 
            this.cmb_Distributor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Distributor.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Distributor.FormattingEnabled = true;
            this.cmb_Distributor.Location = new System.Drawing.Point(1291, 84);
            this.cmb_Distributor.Name = "cmb_Distributor";
            this.cmb_Distributor.Size = new System.Drawing.Size(308, 33);
            this.cmb_Distributor.TabIndex = 25;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(95, 40);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(44, 32);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_Distributor_Name
            // 
            this.lbl_Distributor_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Distributor_Name.AutoSize = true;
            this.lbl_Distributor_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Name.Location = new System.Drawing.Point(1316, 40);
            this.lbl_Distributor_Name.Name = "lbl_Distributor_Name";
            this.lbl_Distributor_Name.Size = new System.Drawing.Size(243, 32);
            this.lbl_Distributor_Name.TabIndex = 24;
            this.lbl_Distributor_Name.Text = "Distributor Name";
            // 
            // txt_Watt
            // 
            this.txt_Watt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Watt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Watt.Location = new System.Drawing.Point(75, 219);
            this.txt_Watt.Name = "txt_Watt";
            this.txt_Watt.Size = new System.Drawing.Size(189, 34);
            this.txt_Watt.TabIndex = 21;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(946, 40);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(207, 32);
            this.lbl_Product_Name.TabIndex = 3;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ID.Enabled = false;
            this.txt_ID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(44, 82);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(140, 34);
            this.txt_ID.TabIndex = 4;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(301, 40);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(79, 32);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Category
            // 
            this.lbl_Category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(589, 40);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(138, 32);
            this.lbl_Category.TabIndex = 1;
            this.lbl_Category.Text = "Category";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(243, 82);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(215, 34);
            this.dtp_Date.TabIndex = 7;
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.AllowUserToDeleteRows = false;
            this.dgv_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Data.Location = new System.Drawing.Point(13, 492);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersVisible = false;
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.RowTemplate.Height = 24;
            this.dgv_Data.Size = new System.Drawing.Size(1646, 473);
            this.dgv_Data.TabIndex = 27;
            this.dgv_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Data_CellClick);
            // 
            // gb_Search_Product
            // 
            this.gb_Search_Product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Search_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_Search_Product.Controls.Add(this.txt_Search);
            this.gb_Search_Product.Controls.Add(this.lbl_Search);
            this.gb_Search_Product.Controls.Add(this.cb_Searchby);
            this.gb_Search_Product.Controls.Add(this.lbl_SearchBy);
            this.gb_Search_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Search_Product.Location = new System.Drawing.Point(13, 98);
            this.gb_Search_Product.Name = "gb_Search_Product";
            this.gb_Search_Product.Size = new System.Drawing.Size(1639, 100);
            this.gb_Search_Product.TabIndex = 28;
            this.gb_Search_Product.TabStop = false;
            this.gb_Search_Product.Text = "Search Product";
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(1038, 40);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(426, 34);
            this.txt_Search.TabIndex = 12;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.Location = new System.Drawing.Point(892, 41);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(111, 32);
            this.lbl_Search.TabIndex = 11;
            this.lbl_Search.Text = "Search";
            // 
            // cb_Searchby
            // 
            this.cb_Searchby.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Searchby.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Searchby.FormattingEnabled = true;
            this.cb_Searchby.Items.AddRange(new object[] {
            "Product ID",
            "Category",
            "Product Name"});
            this.cb_Searchby.Location = new System.Drawing.Point(402, 40);
            this.cb_Searchby.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.cb_Searchby.Name = "cb_Searchby";
            this.cb_Searchby.Size = new System.Drawing.Size(362, 33);
            this.cb_Searchby.TabIndex = 10;
            this.cb_Searchby.SelectedIndexChanged += new System.EventHandler(this.cb_Searchby_SelectedIndexChanged);
            // 
            // lbl_SearchBy
            // 
            this.lbl_SearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SearchBy.AutoSize = true;
            this.lbl_SearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchBy.Location = new System.Drawing.Point(225, 41);
            this.lbl_SearchBy.Name = "lbl_SearchBy";
            this.lbl_SearchBy.Size = new System.Drawing.Size(154, 32);
            this.lbl_SearchBy.TabIndex = 2;
            this.lbl_SearchBy.Text = "Search By";
            // 
            // txt_Category
            // 
            this.txt_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Category.Location = new System.Drawing.Point(525, 82);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(309, 34);
            this.txt_Category.TabIndex = 27;
            // 
            // txt_Product_Name
            // 
            this.txt_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Product_Name.Location = new System.Drawing.Point(884, 83);
            this.txt_Product_Name.Name = "txt_Product_Name";
            this.txt_Product_Name.Size = new System.Drawing.Size(337, 34);
            this.txt_Product_Name.TabIndex = 28;
            // 
            // Frm_Update_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 977);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Search_Product);
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.gb_Product);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1680, 995);
            this.Name = "Frm_Update_Product";
            this.Text = "Update Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Update_Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.gb_Product.ResumeLayout(false);
            this.gb_Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.gb_Search_Product.ResumeLayout(false);
            this.gb_Search_Product.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Product;
        private System.Windows.Forms.ComboBox cmb_Distributor;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Distributor_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.Label lbl_Watt;
        private System.Windows.Forms.Label lbl_Unit_Price;
        private System.Windows.Forms.TextBox txt_Warranty;
        private System.Windows.Forms.TextBox txt_Unit_Price;
        private System.Windows.Forms.Label lbl_P_Warranty;
        private System.Windows.Forms.Label lbl_P_Price;
        private System.Windows.Forms.TextBox txt_Purchase_Price;
        private System.Windows.Forms.TextBox txt_Watt;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox gb_Search_Product;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.ComboBox cb_Searchby;
        private System.Windows.Forms.Label lbl_SearchBy;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.TextBox txt_Product_Name;
        private System.Windows.Forms.TextBox txt_Category;
    }
}
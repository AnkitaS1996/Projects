
namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    partial class Frm_Add_Product
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
            this.cmb_Distributor = new System.Windows.Forms.ComboBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Distributor_Name = new System.Windows.Forms.Label();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_Watt = new System.Windows.Forms.TextBox();
            this.lbl_Watt = new System.Windows.Forms.Label();
            this.txt_Purchase_Price = new System.Windows.Forms.TextBox();
            this.txt_Unit_Price = new System.Windows.Forms.TextBox();
            this.lbl_P_Price = new System.Windows.Forms.Label();
            this.lbl_Unit_Price = new System.Windows.Forms.Label();
            this.lbl_P_Warranty = new System.Windows.Forms.Label();
            this.txt_Warranty = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Sub_Product = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.gb_Product.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sub_Product)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pb_Exit);
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1662, 91);
            this.panel1.TabIndex = 4;
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
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Header.Location = new System.Drawing.Point(589, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(513, 69);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "ADD PRODUCT";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_Product
            // 
            this.gb_Product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Product.BackColor = System.Drawing.Color.DarkGray;
            this.gb_Product.Controls.Add(this.cmb_Distributor);
            this.gb_Product.Controls.Add(this.lbl_ID);
            this.gb_Product.Controls.Add(this.cmb_Category);
            this.gb_Product.Controls.Add(this.lbl_Distributor_Name);
            this.gb_Product.Controls.Add(this.cmb_Product_Name);
            this.gb_Product.Controls.Add(this.lbl_Product_Name);
            this.gb_Product.Controls.Add(this.txt_ID);
            this.gb_Product.Controls.Add(this.lbl_Date);
            this.gb_Product.Controls.Add(this.lbl_Category);
            this.gb_Product.Controls.Add(this.dtp_Date);
            this.gb_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product.Location = new System.Drawing.Point(12, 97);
            this.gb_Product.Name = "gb_Product";
            this.gb_Product.Size = new System.Drawing.Size(1647, 191);
            this.gb_Product.TabIndex = 6;
            this.gb_Product.TabStop = false;
            this.gb_Product.Text = "Product Details";
            // 
            // cmb_Distributor
            // 
            this.cmb_Distributor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Distributor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Distributor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Distributor.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Distributor.FormattingEnabled = true;
            this.cmb_Distributor.Location = new System.Drawing.Point(1155, 121);
            this.cmb_Distributor.Name = "cmb_Distributor";
            this.cmb_Distributor.Size = new System.Drawing.Size(453, 33);
            this.cmb_Distributor.TabIndex = 25;
            this.cmb_Distributor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Distributor_KeyDown);
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(105, 54);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(44, 32);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // cmb_Category
            // 
            this.cmb_Category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Category.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(1155, 50);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(453, 33);
            this.cmb_Category.TabIndex = 9;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            this.cmb_Category.TextChanged += new System.EventHandler(this.cmb_Category_TextChanged);
            // 
            // lbl_Distributor_Name
            // 
            this.lbl_Distributor_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Distributor_Name.AutoSize = true;
            this.lbl_Distributor_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Name.Location = new System.Drawing.Point(867, 121);
            this.lbl_Distributor_Name.Name = "lbl_Distributor_Name";
            this.lbl_Distributor_Name.Size = new System.Drawing.Size(243, 32);
            this.lbl_Distributor_Name.TabIndex = 24;
            this.lbl_Distributor_Name.Text = "Distributor Name";
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Product_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Product_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(335, 121);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(453, 33);
            this.cmb_Product_Name.TabIndex = 8;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(105, 122);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(207, 32);
            this.lbl_Product_Name.TabIndex = 3;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(172, 52);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(140, 34);
            this.txt_ID.TabIndex = 4;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(454, 54);
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
            this.lbl_Category.Location = new System.Drawing.Point(972, 53);
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
            this.dtp_Date.Location = new System.Drawing.Point(574, 52);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(195, 34);
            this.dtp_Date.TabIndex = 7;
            // 
            // txt_Watt
            // 
            this.txt_Watt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Watt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Watt.Location = new System.Drawing.Point(144, 72);
            this.txt_Watt.Name = "txt_Watt";
            this.txt_Watt.Size = new System.Drawing.Size(203, 34);
            this.txt_Watt.TabIndex = 21;
            this.txt_Watt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Watt_KeyDown);
            this.txt_Watt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Watt_KeyPress);
            // 
            // lbl_Watt
            // 
            this.lbl_Watt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Watt.AutoSize = true;
            this.lbl_Watt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Watt.Location = new System.Drawing.Point(199, 22);
            this.lbl_Watt.Name = "lbl_Watt";
            this.lbl_Watt.Size = new System.Drawing.Size(92, 32);
            this.lbl_Watt.TabIndex = 20;
            this.lbl_Watt.Text = "Watts";
            this.lbl_Watt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Purchase_Price
            // 
            this.txt_Purchase_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Purchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Purchase_Price.Location = new System.Drawing.Point(703, 72);
            this.txt_Purchase_Price.Name = "txt_Purchase_Price";
            this.txt_Purchase_Price.Size = new System.Drawing.Size(237, 34);
            this.txt_Purchase_Price.TabIndex = 17;
            this.txt_Purchase_Price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Purchase_Price_KeyDown);
            this.txt_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Purchase_Price_KeyPress);
            // 
            // txt_Unit_Price
            // 
            this.txt_Unit_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Unit_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Unit_Price.Location = new System.Drawing.Point(424, 72);
            this.txt_Unit_Price.Name = "txt_Unit_Price";
            this.txt_Unit_Price.Size = new System.Drawing.Size(187, 34);
            this.txt_Unit_Price.TabIndex = 15;
            this.txt_Unit_Price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Unit_Price_KeyDown);
            this.txt_Unit_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Unit_Price_KeyPress);
            // 
            // lbl_P_Price
            // 
            this.lbl_P_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_P_Price.AutoSize = true;
            this.lbl_P_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P_Price.Location = new System.Drawing.Point(709, 22);
            this.lbl_P_Price.Name = "lbl_P_Price";
            this.lbl_P_Price.Size = new System.Drawing.Size(221, 32);
            this.lbl_P_Price.TabIndex = 13;
            this.lbl_P_Price.Text = "Purchase Price";
            this.lbl_P_Price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Unit_Price
            // 
            this.lbl_Unit_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Unit_Price.AutoSize = true;
            this.lbl_Unit_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit_Price.Location = new System.Drawing.Point(442, 22);
            this.lbl_Unit_Price.Name = "lbl_Unit_Price";
            this.lbl_Unit_Price.Size = new System.Drawing.Size(148, 32);
            this.lbl_Unit_Price.TabIndex = 11;
            this.lbl_Unit_Price.Text = "Unit Price";
            this.lbl_Unit_Price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_P_Warranty
            // 
            this.lbl_P_Warranty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_P_Warranty.AutoSize = true;
            this.lbl_P_Warranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P_Warranty.Location = new System.Drawing.Point(1061, 22);
            this.lbl_P_Warranty.Name = "lbl_P_Warranty";
            this.lbl_P_Warranty.Size = new System.Drawing.Size(137, 32);
            this.lbl_P_Warranty.TabIndex = 23;
            this.lbl_P_Warranty.Text = "Warranty";
            this.lbl_P_Warranty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Warranty
            // 
            this.txt_Warranty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Warranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Warranty.Location = new System.Drawing.Point(1024, 72);
            this.txt_Warranty.Name = "txt_Warranty";
            this.txt_Warranty.Size = new System.Drawing.Size(220, 34);
            this.txt_Warranty.TabIndex = 24;
            this.txt_Warranty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Warranty_KeyDown);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(1349, 41);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(220, 64);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.lbl_Watt);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.lbl_Unit_Price);
            this.panel2.Controls.Add(this.txt_Warranty);
            this.panel2.Controls.Add(this.txt_Unit_Price);
            this.panel2.Controls.Add(this.lbl_P_Warranty);
            this.panel2.Controls.Add(this.lbl_P_Price);
            this.panel2.Controls.Add(this.txt_Purchase_Price);
            this.panel2.Controls.Add(this.txt_Watt);
            this.panel2.Location = new System.Drawing.Point(13, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1646, 127);
            this.panel2.TabIndex = 25;
            // 
            // dgv_Sub_Product
            // 
            this.dgv_Sub_Product.AllowUserToAddRows = false;
            this.dgv_Sub_Product.AllowUserToDeleteRows = false;
            this.dgv_Sub_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Sub_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Sub_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Sub_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Sub_Product.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Sub_Product.Location = new System.Drawing.Point(11, 428);
            this.dgv_Sub_Product.Name = "dgv_Sub_Product";
            this.dgv_Sub_Product.RowHeadersVisible = false;
            this.dgv_Sub_Product.RowHeadersWidth = 51;
            this.dgv_Sub_Product.RowTemplate.Height = 24;
            this.dgv_Sub_Product.Size = new System.Drawing.Size(1646, 435);
            this.dgv_Sub_Product.TabIndex = 26;
            this.dgv_Sub_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sub_Product_CellClick);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(890, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(231, 81);
            this.btn_Save.TabIndex = 27;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(533, 12);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(237, 81);
            this.btn_Refresh.TabIndex = 28;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.btn_Save);
            this.panel3.Controls.Add(this.btn_Refresh);
            this.panel3.Location = new System.Drawing.Point(11, 869);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1645, 96);
            this.panel3.TabIndex = 29;
            // 
            // Frm_Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 977);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_Sub_Product);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gb_Product);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1680, 995);
            this.Name = "Frm_Add_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Add_Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.gb_Product.ResumeLayout(false);
            this.gb_Product.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sub_Product)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Product;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.Label lbl_Distributor_Name;
        private System.Windows.Forms.TextBox txt_Watt;
        private System.Windows.Forms.Label lbl_Watt;
        private System.Windows.Forms.TextBox txt_Purchase_Price;
        private System.Windows.Forms.TextBox txt_Unit_Price;
        private System.Windows.Forms.Label lbl_P_Price;
        private System.Windows.Forms.Label lbl_Unit_Price;
        private System.Windows.Forms.Label lbl_P_Warranty;
        private System.Windows.Forms.TextBox txt_Warranty;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cmb_Distributor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Sub_Product;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel panel3;
    }
}
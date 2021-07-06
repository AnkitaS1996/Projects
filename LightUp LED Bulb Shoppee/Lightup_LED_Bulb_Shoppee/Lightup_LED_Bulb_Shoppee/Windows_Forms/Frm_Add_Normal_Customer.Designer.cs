
namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    partial class Frm_Add_Normal_Customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Customer_Detail = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gb_Product_Info = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_Cust_ID = new System.Windows.Forms.TextBox();
            this.txt_Cust_Name = new System.Windows.Forms.TextBox();
            this.txt_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Watt = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Unit_Price = new System.Windows.Forms.Label();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Watts = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Data_View = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Bill = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Total_Bills = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_Final_Bills = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Per = new System.Windows.Forms.Label();
            this.lbl_Percent = new System.Windows.Forms.Label();
            this.txt_Total_Bill = new System.Windows.Forms.TextBox();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.txt_GST = new System.Windows.Forms.TextBox();
            this.txt_Final_Bills = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gb_Customer_Detail.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gb_Product_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data_View)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pb_Exit);
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 91);
            this.panel1.TabIndex = 9;
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Header.Location = new System.Drawing.Point(411, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(589, 69);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Normal Customer";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_Customer_Detail
            // 
            this.gb_Customer_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Customer_Detail.Controls.Add(this.tableLayoutPanel1);
            this.gb_Customer_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer_Detail.Location = new System.Drawing.Point(0, 98);
            this.gb_Customer_Detail.Name = "gb_Customer_Detail";
            this.gb_Customer_Detail.Size = new System.Drawing.Size(1444, 140);
            this.gb_Customer_Detail.TabIndex = 10;
            this.gb_Customer_Detail.TabStop = false;
            this.gb_Customer_Detail.Text = "Customer Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.798867F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.20113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 399F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Customer_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Date, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Mobile_No, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtp_Date, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Cust_ID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Cust_Name, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Mobile_No, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1417, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.Location = new System.Drawing.Point(20, 9);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(236, 32);
            this.lbl_Customer_ID.TabIndex = 1;
            this.lbl_Customer_ID.Text = "Customer ID";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(730, 9);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(265, 32);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(20, 59);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(236, 32);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Customer Name";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(730, 59);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(265, 32);
            this.lbl_Mobile_No.TabIndex = 4;
            this.lbl_Mobile_No.Text = "Mobile Number";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.462687F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.53732F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Add, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Category, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Product_Name, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Watt, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Quantity, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Unit_Price, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Total_Price, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Watts, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Product_Name, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1411, 100);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // gb_Product_Info
            // 
            this.gb_Product_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Product_Info.Controls.Add(this.dgv_Data_View);
            this.gb_Product_Info.Controls.Add(this.tableLayoutPanel2);
            this.gb_Product_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_Info.Location = new System.Drawing.Point(12, 244);
            this.gb_Product_Info.Name = "gb_Product_Info";
            this.gb_Product_Info.Size = new System.Drawing.Size(1432, 411);
            this.gb_Product_Info.TabIndex = 12;
            this.gb_Product_Info.TabStop = false;
            this.gb_Product_Info.Text = "Product Information";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(1018, 6);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(359, 38);
            this.dtp_Date.TabIndex = 10;
            // 
            // txt_Cust_ID
            // 
            this.txt_Cust_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cust_ID.Location = new System.Drawing.Point(279, 6);
            this.txt_Cust_ID.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Cust_ID.Name = "txt_Cust_ID";
            this.txt_Cust_ID.Size = new System.Drawing.Size(404, 38);
            this.txt_Cust_ID.TabIndex = 11;
            // 
            // txt_Cust_Name
            // 
            this.txt_Cust_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cust_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cust_Name.Location = new System.Drawing.Point(279, 56);
            this.txt_Cust_Name.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Cust_Name.Name = "txt_Cust_Name";
            this.txt_Cust_Name.Size = new System.Drawing.Size(404, 38);
            this.txt_Cust_Name.TabIndex = 12;
            // 
            // txt_Mobile_No
            // 
            this.txt_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mobile_No.Location = new System.Drawing.Point(1018, 56);
            this.txt_Mobile_No.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Mobile_No.Name = "txt_Mobile_No";
            this.txt_Mobile_No.Size = new System.Drawing.Size(359, 38);
            this.txt_Mobile_No.TabIndex = 13;
            // 
            // lbl_Category
            // 
            this.lbl_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(21, 9);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(226, 32);
            this.lbl_Category.TabIndex = 4;
            this.lbl_Category.Text = "Category";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(253, 9);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(256, 32);
            this.lbl_Product_Name.TabIndex = 5;
            this.lbl_Product_Name.Text = "Product Name";
            this.lbl_Product_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Watt
            // 
            this.lbl_Watt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Watt.AutoSize = true;
            this.lbl_Watt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Watt.Location = new System.Drawing.Point(515, 9);
            this.lbl_Watt.Name = "lbl_Watt";
            this.lbl_Watt.Size = new System.Drawing.Size(208, 32);
            this.lbl_Watt.TabIndex = 6;
            this.lbl_Watt.Text = "Watts";
            this.lbl_Watt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(909, 9);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(168, 32);
            this.lbl_Quantity.TabIndex = 7;
            this.lbl_Quantity.Text = "Quantity";
            this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Unit_Price
            // 
            this.lbl_Unit_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Unit_Price.AutoSize = true;
            this.lbl_Unit_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit_Price.Location = new System.Drawing.Point(729, 9);
            this.lbl_Unit_Price.Name = "lbl_Unit_Price";
            this.lbl_Unit_Price.Size = new System.Drawing.Size(174, 32);
            this.lbl_Unit_Price.TabIndex = 8;
            this.lbl_Unit_Price.Text = "Unit Price";
            this.lbl_Unit_Price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.Location = new System.Drawing.Point(1083, 9);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(170, 32);
            this.lbl_Total_Price.TabIndex = 9;
            this.lbl_Total_Price.Text = "Total Price";
            this.lbl_Total_Price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 60);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 37);
            this.comboBox1.TabIndex = 10;
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(270, 60);
            this.cmb_Product_Name.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(222, 37);
            this.cmb_Product_Name.TabIndex = 11;
            // 
            // cmb_Watts
            // 
            this.cmb_Watts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Watts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Watts.FormattingEnabled = true;
            this.cmb_Watts.Location = new System.Drawing.Point(532, 60);
            this.cmb_Watts.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.cmb_Watts.Name = "cmb_Watts";
            this.cmb_Watts.Size = new System.Drawing.Size(174, 37);
            this.cmb_Watts.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(746, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 34);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(926, 58);
            this.textBox2.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 34);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(1100, 58);
            this.textBox3.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 34);
            this.textBox3.TabIndex = 15;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(1276, 53);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(98, 44);
            this.btn_Add.TabIndex = 17;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // dgv_Data_View
            // 
            this.dgv_Data_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Data_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data_View.Location = new System.Drawing.Point(6, 133);
            this.dgv_Data_View.Name = "dgv_Data_View";
            this.dgv_Data_View.RowHeadersWidth = 51;
            this.dgv_Data_View.RowTemplate.Height = 24;
            this.dgv_Data_View.Size = new System.Drawing.Size(1411, 272);
            this.dgv_Data_View.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Location = new System.Drawing.Point(12, 751);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1432, 74);
            this.panel2.TabIndex = 13;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(805, 0);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(256, 75);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Refresh.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(411, 0);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(235, 75);
            this.btn_Refresh.TabIndex = 16;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // gb_Bill
            // 
            this.gb_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Bill.Location = new System.Drawing.Point(12, 662);
            this.gb_Bill.Name = "gb_Bill";
            this.gb_Bill.Size = new System.Drawing.Size(1431, 83);
            this.gb_Bill.TabIndex = 14;
            this.gb_Bill.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 15;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.277545F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.3431F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15621F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.55788F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.762901F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.693166F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.719665F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.55788F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.764296F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.995816F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.719665F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9762901F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.22734F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.85356F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.324965F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_Total_Bills, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Discount, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Percent, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Per, 10, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Final_Bills, 12, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_Total_Bill, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_Discount, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_GST, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_Final_Bills, 13, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 674);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1434, 65);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lbl_Total_Bills
            // 
            this.lbl_Total_Bills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total_Bills.AutoSize = true;
            this.lbl_Total_Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bills.Location = new System.Drawing.Point(50, 16);
            this.lbl_Total_Bills.Name = "lbl_Total_Bills";
            this.lbl_Total_Bills.Size = new System.Drawing.Size(171, 32);
            this.lbl_Total_Bills.TabIndex = 2;
            this.lbl_Total_Bills.Text = "Total Bills";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(438, 16);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(134, 32);
            this.lbl_Discount.TabIndex = 3;
            this.lbl_Discount.Text = "Discount";
            // 
            // lbl_Final_Bills
            // 
            this.lbl_Final_Bills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Final_Bills.AutoSize = true;
            this.lbl_Final_Bills.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Final_Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Final_Bills.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Final_Bills.Location = new System.Drawing.Point(1043, 16);
            this.lbl_Final_Bills.Name = "lbl_Final_Bills";
            this.lbl_Final_Bills.Size = new System.Drawing.Size(155, 32);
            this.lbl_Final_Bills.TabIndex = 5;
            this.lbl_Final_Bills.Text = "Final Bills";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(764, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "GST ";
            // 
            // lbl_Per
            // 
            this.lbl_Per.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Per.AutoSize = true;
            this.lbl_Per.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Per.Location = new System.Drawing.Point(990, 16);
            this.lbl_Per.Name = "lbl_Per";
            this.lbl_Per.Size = new System.Drawing.Size(33, 32);
            this.lbl_Per.TabIndex = 7;
            this.lbl_Per.Text = "%";
            // 
            // lbl_Percent
            // 
            this.lbl_Percent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Percent.AutoSize = true;
            this.lbl_Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Percent.Location = new System.Drawing.Point(717, 16);
            this.lbl_Percent.Name = "lbl_Percent";
            this.lbl_Percent.Size = new System.Drawing.Size(33, 32);
            this.lbl_Percent.TabIndex = 8;
            this.lbl_Percent.Text = "%";
            // 
            // txt_Total_Bill
            // 
            this.txt_Total_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Bill.Location = new System.Drawing.Point(244, 13);
            this.txt_Total_Bill.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Total_Bill.Name = "txt_Total_Bill";
            this.txt_Total_Bill.Size = new System.Drawing.Size(163, 38);
            this.txt_Total_Bill.TabIndex = 14;
            // 
            // txt_Discount
            // 
            this.txt_Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Discount.Location = new System.Drawing.Point(595, 13);
            this.txt_Discount.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(99, 38);
            this.txt_Discount.TabIndex = 15;
            // 
            // txt_GST
            // 
            this.txt_GST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_GST.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GST.Location = new System.Drawing.Point(878, 13);
            this.txt_GST.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_GST.Name = "txt_GST";
            this.txt_GST.Size = new System.Drawing.Size(89, 38);
            this.txt_GST.TabIndex = 16;
            // 
            // txt_Final_Bills
            // 
            this.txt_Final_Bills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Final_Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Final_Bills.Location = new System.Drawing.Point(1221, 13);
            this.txt_Final_Bills.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Final_Bills.Name = "txt_Final_Bills";
            this.txt_Final_Bills.Size = new System.Drawing.Size(173, 38);
            this.txt_Final_Bills.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Lightup_LED_Bulb_Shoppee.Properties.Resources._77_771475_x_exit_button_icon_symbol_vector_illustration_hong;
            this.pictureBox1.Location = new System.Drawing.Point(1398, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pb_Exit
            // 
            this.pb_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Exit.Image = global::Lightup_LED_Bulb_Shoppee.Properties.Resources._77_771475_x_exit_button_icon_symbol_vector_illustration_hong;
            this.pb_Exit.Location = new System.Drawing.Point(1902, 3);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(54, 45);
            this.pb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Exit.TabIndex = 1;
            this.pb_Exit.TabStop = false;
            // 
            // Frm_Add_Normal_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 837);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.gb_Bill);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gb_Product_Info);
            this.Controls.Add(this.gb_Customer_Detail);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Add_Normal_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Normal Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Customer_Detail.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gb_Product_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data_View)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Customer_Detail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gb_Product_Info;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox txt_Cust_ID;
        private System.Windows.Forms.TextBox txt_Cust_Name;
        private System.Windows.Forms.TextBox txt_Mobile_No;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Watt;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Unit_Price;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Watts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_Data_View;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.GroupBox gb_Bill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_Total_Bills;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_Percent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Per;
        private System.Windows.Forms.Label lbl_Final_Bills;
        private System.Windows.Forms.TextBox txt_Total_Bill;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.TextBox txt_GST;
        private System.Windows.Forms.TextBox txt_Final_Bills;
    }
}

namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    partial class Frm_Retailer_Order
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
            this.gb_Product_Info = new System.Windows.Forms.GroupBox();
            this.dgv_Data_View = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Watt = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Unit_Price = new System.Windows.Forms.Label();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.cmb_Watts = new System.Windows.Forms.ComboBox();
            this.txt_Unit_Price = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Total_Price = new System.Windows.Forms.TextBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Total_Bills = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_Percent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Per = new System.Windows.Forms.Label();
            this.lbl_Final_Bills = new System.Windows.Forms.Label();
            this.txt_Total_Bill = new System.Windows.Forms.TextBox();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.txt_GST = new System.Windows.Forms.TextBox();
            this.txt_Final_Bills = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Exits = new System.Windows.Forms.PictureBox();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Customer_Detail = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_Cust_ID = new System.Windows.Forms.TextBox();
            this.txt_Cust_Name = new System.Windows.Forms.TextBox();
            this.txt_Mobile_No = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.gb_Bill = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Paid_Bill = new System.Windows.Forms.Label();
            this.txt_Paid_Bills = new System.Windows.Forms.TextBox();
            this.lbl_Remaining_Bill = new System.Windows.Forms.Label();
            this.txt_Remaining_Bills = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Order_ID = new System.Windows.Forms.Label();
            this.txt_Order_ID = new System.Windows.Forms.TextBox();
            this.gb_Product_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data_View)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.gb_Customer_Detail.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_Bill.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Product_Info
            // 
            this.gb_Product_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Product_Info.Controls.Add(this.dgv_Data_View);
            this.gb_Product_Info.Controls.Add(this.tableLayoutPanel2);
            this.gb_Product_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_Info.Location = new System.Drawing.Point(18, 335);
            this.gb_Product_Info.Name = "gb_Product_Info";
            this.gb_Product_Info.Size = new System.Drawing.Size(1513, 378);
            this.gb_Product_Info.TabIndex = 13;
            this.gb_Product_Info.TabStop = false;
            this.gb_Product_Info.Text = "Product Information";
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
            this.dgv_Data_View.Size = new System.Drawing.Size(1492, 239);
            this.dgv_Data_View.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.462687F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.53732F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Add, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Category, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Product_Name, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Watt, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Quantity, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Unit_Price, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Total_Price, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Category, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Watts, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_Unit_Price, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_Quantity, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_Total_Price, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Product_Name, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1492, 100);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(1351, 53);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(98, 44);
            this.btn_Add.TabIndex = 17;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // lbl_Category
            // 
            this.lbl_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(21, 9);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(225, 32);
            this.lbl_Category.TabIndex = 4;
            this.lbl_Category.Text = "Category";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(252, 9);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(262, 32);
            this.lbl_Product_Name.TabIndex = 5;
            this.lbl_Product_Name.Text = "Product Name";
            this.lbl_Product_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Watt
            // 
            this.lbl_Watt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Watt.AutoSize = true;
            this.lbl_Watt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Watt.Location = new System.Drawing.Point(520, 9);
            this.lbl_Watt.Name = "lbl_Watt";
            this.lbl_Watt.Size = new System.Drawing.Size(226, 32);
            this.lbl_Watt.TabIndex = 6;
            this.lbl_Watt.Text = "Watts";
            this.lbl_Watt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(966, 9);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(169, 32);
            this.lbl_Quantity.TabIndex = 7;
            this.lbl_Quantity.Text = "Quantity";
            this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Unit_Price
            // 
            this.lbl_Unit_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Unit_Price.AutoSize = true;
            this.lbl_Unit_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit_Price.Location = new System.Drawing.Point(752, 9);
            this.lbl_Unit_Price.Name = "lbl_Unit_Price";
            this.lbl_Unit_Price.Size = new System.Drawing.Size(208, 32);
            this.lbl_Unit_Price.TabIndex = 8;
            this.lbl_Unit_Price.Text = "Unit Price";
            this.lbl_Unit_Price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.Location = new System.Drawing.Point(1141, 9);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(187, 32);
            this.lbl_Total_Price.TabIndex = 9;
            this.lbl_Total_Price.Text = "Total Price";
            this.lbl_Total_Price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmb_Category
            // 
            this.cmb_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(38, 56);
            this.cmb_Category.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(191, 37);
            this.cmb_Category.TabIndex = 10;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            this.cmb_Category.TextChanged += new System.EventHandler(this.cmb_Category_TextChanged);
            // 
            // cmb_Watts
            // 
            this.cmb_Watts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Watts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Watts.FormattingEnabled = true;
            this.cmb_Watts.Location = new System.Drawing.Point(537, 56);
            this.cmb_Watts.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.cmb_Watts.Name = "cmb_Watts";
            this.cmb_Watts.Size = new System.Drawing.Size(192, 37);
            this.cmb_Watts.TabIndex = 12;
            this.cmb_Watts.SelectedIndexChanged += new System.EventHandler(this.cmb_Watts_SelectedIndexChanged);
            this.cmb_Watts.TextChanged += new System.EventHandler(this.cmb_Watts_TextChanged);
            // 
            // txt_Unit_Price
            // 
            this.txt_Unit_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Unit_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Unit_Price.Location = new System.Drawing.Point(769, 58);
            this.txt_Unit_Price.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Unit_Price.Name = "txt_Unit_Price";
            this.txt_Unit_Price.Size = new System.Drawing.Size(174, 34);
            this.txt_Unit_Price.TabIndex = 13;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(983, 58);
            this.txt_Quantity.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(135, 34);
            this.txt_Quantity.TabIndex = 14;
            this.txt_Quantity.TextChanged += new System.EventHandler(this.txt_Quantity_TextChanged);
            // 
            // txt_Total_Price
            // 
            this.txt_Total_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Price.Location = new System.Drawing.Point(1158, 58);
            this.txt_Total_Price.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Total_Price.Name = "txt_Total_Price";
            this.txt_Total_Price.Size = new System.Drawing.Size(153, 34);
            this.txt_Total_Price.TabIndex = 15;
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(269, 56);
            this.cmb_Product_Name.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(228, 37);
            this.cmb_Product_Name.TabIndex = 11;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            this.cmb_Product_Name.TextChanged += new System.EventHandler(this.cmb_Product_Name_TextChanged);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1492, 62);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // lbl_Total_Bills
            // 
            this.lbl_Total_Bills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total_Bills.AutoSize = true;
            this.lbl_Total_Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bills.Location = new System.Drawing.Point(51, 15);
            this.lbl_Total_Bills.Name = "lbl_Total_Bills";
            this.lbl_Total_Bills.Size = new System.Drawing.Size(178, 32);
            this.lbl_Total_Bills.TabIndex = 2;
            this.lbl_Total_Bills.Text = "Total Bills";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(454, 15);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(139, 32);
            this.lbl_Discount.TabIndex = 3;
            this.lbl_Discount.Text = "Discount";
            // 
            // lbl_Percent
            // 
            this.lbl_Percent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Percent.AutoSize = true;
            this.lbl_Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Percent.Location = new System.Drawing.Point(743, 15);
            this.lbl_Percent.Name = "lbl_Percent";
            this.lbl_Percent.Size = new System.Drawing.Size(34, 32);
            this.lbl_Percent.TabIndex = 8;
            this.lbl_Percent.Text = "%";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(791, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "GST ";
            // 
            // lbl_Per
            // 
            this.lbl_Per.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Per.AutoSize = true;
            this.lbl_Per.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Per.Location = new System.Drawing.Point(1025, 15);
            this.lbl_Per.Name = "lbl_Per";
            this.lbl_Per.Size = new System.Drawing.Size(34, 32);
            this.lbl_Per.TabIndex = 7;
            this.lbl_Per.Text = "%";
            // 
            // lbl_Final_Bills
            // 
            this.lbl_Final_Bills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Final_Bills.AutoSize = true;
            this.lbl_Final_Bills.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Final_Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Final_Bills.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Final_Bills.Location = new System.Drawing.Point(1079, 15);
            this.lbl_Final_Bills.Name = "lbl_Final_Bills";
            this.lbl_Final_Bills.Size = new System.Drawing.Size(161, 32);
            this.lbl_Final_Bills.TabIndex = 5;
            this.lbl_Final_Bills.Text = "Final Bills";
            // 
            // txt_Total_Bill
            // 
            this.txt_Total_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Bill.Location = new System.Drawing.Point(252, 12);
            this.txt_Total_Bill.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Total_Bill.Name = "txt_Total_Bill";
            this.txt_Total_Bill.Size = new System.Drawing.Size(171, 38);
            this.txt_Total_Bill.TabIndex = 14;
            // 
            // txt_Discount
            // 
            this.txt_Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Discount.Location = new System.Drawing.Point(616, 12);
            this.txt_Discount.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(104, 38);
            this.txt_Discount.TabIndex = 15;
            // 
            // txt_GST
            // 
            this.txt_GST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_GST.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GST.Location = new System.Drawing.Point(908, 12);
            this.txt_GST.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_GST.Name = "txt_GST";
            this.txt_GST.Size = new System.Drawing.Size(94, 38);
            this.txt_GST.TabIndex = 16;
            // 
            // txt_Final_Bills
            // 
            this.txt_Final_Bills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Final_Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Final_Bills.Location = new System.Drawing.Point(1263, 12);
            this.txt_Final_Bills.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Final_Bills.Name = "txt_Final_Bills";
            this.txt_Final_Bills.Size = new System.Drawing.Size(181, 38);
            this.txt_Final_Bills.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pb_Exits);
            this.panel1.Controls.Add(this.pb_Exit);
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1537, 91);
            this.panel1.TabIndex = 15;
            // 
            // pb_Exits
            // 
            this.pb_Exits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Exits.Image = global::Lightup_LED_Bulb_Shoppee.Properties.Resources._77_771475_x_exit_button_icon_symbol_vector_illustration_hong;
            this.pb_Exits.Location = new System.Drawing.Point(1480, 0);
            this.pb_Exits.Name = "pb_Exits";
            this.pb_Exits.Size = new System.Drawing.Size(54, 45);
            this.pb_Exits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Exits.TabIndex = 2;
            this.pb_Exits.TabStop = false;
            this.pb_Exits.Click += new System.EventHandler(this.pb_Exits_Click);
            // 
            // pb_Exit
            // 
            this.pb_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Exit.Image = global::Lightup_LED_Bulb_Shoppee.Properties.Resources._77_771475_x_exit_button_icon_symbol_vector_illustration_hong;
            this.pb_Exit.Location = new System.Drawing.Point(1984, 3);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(54, 45);
            this.pb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Exit.TabIndex = 1;
            this.pb_Exit.TabStop = false;
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Header.Location = new System.Drawing.Point(538, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(485, 69);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Retailer Order";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_Customer_Detail
            // 
            this.gb_Customer_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Customer_Detail.Controls.Add(this.tableLayoutPanel1);
            this.gb_Customer_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer_Detail.Location = new System.Drawing.Point(12, 170);
            this.gb_Customer_Detail.Name = "gb_Customer_Detail";
            this.gb_Customer_Detail.Size = new System.Drawing.Size(1513, 159);
            this.gb_Customer_Detail.TabIndex = 16;
            this.gb_Customer_Detail.TabStop = false;
            this.gb_Customer_Detail.Text = "Customer Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.11027F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.88973F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 426F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Customer_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Date, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Mobile_No, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtp_Date, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Cust_ID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Cust_Name, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Mobile_No, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Search, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5873F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.4127F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1486, 126);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.Location = new System.Drawing.Point(54, 16);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(241, 32);
            this.lbl_Customer_ID.TabIndex = 1;
            this.lbl_Customer_ID.Text = "Customer ID";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(915, 16);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(232, 32);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(54, 79);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(241, 32);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Customer Name";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(915, 79);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(232, 32);
            this.lbl_Mobile_No.TabIndex = 4;
            this.lbl_Mobile_No.Text = "Mobile Number";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(1170, 13);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(245, 38);
            this.dtp_Date.TabIndex = 10;
            // 
            // txt_Cust_ID
            // 
            this.txt_Cust_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cust_ID.Location = new System.Drawing.Point(318, 13);
            this.txt_Cust_ID.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Cust_ID.Name = "txt_Cust_ID";
            this.txt_Cust_ID.Size = new System.Drawing.Size(386, 38);
            this.txt_Cust_ID.TabIndex = 11;
            // 
            // txt_Cust_Name
            // 
            this.txt_Cust_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cust_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cust_Name.Location = new System.Drawing.Point(318, 76);
            this.txt_Cust_Name.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Cust_Name.Name = "txt_Cust_Name";
            this.txt_Cust_Name.Size = new System.Drawing.Size(386, 38);
            this.txt_Cust_Name.TabIndex = 12;
            // 
            // txt_Mobile_No
            // 
            this.txt_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mobile_No.Location = new System.Drawing.Point(1170, 76);
            this.txt_Mobile_No.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Mobile_No.Name = "txt_Mobile_No";
            this.txt_Mobile_No.Size = new System.Drawing.Size(245, 38);
            this.txt_Mobile_No.TabIndex = 13;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Search.Location = new System.Drawing.Point(744, 3);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(148, 57);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // gb_Bill
            // 
            this.gb_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Bill.Controls.Add(this.tableLayoutPanel4);
            this.gb_Bill.Controls.Add(this.tableLayoutPanel3);
            this.gb_Bill.Location = new System.Drawing.Point(15, 719);
            this.gb_Bill.Name = "gb_Bill";
            this.gb_Bill.Size = new System.Drawing.Size(1513, 160);
            this.gb_Bill.TabIndex = 17;
            this.gb_Bill.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.277545F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.3431F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15621F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.55788F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.762901F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.693166F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.719665F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_Paid_Bill, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_Paid_Bills, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_Remaining_Bill, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_Remaining_Bills, 5, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1510, 59);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // lbl_Paid_Bill
            // 
            this.lbl_Paid_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Paid_Bill.AutoSize = true;
            this.lbl_Paid_Bill.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Paid_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid_Bill.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Paid_Bill.Location = new System.Drawing.Point(97, 13);
            this.lbl_Paid_Bill.Name = "lbl_Paid_Bill";
            this.lbl_Paid_Bill.Size = new System.Drawing.Size(348, 32);
            this.lbl_Paid_Bill.TabIndex = 2;
            this.lbl_Paid_Bill.Text = "Paid Bills";
            // 
            // txt_Paid_Bills
            // 
            this.txt_Paid_Bills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Paid_Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Paid_Bills.Location = new System.Drawing.Point(468, 10);
            this.txt_Paid_Bills.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Paid_Bills.Name = "txt_Paid_Bills";
            this.txt_Paid_Bills.Size = new System.Drawing.Size(367, 38);
            this.txt_Paid_Bills.TabIndex = 14;
            // 
            // lbl_Remaining_Bill
            // 
            this.lbl_Remaining_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Remaining_Bill.AutoSize = true;
            this.lbl_Remaining_Bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Remaining_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remaining_Bill.ForeColor = System.Drawing.Color.Red;
            this.lbl_Remaining_Bill.Location = new System.Drawing.Point(874, 13);
            this.lbl_Remaining_Bill.Name = "lbl_Remaining_Bill";
            this.lbl_Remaining_Bill.Size = new System.Drawing.Size(274, 32);
            this.lbl_Remaining_Bill.TabIndex = 5;
            this.lbl_Remaining_Bill.Text = "Remaining Bills";
            // 
            // txt_Remaining_Bills
            // 
            this.txt_Remaining_Bills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Remaining_Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Remaining_Bills.Location = new System.Drawing.Point(1171, 10);
            this.txt_Remaining_Bills.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Remaining_Bills.Name = "txt_Remaining_Bills";
            this.txt_Remaining_Bills.Size = new System.Drawing.Size(238, 38);
            this.txt_Remaining_Bills.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Location = new System.Drawing.Point(12, 885);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1522, 84);
            this.panel2.TabIndex = 18;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(850, 0);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(256, 84);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Refresh.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(454, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(235, 81);
            this.btn_Refresh.TabIndex = 16;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1516, 75);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.90816F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64541F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.92347F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.39541F));
            this.tableLayoutPanel5.Controls.Add(this.lbl_Order_ID, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txt_Order_ID, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 10);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1501, 57);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // lbl_Order_ID
            // 
            this.lbl_Order_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Order_ID.AutoSize = true;
            this.lbl_Order_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_ID.Location = new System.Drawing.Point(497, 12);
            this.lbl_Order_ID.Name = "lbl_Order_ID";
            this.lbl_Order_ID.Size = new System.Drawing.Size(244, 32);
            this.lbl_Order_ID.TabIndex = 2;
            this.lbl_Order_ID.Text = "Order ID";
            this.lbl_Order_ID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Order_ID
            // 
            this.txt_Order_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Order_ID.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Order_ID.Enabled = false;
            this.txt_Order_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Order_ID.Location = new System.Drawing.Point(764, 9);
            this.txt_Order_ID.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Order_ID.Name = "txt_Order_ID";
            this.txt_Order_ID.Size = new System.Drawing.Size(184, 38);
            this.txt_Order_ID.TabIndex = 12;
            // 
            // Frm_Retailer_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 981);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Customer_Detail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gb_Bill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_Product_Info);
            this.Name = "Frm_Retailer_Order";
            this.Text = "Retailer Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Retailer_Order_Load);
            this.gb_Product_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data_View)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.gb_Customer_Detail.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gb_Bill.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Product_Info;
        private System.Windows.Forms.DataGridView dgv_Data_View;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Watt;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Unit_Price;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.ComboBox cmb_Watts;
        private System.Windows.Forms.TextBox txt_Unit_Price;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Total_Price;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Exits;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Customer_Detail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox txt_Cust_ID;
        private System.Windows.Forms.TextBox txt_Cust_Name;
        private System.Windows.Forms.TextBox txt_Mobile_No;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gb_Bill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_Paid_Bill;
        private System.Windows.Forms.TextBox txt_Paid_Bills;
        private System.Windows.Forms.Label lbl_Remaining_Bill;
        private System.Windows.Forms.TextBox txt_Remaining_Bills;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbl_Order_ID;
        private System.Windows.Forms.TextBox txt_Order_ID;
    }
}

namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    partial class Frm_Accept_Payment
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
            this.pb_Exits = new System.Windows.Forms.PictureBox();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Search_Details = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Pending_Payment = new System.Windows.Forms.Label();
            this.txt_Pending_Bills = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Order_ID = new System.Windows.Forms.Label();
            this.lbl_Retailer_ID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Total_Final_Bill = new System.Windows.Forms.TextBox();
            this.txt_Total_Pay_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Total_Final_Bill = new System.Windows.Forms.Label();
            this.lbl_Pay_Bill = new System.Windows.Forms.Label();
            this.lbl_Remaing_Amount = new System.Windows.Forms.Label();
            this.lbl_Total_Pay = new System.Windows.Forms.Label();
            this.txt_Total_Pay = new System.Windows.Forms.TextBox();
            this.txt_Remaining_Amount = new System.Windows.Forms.TextBox();
            this.gb_Payment_Accept = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.gb_Search_Details.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_Payment_Accept.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1370, 91);
            this.panel1.TabIndex = 16;
            // 
            // pb_Exits
            // 
            this.pb_Exits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Exits.Image = global::Lightup_LED_Bulb_Shoppee.Properties.Resources._77_771475_x_exit_button_icon_symbol_vector_illustration_hong;
            this.pb_Exits.Location = new System.Drawing.Point(1313, 0);
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
            this.pb_Exit.Location = new System.Drawing.Point(1817, 3);
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
            this.lbl_Header.Location = new System.Drawing.Point(455, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(533, 69);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Accept Payment";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_Search_Details
            // 
            this.gb_Search_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Search_Details.Controls.Add(this.tableLayoutPanel4);
            this.gb_Search_Details.Controls.Add(this.tableLayoutPanel2);
            this.gb_Search_Details.Controls.Add(this.tableLayoutPanel1);
            this.gb_Search_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Search_Details.Location = new System.Drawing.Point(4, 112);
            this.gb_Search_Details.Name = "gb_Search_Details";
            this.gb_Search_Details.Size = new System.Drawing.Size(1354, 360);
            this.gb_Search_Details.TabIndex = 17;
            this.gb_Search_Details.TabStop = false;
            this.gb_Search_Details.Text = "Search Details";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_Pending_Payment, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_Pending_Bills, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(13, 263);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1337, 91);
            this.tableLayoutPanel4.TabIndex = 28;
            // 
            // lbl_Pending_Payment
            // 
            this.lbl_Pending_Payment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Pending_Payment.AutoSize = true;
            this.lbl_Pending_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pending_Payment.Location = new System.Drawing.Point(354, 31);
            this.lbl_Pending_Payment.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_Pending_Payment.Name = "lbl_Pending_Payment";
            this.lbl_Pending_Payment.Size = new System.Drawing.Size(294, 29);
            this.lbl_Pending_Payment.TabIndex = 2;
            this.lbl_Pending_Payment.Text = "Total Pending Payment";
            // 
            // txt_Pending_Bills
            // 
            this.txt_Pending_Bills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Pending_Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pending_Bills.Location = new System.Drawing.Point(688, 26);
            this.txt_Pending_Bills.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Pending_Bills.Name = "txt_Pending_Bills";
            this.txt_Pending_Bills.Size = new System.Drawing.Size(294, 38);
            this.txt_Pending_Bills.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.208401F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.83199F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.12439F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.67044F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.373183F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.88207F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.01292F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.704362F));
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Search, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Order_ID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Retailer_ID, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1337, 93);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1026, 29);
            this.textBox2.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 34);
            this.textBox2.TabIndex = 6;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(578, 20);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(167, 53);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(351, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 38);
            this.textBox1.TabIndex = 5;
            // 
            // lbl_Order_ID
            // 
            this.lbl_Order_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Order_ID.AutoSize = true;
            this.lbl_Order_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_ID.Location = new System.Drawing.Point(142, 30);
            this.lbl_Order_ID.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_Order_ID.Name = "lbl_Order_ID";
            this.lbl_Order_ID.Size = new System.Drawing.Size(169, 32);
            this.lbl_Order_ID.TabIndex = 0;
            this.lbl_Order_ID.Text = "Order ID";
            // 
            // lbl_Retailer_ID
            // 
            this.lbl_Retailer_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Retailer_ID.AutoSize = true;
            this.lbl_Retailer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Retailer_ID.Location = new System.Drawing.Point(803, 30);
            this.lbl_Retailer_ID.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_Retailer_ID.Name = "lbl_Retailer_ID";
            this.lbl_Retailer_ID.Size = new System.Drawing.Size(183, 32);
            this.lbl_Retailer_ID.TabIndex = 1;
            this.lbl_Retailer_ID.Text = "Retailer ID";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.828742F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.02978F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.3172F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.042442F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.28518F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.91214F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.510052F));
            this.tableLayoutPanel1.Controls.Add(this.txt_Total_Final_Bill, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Total_Pay_Bill, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Total_Final_Bill, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Pay_Bill, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 157);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1343, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txt_Total_Final_Bill
            // 
            this.txt_Total_Final_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total_Final_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Final_Bill.Location = new System.Drawing.Point(421, 31);
            this.txt_Total_Final_Bill.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Total_Final_Bill.Name = "txt_Total_Final_Bill";
            this.txt_Total_Final_Bill.Size = new System.Drawing.Size(206, 38);
            this.txt_Total_Final_Bill.TabIndex = 12;
            // 
            // txt_Total_Pay_Bill
            // 
            this.txt_Total_Pay_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total_Pay_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Pay_Bill.Location = new System.Drawing.Point(940, 31);
            this.txt_Total_Pay_Bill.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Total_Pay_Bill.Name = "txt_Total_Pay_Bill";
            this.txt_Total_Pay_Bill.Size = new System.Drawing.Size(308, 38);
            this.txt_Total_Pay_Bill.TabIndex = 9;
            // 
            // lbl_Total_Final_Bill
            // 
            this.lbl_Total_Final_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total_Final_Bill.AutoSize = true;
            this.lbl_Total_Final_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Final_Bill.Location = new System.Drawing.Point(152, 34);
            this.lbl_Total_Final_Bill.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_Total_Final_Bill.Name = "lbl_Total_Final_Bill";
            this.lbl_Total_Final_Bill.Size = new System.Drawing.Size(229, 32);
            this.lbl_Total_Final_Bill.TabIndex = 11;
            this.lbl_Total_Final_Bill.Text = "Total Final Bill";
            // 
            // lbl_Pay_Bill
            // 
            this.lbl_Pay_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Pay_Bill.AutoSize = true;
            this.lbl_Pay_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pay_Bill.Location = new System.Drawing.Point(681, 34);
            this.lbl_Pay_Bill.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_Pay_Bill.Name = "lbl_Pay_Bill";
            this.lbl_Pay_Bill.Size = new System.Drawing.Size(219, 32);
            this.lbl_Pay_Bill.TabIndex = 13;
            this.lbl_Pay_Bill.Text = "Total Pay Bill";
            // 
            // lbl_Remaing_Amount
            // 
            this.lbl_Remaing_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Remaing_Amount.AutoSize = true;
            this.lbl_Remaing_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remaing_Amount.Location = new System.Drawing.Point(666, 27);
            this.lbl_Remaing_Amount.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_Remaing_Amount.Name = "lbl_Remaing_Amount";
            this.lbl_Remaing_Amount.Size = new System.Drawing.Size(279, 32);
            this.lbl_Remaing_Amount.TabIndex = 3;
            this.lbl_Remaing_Amount.Text = "Remaining Amount";
            // 
            // lbl_Total_Pay
            // 
            this.lbl_Total_Pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total_Pay.AutoSize = true;
            this.lbl_Total_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Pay.Location = new System.Drawing.Point(178, 27);
            this.lbl_Total_Pay.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_Total_Pay.Name = "lbl_Total_Pay";
            this.lbl_Total_Pay.Size = new System.Drawing.Size(158, 32);
            this.lbl_Total_Pay.TabIndex = 4;
            this.lbl_Total_Pay.Text = "Total Pay";
            // 
            // txt_Total_Pay
            // 
            this.txt_Total_Pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Pay.Location = new System.Drawing.Point(376, 26);
            this.txt_Total_Pay.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Total_Pay.Name = "txt_Total_Pay";
            this.txt_Total_Pay.Size = new System.Drawing.Size(234, 34);
            this.txt_Total_Pay.TabIndex = 7;
            // 
            // txt_Remaining_Amount
            // 
            this.txt_Remaining_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Remaining_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Remaining_Amount.Location = new System.Drawing.Point(985, 26);
            this.txt_Remaining_Amount.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Remaining_Amount.Name = "txt_Remaining_Amount";
            this.txt_Remaining_Amount.Size = new System.Drawing.Size(172, 34);
            this.txt_Remaining_Amount.TabIndex = 8;
            // 
            // gb_Payment_Accept
            // 
            this.gb_Payment_Accept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Payment_Accept.Controls.Add(this.tableLayoutPanel3);
            this.gb_Payment_Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Payment_Accept.Location = new System.Drawing.Point(15, 478);
            this.gb_Payment_Accept.Name = "gb_Payment_Accept";
            this.gb_Payment_Accept.Size = new System.Drawing.Size(1339, 138);
            this.gb_Payment_Accept.TabIndex = 18;
            this.gb_Payment_Accept.TabStop = false;
            this.gb_Payment_Accept.Text = "Payment Accept";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.8923F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.95886F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.64323F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.271503F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.00898F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.00598F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.8175F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_Total_Pay, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_Total_Pay, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_Remaining_Amount, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Remaing_Amount, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 29);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1337, 87);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Location = new System.Drawing.Point(14, 622);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1340, 100);
            this.panel2.TabIndex = 27;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(705, 12);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(241, 76);
            this.btn_Refresh.TabIndex = 19;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(395, 18);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(241, 70);
            this.btn_Save.TabIndex = 18;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // Frm_Accept_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 734);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gb_Payment_Accept);
            this.Controls.Add(this.gb_Search_Details);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Accept_Payment";
            this.Text = "Accept Payment";
            this.Load += new System.EventHandler(this.Frm_Accept_Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.gb_Search_Details.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gb_Payment_Accept.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Exits;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Search_Details;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Order_ID;
        private System.Windows.Forms.Label lbl_Retailer_ID;
        private System.Windows.Forms.Label lbl_Pending_Payment;
        private System.Windows.Forms.Label lbl_Remaing_Amount;
        private System.Windows.Forms.Label lbl_Total_Pay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_Total_Pay;
        private System.Windows.Forms.TextBox txt_Remaining_Amount;
        private System.Windows.Forms.TextBox txt_Total_Pay_Bill;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Total_Final_Bill;
        private System.Windows.Forms.Label lbl_Total_Final_Bill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gb_Payment_Accept;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txt_Pending_Bills;
        private System.Windows.Forms.Label lbl_Pay_Bill;
    }
}
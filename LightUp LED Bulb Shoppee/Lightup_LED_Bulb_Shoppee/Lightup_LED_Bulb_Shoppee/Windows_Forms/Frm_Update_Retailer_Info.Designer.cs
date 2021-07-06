
namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    partial class Frm_Update_Retailer_Info
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
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Retailer_Info = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_M_No = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Alter_Number = new System.Windows.Forms.Label();
            this.txt_Alter_No = new System.Windows.Forms.TextBox();
            this.lbl_PAN_No = new System.Windows.Forms.Label();
            this.txt_PAN_No = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_Addhar_No = new System.Windows.Forms.Label();
            this.txt_Addhar_No = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_View_Data = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.gb_Retailer_Info.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Data)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1317, 91);
            this.panel1.TabIndex = 8;
            // 
            // pb_Exit
            // 
            this.pb_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Exit.Image = global::Lightup_LED_Bulb_Shoppee.Properties.Resources._77_771475_x_exit_button_icon_symbol_vector_illustration_hong;
            this.pb_Exit.Location = new System.Drawing.Point(1260, 3);
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
            this.lbl_Header.Location = new System.Drawing.Point(366, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(667, 69);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "UPDATE RETAILER ";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_Retailer_Info
            // 
            this.gb_Retailer_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Retailer_Info.Controls.Add(this.tableLayoutPanel1);
            this.gb_Retailer_Info.Controls.Add(this.tableLayoutPanel3);
            this.gb_Retailer_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Retailer_Info.Location = new System.Drawing.Point(7, 97);
            this.gb_Retailer_Info.Name = "gb_Retailer_Info";
            this.gb_Retailer_Info.Size = new System.Drawing.Size(1302, 360);
            this.gb_Retailer_Info.TabIndex = 11;
            this.gb_Retailer_Info.TabStop = false;
            this.gb_Retailer_Info.Text = "Retailer Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.564103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.82362F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.35043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.087801F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.08392F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.60373F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.408702F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Date, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Name, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_Date, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_M_No, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Mobile_No, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Alter_Number, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Alter_No, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_PAN_No, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_PAN_No, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Address, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Address, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Addhar_No, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_Addhar_No, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Note, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_Note, 5, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.01434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.35484F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.24014F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.03226F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1287, 244);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(670, 13);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(201, 32);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(321, 12);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(312, 34);
            this.txt_Name.TabIndex = 10;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(894, 10);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(341, 38);
            this.dtp_Date.TabIndex = 9;
            // 
            // txt_M_No
            // 
            this.txt_M_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_M_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_M_No.Location = new System.Drawing.Point(321, 64);
            this.txt_M_No.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_M_No.Name = "txt_M_No";
            this.txt_M_No.Size = new System.Drawing.Size(312, 34);
            this.txt_M_No.TabIndex = 11;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(36, 67);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(262, 29);
            this.lbl_Mobile_No.TabIndex = 3;
            this.lbl_Mobile_No.Text = "Mobile Number ";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(36, 14);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(262, 29);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Alter_Number
            // 
            this.lbl_Alter_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Alter_Number.AutoSize = true;
            this.lbl_Alter_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alter_Number.Location = new System.Drawing.Point(670, 67);
            this.lbl_Alter_Number.Name = "lbl_Alter_Number";
            this.lbl_Alter_Number.Size = new System.Drawing.Size(201, 29);
            this.lbl_Alter_Number.TabIndex = 6;
            this.lbl_Alter_Number.Text = "Alter Number";
            // 
            // txt_Alter_No
            // 
            this.txt_Alter_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Alter_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Alter_No.Location = new System.Drawing.Point(894, 64);
            this.txt_Alter_No.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Alter_No.Name = "txt_Alter_No";
            this.txt_Alter_No.Size = new System.Drawing.Size(341, 34);
            this.txt_Alter_No.TabIndex = 12;
            // 
            // lbl_PAN_No
            // 
            this.lbl_PAN_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PAN_No.AutoSize = true;
            this.lbl_PAN_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PAN_No.Location = new System.Drawing.Point(36, 123);
            this.lbl_PAN_No.Name = "lbl_PAN_No";
            this.lbl_PAN_No.Size = new System.Drawing.Size(262, 29);
            this.lbl_PAN_No.TabIndex = 4;
            this.lbl_PAN_No.Text = "PAN Number";
            // 
            // txt_PAN_No
            // 
            this.txt_PAN_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PAN_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PAN_No.Location = new System.Drawing.Point(321, 121);
            this.txt_PAN_No.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_PAN_No.Name = "txt_PAN_No";
            this.txt_PAN_No.Size = new System.Drawing.Size(312, 34);
            this.txt_PAN_No.TabIndex = 13;
            // 
            // lbl_Address
            // 
            this.lbl_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(670, 123);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(201, 29);
            this.lbl_Address.TabIndex = 7;
            this.lbl_Address.Text = "Address";
            // 
            // txt_Address
            // 
            this.txt_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(894, 114);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(341, 48);
            this.txt_Address.TabIndex = 15;
            // 
            // lbl_Addhar_No
            // 
            this.lbl_Addhar_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Addhar_No.AutoSize = true;
            this.lbl_Addhar_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Addhar_No.Location = new System.Drawing.Point(36, 193);
            this.lbl_Addhar_No.Name = "lbl_Addhar_No";
            this.lbl_Addhar_No.Size = new System.Drawing.Size(262, 29);
            this.lbl_Addhar_No.TabIndex = 5;
            this.lbl_Addhar_No.Text = "Addhar Card Number";
            // 
            // txt_Addhar_No
            // 
            this.txt_Addhar_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Addhar_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Addhar_No.Location = new System.Drawing.Point(321, 190);
            this.txt_Addhar_No.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Addhar_No.Name = "txt_Addhar_No";
            this.txt_Addhar_No.Size = new System.Drawing.Size(312, 34);
            this.txt_Addhar_No.TabIndex = 14;
            // 
            // lbl_Note
            // 
            this.lbl_Note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.Location = new System.Drawing.Point(670, 193);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(201, 29);
            this.lbl_Note.TabIndex = 16;
            this.lbl_Note.Text = "Note";
            // 
            // txt_Note
            // 
            this.txt_Note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Note.Location = new System.Drawing.Point(894, 183);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(341, 48);
            this.txt_Note.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.68596F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71843F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.63143F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_ID, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Search, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1287, 65);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(506, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 38);
            this.textBox1.TabIndex = 8;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(269, 16);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(214, 32);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Retailer ID";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(812, 3);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(233, 59);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // dgv_View_Data
            // 
            this.dgv_View_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_View_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Data.Location = new System.Drawing.Point(7, 463);
            this.dgv_View_Data.Name = "dgv_View_Data";
            this.dgv_View_Data.RowHeadersWidth = 51;
            this.dgv_View_Data.RowTemplate.Height = 24;
            this.dgv_View_Data.Size = new System.Drawing.Size(1298, 269);
            this.dgv_View_Data.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 734);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1317, 88);
            this.panel2.TabIndex = 13;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(820, 6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(241, 70);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(257, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(241, 72);
            this.btn_Refresh.TabIndex = 17;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Update.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(542, 7);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(241, 70);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // Frm_Update_Retailer_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 822);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_View_Data);
            this.Controls.Add(this.gb_Retailer_Info);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1335, 869);
            this.Name = "Frm_Update_Retailer_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Retailer Info";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.gb_Retailer_Info.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Data)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Retailer_Info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox txt_M_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Alter_Number;
        private System.Windows.Forms.TextBox txt_Alter_No;
        private System.Windows.Forms.Label lbl_PAN_No;
        private System.Windows.Forms.TextBox txt_PAN_No;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_Addhar_No;
        private System.Windows.Forms.TextBox txt_Addhar_No;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.DataGridView dgv_View_Data;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Search;
    }
}

namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    partial class Frm_Update_Distributors
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
            this.gb_Add_Distributor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_Distributor_ID = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Mob_No1 = new System.Windows.Forms.Label();
            this.txt_Mob_No1 = new System.Windows.Forms.TextBox();
            this.dtp_Tie_Up_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.txt_Mob_No2 = new System.Windows.Forms.TextBox();
            this.lbl_Mob_No_2 = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Email_ID = new System.Windows.Forms.TextBox();
            this.lbl_EmailID = new System.Windows.Forms.Label();
            this.lbl_Addhar_No = new System.Windows.Forms.Label();
            this.txt_Addhar_No = new System.Windows.Forms.TextBox();
            this.txt_PanNo = new System.Windows.Forms.TextBox();
            this.lbl_PAN_No = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.txt_Brand = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gb_Add_Distributor.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Add_Distributor
            // 
            this.gb_Add_Distributor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Add_Distributor.Controls.Add(this.tableLayoutPanel2);
            this.gb_Add_Distributor.Controls.Add(this.tableLayoutPanel1);
            this.gb_Add_Distributor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_Distributor.Location = new System.Drawing.Point(7, 91);
            this.gb_Add_Distributor.Name = "gb_Add_Distributor";
            this.gb_Add_Distributor.Size = new System.Drawing.Size(1302, 503);
            this.gb_Add_Distributor.TabIndex = 5;
            this.gb_Add_Distributor.TabStop = false;
            this.gb_Add_Distributor.Text = "Add Distributor";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_ID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_Distributor_ID, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Search, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1281, 61);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(259, 14);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(250, 32);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Distributor_ID
            // 
            this.txt_Distributor_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Distributor_ID.Enabled = false;
            this.txt_Distributor_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Distributor_ID.Location = new System.Drawing.Point(532, 11);
            this.txt_Distributor_ID.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Distributor_ID.Name = "txt_Distributor_ID";
            this.txt_Distributor_ID.Size = new System.Drawing.Size(216, 38);
            this.txt_Distributor_ID.TabIndex = 11;
            this.txt_Distributor_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Distributor_ID_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(775, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(241, 55);
            this.btn_Search.TabIndex = 19;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.195303F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.55526F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.09834F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.916924F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.04464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.83695F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.352589F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Name, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Mob_No1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Mob_No1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtp_Tie_Up_Date, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Date, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Mob_No2, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Mob_No_2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Address, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Address, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Email_ID, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_EmailID, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Addhar_No, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_Addhar_No, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_PanNo, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_PAN_No, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Brand, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Brand, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1281, 389);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(43, 24);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(206, 29);
            this.lbl_Name.TabIndex = 12;
            this.lbl_Name.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(272, 21);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(307, 34);
            this.txt_Name.TabIndex = 13;
            this.txt_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Name_KeyDown);
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            // 
            // lbl_Mob_No1
            // 
            this.lbl_Mob_No1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mob_No1.AutoSize = true;
            this.lbl_Mob_No1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No1.Location = new System.Drawing.Point(43, 101);
            this.lbl_Mob_No1.Name = "lbl_Mob_No1";
            this.lbl_Mob_No1.Size = new System.Drawing.Size(206, 29);
            this.lbl_Mob_No1.TabIndex = 14;
            this.lbl_Mob_No1.Text = "Mobile No. 1";
            // 
            // txt_Mob_No1
            // 
            this.txt_Mob_No1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Mob_No1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mob_No1.Location = new System.Drawing.Point(272, 98);
            this.txt_Mob_No1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Mob_No1.MaxLength = 10;
            this.txt_Mob_No1.Name = "txt_Mob_No1";
            this.txt_Mob_No1.Size = new System.Drawing.Size(307, 34);
            this.txt_Mob_No1.TabIndex = 19;
            this.txt_Mob_No1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Mob_No1_KeyDown);
            this.txt_Mob_No1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Mob_No1_KeyPress);
            // 
            // dtp_Tie_Up_Date
            // 
            this.dtp_Tie_Up_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Tie_Up_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Tie_Up_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Tie_Up_Date.Location = new System.Drawing.Point(925, 19);
            this.dtp_Tie_Up_Date.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.dtp_Tie_Up_Date.Name = "dtp_Tie_Up_Date";
            this.dtp_Tie_Up_Date.Size = new System.Drawing.Size(303, 38);
            this.dtp_Tie_Up_Date.TabIndex = 10;
            this.dtp_Tie_Up_Date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_Tie_Up_Date_KeyDown);
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(626, 22);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(276, 32);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Tie Up Date";
            // 
            // txt_Mob_No2
            // 
            this.txt_Mob_No2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Mob_No2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mob_No2.Location = new System.Drawing.Point(925, 98);
            this.txt_Mob_No2.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Mob_No2.MaxLength = 10;
            this.txt_Mob_No2.Name = "txt_Mob_No2";
            this.txt_Mob_No2.Size = new System.Drawing.Size(303, 34);
            this.txt_Mob_No2.TabIndex = 20;
            this.txt_Mob_No2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Mob_No2_KeyDown);
            this.txt_Mob_No2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Mob_No2_KeyPress);
            // 
            // lbl_Mob_No_2
            // 
            this.lbl_Mob_No_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mob_No_2.AutoSize = true;
            this.lbl_Mob_No_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No_2.Location = new System.Drawing.Point(626, 101);
            this.lbl_Mob_No_2.Name = "lbl_Mob_No_2";
            this.lbl_Mob_No_2.Size = new System.Drawing.Size(276, 29);
            this.lbl_Mob_No_2.TabIndex = 15;
            this.lbl_Mob_No_2.Text = "Mobile No. 2";
            // 
            // lbl_Address
            // 
            this.lbl_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(43, 178);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(206, 29);
            this.lbl_Address.TabIndex = 16;
            this.lbl_Address.Text = "Address";
            // 
            // txt_Address
            // 
            this.txt_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(272, 175);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(307, 34);
            this.txt_Address.TabIndex = 21;
            this.txt_Address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Address_KeyDown);
            // 
            // txt_Email_ID
            // 
            this.txt_Email_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Email_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email_ID.Location = new System.Drawing.Point(925, 175);
            this.txt_Email_ID.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Email_ID.Name = "txt_Email_ID";
            this.txt_Email_ID.Size = new System.Drawing.Size(303, 34);
            this.txt_Email_ID.TabIndex = 27;
            this.txt_Email_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Email_ID_KeyDown);
            // 
            // lbl_EmailID
            // 
            this.lbl_EmailID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EmailID.AutoSize = true;
            this.lbl_EmailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailID.Location = new System.Drawing.Point(626, 178);
            this.lbl_EmailID.Name = "lbl_EmailID";
            this.lbl_EmailID.Size = new System.Drawing.Size(276, 29);
            this.lbl_EmailID.TabIndex = 24;
            this.lbl_EmailID.Text = "Email ID";
            // 
            // lbl_Addhar_No
            // 
            this.lbl_Addhar_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Addhar_No.AutoSize = true;
            this.lbl_Addhar_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Addhar_No.Location = new System.Drawing.Point(43, 240);
            this.lbl_Addhar_No.Name = "lbl_Addhar_No";
            this.lbl_Addhar_No.Size = new System.Drawing.Size(206, 58);
            this.lbl_Addhar_No.TabIndex = 22;
            this.lbl_Addhar_No.Text = "Addhar Card Number";
            // 
            // txt_Addhar_No
            // 
            this.txt_Addhar_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Addhar_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Addhar_No.Location = new System.Drawing.Point(272, 252);
            this.txt_Addhar_No.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Addhar_No.MaxLength = 12;
            this.txt_Addhar_No.Name = "txt_Addhar_No";
            this.txt_Addhar_No.Size = new System.Drawing.Size(307, 34);
            this.txt_Addhar_No.TabIndex = 23;
            this.txt_Addhar_No.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Addhar_No_KeyDown);
            this.txt_Addhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Addhar_No_KeyPress);
            // 
            // txt_PanNo
            // 
            this.txt_PanNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PanNo.Location = new System.Drawing.Point(925, 252);
            this.txt_PanNo.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_PanNo.Name = "txt_PanNo";
            this.txt_PanNo.Size = new System.Drawing.Size(303, 34);
            this.txt_PanNo.TabIndex = 29;
            this.txt_PanNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PanNo_KeyDown);
            // 
            // lbl_PAN_No
            // 
            this.lbl_PAN_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PAN_No.AutoSize = true;
            this.lbl_PAN_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PAN_No.Location = new System.Drawing.Point(626, 255);
            this.lbl_PAN_No.Name = "lbl_PAN_No";
            this.lbl_PAN_No.Size = new System.Drawing.Size(276, 29);
            this.lbl_PAN_No.TabIndex = 28;
            this.lbl_PAN_No.Text = "PAN Card No.";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand.Location = new System.Drawing.Point(43, 334);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(206, 29);
            this.lbl_Brand.TabIndex = 25;
            this.lbl_Brand.Text = "Brand";
            // 
            // txt_Brand
            // 
            this.txt_Brand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Brand.Location = new System.Drawing.Point(272, 331);
            this.txt_Brand.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Brand.Name = "txt_Brand";
            this.txt_Brand.Size = new System.Drawing.Size(307, 34);
            this.txt_Brand.TabIndex = 26;
            this.txt_Brand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Brand_KeyDown);
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
            this.panel1.TabIndex = 7;
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
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Header.Location = new System.Drawing.Point(298, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(821, 69);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "UPDATE DISTRIBUTORS";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Location = new System.Drawing.Point(7, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 83);
            this.panel2.TabIndex = 5;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(839, 12);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(241, 68);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(247, 12);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(241, 68);
            this.btn_Refresh.TabIndex = 17;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(533, 12);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(241, 68);
            this.btn_Update.TabIndex = 16;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Frm_Update_Distributors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 743);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_Add_Distributor);
            this.MinimumSize = new System.Drawing.Size(1335, 761);
            this.Name = "Frm_Update_Distributors";
            this.Text = "Update Distributors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Update_Distributors_Load);
            this.gb_Add_Distributor.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Add_Distributor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_Distributor_ID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Mob_No1;
        private System.Windows.Forms.TextBox txt_Mob_No1;
        private System.Windows.Forms.Label lbl_Mob_No_2;
        private System.Windows.Forms.TextBox txt_Mob_No2;
        private System.Windows.Forms.TextBox txt_Email_ID;
        private System.Windows.Forms.Label lbl_EmailID;
        private System.Windows.Forms.Label lbl_PAN_No;
        private System.Windows.Forms.TextBox txt_PanNo;
        private System.Windows.Forms.DateTimePicker dtp_Tie_Up_Date;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Addhar_No;
        private System.Windows.Forms.TextBox txt_Brand;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Addhar_No;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Update;
    }
}

namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    partial class Frm_User_Managements
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
            this.tabControl_UserMgt = new System.Windows.Forms.TabControl();
            this.tabPage_Add_User = new System.Windows.Forms.TabPage();
            this.tabPage_Change_Password = new System.Windows.Forms.TabPage();
            this.tabPage_Delete_User = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Change_Password = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Delete_User = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_Confirm_Password = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.btn_Close_CP = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_New_Password = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txt_Current_Password = new System.Windows.Forms.TextBox();
            this.txt_CP_Username = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.btn_Close_Dlt = new System.Windows.Forms.Button();
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.tb_Admin_Password = new System.Windows.Forms.TextBox();
            this.txt_Delete_Username = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.tabControl_UserMgt.SuspendLayout();
            this.tabPage_Add_User.SuspendLayout();
            this.tabPage_Change_Password.SuspendLayout();
            this.tabPage_Delete_User.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1433, 91);
            this.panel1.TabIndex = 6;
            // 
            // pb_Exit
            // 
            this.pb_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Exit.Image = global::Lightup_LED_Bulb_Shoppee.Properties.Resources._77_771475_x_exit_button_icon_symbol_vector_illustration_hong;
            this.pb_Exit.Location = new System.Drawing.Point(1376, 3);
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
            this.lbl_Header.Location = new System.Drawing.Point(471, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(605, 69);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "User Management";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl_UserMgt
            // 
            this.tabControl_UserMgt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_UserMgt.Controls.Add(this.tabPage_Add_User);
            this.tabControl_UserMgt.Controls.Add(this.tabPage_Change_Password);
            this.tabControl_UserMgt.Controls.Add(this.tabPage_Delete_User);
            this.tabControl_UserMgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_UserMgt.Location = new System.Drawing.Point(0, 97);
            this.tabControl_UserMgt.Name = "tabControl_UserMgt";
            this.tabControl_UserMgt.SelectedIndex = 0;
            this.tabControl_UserMgt.Size = new System.Drawing.Size(1421, 649);
            this.tabControl_UserMgt.TabIndex = 7;
            // 
            // tabPage_Add_User
            // 
            this.tabPage_Add_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage_Add_User.Controls.Add(this.btn_Close);
            this.tabPage_Add_User.Controls.Add(this.btn_Submit);
            this.tabPage_Add_User.Controls.Add(this.txt_Confirm_Password);
            this.tabPage_Add_User.Controls.Add(this.Label7);
            this.tabPage_Add_User.Controls.Add(this.txt_Password);
            this.tabPage_Add_User.Controls.Add(this.txt_Username);
            this.tabPage_Add_User.Controls.Add(this.Label5);
            this.tabPage_Add_User.Controls.Add(this.Label6);
            this.tabPage_Add_User.Controls.Add(this.panel2);
            this.tabPage_Add_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Add_User.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Add_User.Name = "tabPage_Add_User";
            this.tabPage_Add_User.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Add_User.Size = new System.Drawing.Size(1413, 607);
            this.tabPage_Add_User.TabIndex = 0;
            this.tabPage_Add_User.Text = "Add New User";
            // 
            // tabPage_Change_Password
            // 
            this.tabPage_Change_Password.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage_Change_Password.Controls.Add(this.btn_Close_CP);
            this.tabPage_Change_Password.Controls.Add(this.btn_Update);
            this.tabPage_Change_Password.Controls.Add(this.txt_New_Password);
            this.tabPage_Change_Password.Controls.Add(this.Label10);
            this.tabPage_Change_Password.Controls.Add(this.txt_Current_Password);
            this.tabPage_Change_Password.Controls.Add(this.txt_CP_Username);
            this.tabPage_Change_Password.Controls.Add(this.Label8);
            this.tabPage_Change_Password.Controls.Add(this.Label9);
            this.tabPage_Change_Password.Controls.Add(this.panel3);
            this.tabPage_Change_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Change_Password.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Change_Password.Name = "tabPage_Change_Password";
            this.tabPage_Change_Password.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Change_Password.Size = new System.Drawing.Size(1413, 607);
            this.tabPage_Change_Password.TabIndex = 1;
            this.tabPage_Change_Password.Text = "Change Password";
            // 
            // tabPage_Delete_User
            // 
            this.tabPage_Delete_User.BackColor = System.Drawing.Color.LightGray;
            this.tabPage_Delete_User.Controls.Add(this.btn_Close_Dlt);
            this.tabPage_Delete_User.Controls.Add(this.btn_Delete_User);
            this.tabPage_Delete_User.Controls.Add(this.tb_Admin_Password);
            this.tabPage_Delete_User.Controls.Add(this.txt_Delete_Username);
            this.tabPage_Delete_User.Controls.Add(this.Label11);
            this.tabPage_Delete_User.Controls.Add(this.Label12);
            this.tabPage_Delete_User.Controls.Add(this.panel4);
            this.tabPage_Delete_User.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Delete_User.Name = "tabPage_Delete_User";
            this.tabPage_Delete_User.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Delete_User.Size = new System.Drawing.Size(1413, 607);
            this.tabPage_Delete_User.TabIndex = 2;
            this.tabPage_Delete_User.Text = "Delete User";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1407, 91);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(507, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.lbl_Change_Password);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1407, 91);
            this.panel3.TabIndex = 7;
            // 
            // lbl_Change_Password
            // 
            this.lbl_Change_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Change_Password.AutoSize = true;
            this.lbl_Change_Password.BackColor = System.Drawing.Color.Silver;
            this.lbl_Change_Password.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Change_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Change_Password.Location = new System.Drawing.Point(458, 9);
            this.lbl_Change_Password.Name = "lbl_Change_Password";
            this.lbl_Change_Password.Size = new System.Drawing.Size(592, 69);
            this.lbl_Change_Password.TabIndex = 0;
            this.lbl_Change_Password.Text = "Change Password";
            this.lbl_Change_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.lbl_Delete_User);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1407, 91);
            this.panel4.TabIndex = 7;
            // 
            // lbl_Delete_User
            // 
            this.lbl_Delete_User.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Delete_User.AutoSize = true;
            this.lbl_Delete_User.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Delete_User.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_User.ForeColor = System.Drawing.Color.Black;
            this.lbl_Delete_User.Location = new System.Drawing.Point(561, 11);
            this.lbl_Delete_User.Name = "lbl_Delete_User";
            this.lbl_Delete_User.Size = new System.Drawing.Size(386, 69);
            this.lbl_Delete_User.TabIndex = 0;
            this.lbl_Delete_User.Text = "Delete User";
            this.lbl_Delete_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.Location = new System.Drawing.Point(728, 503);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(208, 66);
            this.btn_Close.TabIndex = 35;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Submit.BackColor = System.Drawing.Color.White;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(363, 503);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(206, 66);
            this.btn_Submit.TabIndex = 34;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            // 
            // txt_Confirm_Password
            // 
            this.txt_Confirm_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Confirm_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Confirm_Password.Location = new System.Drawing.Point(728, 368);
            this.txt_Confirm_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Confirm_Password.MaxLength = 8;
            this.txt_Confirm_Password.Name = "txt_Confirm_Password";
            this.txt_Confirm_Password.Size = new System.Drawing.Size(344, 38);
            this.txt_Confirm_Password.TabIndex = 33;
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(277, 369);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(261, 32);
            this.Label7.TabIndex = 38;
            this.Label7.Text = "Confirm Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(728, 256);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.MaxLength = 8;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(344, 38);
            this.txt_Password.TabIndex = 32;
            // 
            // txt_Username
            // 
            this.txt_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(728, 158);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.MaxLength = 8;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(344, 38);
            this.txt_Username.TabIndex = 31;
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(277, 158);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(153, 32);
            this.Label5.TabIndex = 37;
            this.Label5.Text = "Username";
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(277, 257);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(228, 32);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "Enter Password";
            // 
            // btn_Close_CP
            // 
            this.btn_Close_CP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Close_CP.BackColor = System.Drawing.Color.White;
            this.btn_Close_CP.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close_CP.ForeColor = System.Drawing.Color.Black;
            this.btn_Close_CP.Location = new System.Drawing.Point(796, 501);
            this.btn_Close_CP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close_CP.Name = "btn_Close_CP";
            this.btn_Close_CP.Size = new System.Drawing.Size(204, 69);
            this.btn_Close_CP.TabIndex = 54;
            this.btn_Close_CP.Text = "Close";
            this.btn_Close_CP.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(280, 501);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(383, 69);
            this.btn_Update.TabIndex = 53;
            this.btn_Update.Text = "Update Password";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // txt_New_Password
            // 
            this.txt_New_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_New_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_New_Password.Location = new System.Drawing.Point(813, 385);
            this.txt_New_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_New_Password.MaxLength = 8;
            this.txt_New_Password.Name = "txt_New_Password";
            this.txt_New_Password.PasswordChar = '*';
            this.txt_New_Password.Size = new System.Drawing.Size(351, 38);
            this.txt_New_Password.TabIndex = 52;
            // 
            // Label10
            // 
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(283, 385);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(214, 32);
            this.Label10.TabIndex = 57;
            this.Label10.Text = "New Password";
            // 
            // txt_Current_Password
            // 
            this.txt_Current_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Current_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Current_Password.Location = new System.Drawing.Point(813, 271);
            this.txt_Current_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Current_Password.MaxLength = 8;
            this.txt_Current_Password.Name = "txt_Current_Password";
            this.txt_Current_Password.PasswordChar = '*';
            this.txt_Current_Password.Size = new System.Drawing.Size(351, 38);
            this.txt_Current_Password.TabIndex = 51;
            // 
            // txt_CP_Username
            // 
            this.txt_CP_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CP_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CP_Username.Location = new System.Drawing.Point(813, 166);
            this.txt_CP_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CP_Username.MaxLength = 8;
            this.txt_CP_Username.Name = "txt_CP_Username";
            this.txt_CP_Username.Size = new System.Drawing.Size(351, 38);
            this.txt_CP_Username.TabIndex = 50;
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(283, 172);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(153, 32);
            this.Label8.TabIndex = 56;
            this.Label8.Text = "Username";
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(283, 277);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(256, 32);
            this.Label9.TabIndex = 55;
            this.Label9.Text = "Current Password";
            // 
            // btn_Close_Dlt
            // 
            this.btn_Close_Dlt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Close_Dlt.BackColor = System.Drawing.Color.White;
            this.btn_Close_Dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close_Dlt.ForeColor = System.Drawing.Color.Black;
            this.btn_Close_Dlt.Location = new System.Drawing.Point(838, 483);
            this.btn_Close_Dlt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close_Dlt.Name = "btn_Close_Dlt";
            this.btn_Close_Dlt.Size = new System.Drawing.Size(191, 62);
            this.btn_Close_Dlt.TabIndex = 65;
            this.btn_Close_Dlt.Text = "Close";
            this.btn_Close_Dlt.UseVisualStyleBackColor = false;
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete_User.BackColor = System.Drawing.Color.White;
            this.btn_Delete_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_User.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete_User.Location = new System.Drawing.Point(309, 483);
            this.btn_Delete_User.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(323, 62);
            this.btn_Delete_User.TabIndex = 64;
            this.btn_Delete_User.Text = "Delete User";
            this.btn_Delete_User.UseVisualStyleBackColor = false;
            // 
            // tb_Admin_Password
            // 
            this.tb_Admin_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Admin_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Admin_Password.Location = new System.Drawing.Point(815, 320);
            this.tb_Admin_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Admin_Password.MaxLength = 8;
            this.tb_Admin_Password.Name = "tb_Admin_Password";
            this.tb_Admin_Password.PasswordChar = '*';
            this.tb_Admin_Password.Size = new System.Drawing.Size(295, 38);
            this.tb_Admin_Password.TabIndex = 61;
            // 
            // txt_Delete_Username
            // 
            this.txt_Delete_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Delete_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Delete_Username.Location = new System.Drawing.Point(815, 172);
            this.txt_Delete_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Delete_Username.MaxLength = 8;
            this.txt_Delete_Username.Name = "txt_Delete_Username";
            this.txt_Delete_Username.Size = new System.Drawing.Size(295, 38);
            this.txt_Delete_Username.TabIndex = 60;
            // 
            // Label11
            // 
            this.Label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.White;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(303, 174);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(158, 36);
            this.Label11.TabIndex = 63;
            this.Label11.Text = "Username";
            // 
            // Label12
            // 
            this.Label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.White;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(303, 322);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(339, 36);
            this.Label12.TabIndex = 62;
            this.Label12.Text = "Enter Admin Password";
            // 
            // Frm_User_Managements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 750);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl_UserMgt);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_User_Managements";
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.tabControl_UserMgt.ResumeLayout(false);
            this.tabPage_Add_User.ResumeLayout(false);
            this.tabPage_Add_User.PerformLayout();
            this.tabPage_Change_Password.ResumeLayout(false);
            this.tabPage_Change_Password.PerformLayout();
            this.tabPage_Delete_User.ResumeLayout(false);
            this.tabPage_Delete_User.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TabControl tabControl_UserMgt;
        private System.Windows.Forms.TabPage tabPage_Add_User;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_Confirm_Password;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_Change_Password;
        private System.Windows.Forms.Button btn_Close_CP;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_New_Password;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TextBox txt_Current_Password;
        private System.Windows.Forms.TextBox txt_CP_Username;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Change_Password;
        private System.Windows.Forms.TabPage tabPage_Delete_User;
        private System.Windows.Forms.Button btn_Close_Dlt;
        private System.Windows.Forms.Button btn_Delete_User;
        private System.Windows.Forms.TextBox tb_Admin_Password;
        private System.Windows.Forms.TextBox txt_Delete_Username;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_Delete_User;
    }
}
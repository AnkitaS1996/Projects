
namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    partial class Frm_Add_Category
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
            this.gb_Info = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.txt_Product_Name = new System.Windows.Forms.TextBox();
            this.txt_PID = new System.Windows.Forms.TextBox();
            this.lbl_PID = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_PName = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.gb_Info.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
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
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Header.Location = new System.Drawing.Point(586, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(551, 69);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "ADD CATEGORY";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_Info
            // 
            this.gb_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Info.BackColor = System.Drawing.Color.Silver;
            this.gb_Info.Controls.Add(this.tableLayoutPanel1);
            this.gb_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Info.Location = new System.Drawing.Point(12, 97);
            this.gb_Info.Name = "gb_Info";
            this.gb_Info.Size = new System.Drawing.Size(1638, 154);
            this.gb_Info.TabIndex = 13;
            this.gb_Info.TabStop = false;
            this.gb_Info.Text = "Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.11804F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.06701F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.76316F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.18421F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Controls.Add(this.txt_Category, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Product_Name, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_PID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_PID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Save, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_PName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Category, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.40625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.59375F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1620, 118);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txt_Category
            // 
            this.txt_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Category.Location = new System.Drawing.Point(381, 64);
            this.txt_Category.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(481, 38);
            this.txt_Category.TabIndex = 11;
            // 
            // txt_Product_Name
            // 
            this.txt_Product_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Product_Name.Location = new System.Drawing.Point(902, 64);
            this.txt_Product_Name.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Product_Name.Name = "txt_Product_Name";
            this.txt_Product_Name.Size = new System.Drawing.Size(460, 38);
            this.txt_Product_Name.TabIndex = 9;
            // 
            // txt_PID
            // 
            this.txt_PID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PID.Location = new System.Drawing.Point(93, 64);
            this.txt_PID.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.txt_PID.Name = "txt_PID";
            this.txt_PID.Size = new System.Drawing.Size(218, 38);
            this.txt_PID.TabIndex = 6;
            // 
            // lbl_PID
            // 
            this.lbl_PID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PID.Location = new System.Drawing.Point(46, 6);
            this.lbl_PID.Name = "lbl_PID";
            this.lbl_PID.Size = new System.Drawing.Size(312, 36);
            this.lbl_PID.TabIndex = 5;
            this.lbl_PID.Text = "Product ID";
            this.lbl_PID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Save.Location = new System.Drawing.Point(1402, 54);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(139, 57);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_PName
            // 
            this.lbl_PName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PName.Location = new System.Drawing.Point(364, 6);
            this.lbl_PName.Name = "lbl_PName";
            this.lbl_PName.Size = new System.Drawing.Size(515, 36);
            this.lbl_PName.TabIndex = 10;
            this.lbl_PName.Text = "Category";
            this.lbl_PName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Category
            // 
            this.lbl_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(885, 6);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(494, 36);
            this.lbl_Category.TabIndex = 8;
            this.lbl_Category.Text = "Product Name";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_Data
            // 
            this.dgv_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Data.Location = new System.Drawing.Point(12, 257);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.RowTemplate.Height = 24;
            this.dgv_Data.Size = new System.Drawing.Size(1638, 631);
            this.dgv_Data.TabIndex = 17;
            // 
            // Frm_Add_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 948);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.gb_Info);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1680, 995);
            this.Name = "Frm_Add_Category";
            this.Text = "Add Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Add_Category_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.gb_Info.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.TextBox txt_Product_Name;
        private System.Windows.Forms.TextBox txt_PID;
        private System.Windows.Forms.Label lbl_PID;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_PName;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.DataGridView dgv_Data;
    }
}
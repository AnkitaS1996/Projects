﻿
namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    partial class Frm_View_Customer_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Exits = new System.Windows.Forms.PictureBox();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_View_Product = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_View_CustomerBY = new System.Windows.Forms.Label();
            this.cmb_SearchBy = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.DGV_View_Customer_Data = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.gb_View_Product.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_View_Customer_Data)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1545, 91);
            this.panel1.TabIndex = 17;
            // 
            // pb_Exits
            // 
            this.pb_Exits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Exits.Image = global::Lightup_LED_Bulb_Shoppee.Properties.Resources._77_771475_x_exit_button_icon_symbol_vector_illustration_hong;
            this.pb_Exits.Location = new System.Drawing.Point(1488, 0);
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
            this.pb_Exit.Location = new System.Drawing.Point(1992, 3);
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
            this.lbl_Header.Location = new System.Drawing.Point(502, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(742, 69);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "View Customer Details";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_View_Product
            // 
            this.gb_View_Product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_View_Product.Controls.Add(this.tableLayoutPanel2);
            this.gb_View_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_View_Product.Location = new System.Drawing.Point(12, 107);
            this.gb_View_Product.Name = "gb_View_Product";
            this.gb_View_Product.Size = new System.Drawing.Size(1521, 130);
            this.gb_View_Product.TabIndex = 23;
            this.gb_View_Product.TabStop = false;
            this.gb_View_Product.Text = "View Product";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.436919F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.13147F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.50598F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.917663F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.7676F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.27224F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.901726F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_View_CustomerBY, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmb_SearchBy, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_Search, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Refresh, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1506, 81);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lbl_View_CustomerBY
            // 
            this.lbl_View_CustomerBY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_View_CustomerBY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_CustomerBY.Location = new System.Drawing.Point(115, 22);
            this.lbl_View_CustomerBY.Name = "lbl_View_CustomerBY";
            this.lbl_View_CustomerBY.Size = new System.Drawing.Size(252, 36);
            this.lbl_View_CustomerBY.TabIndex = 16;
            this.lbl_View_CustomerBY.Text = "View Customer By";
            this.lbl_View_CustomerBY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmb_SearchBy
            // 
            this.cmb_SearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_SearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SearchBy.FormattingEnabled = true;
            this.cmb_SearchBy.Items.AddRange(new object[] {
            "Customer ID",
            "Customer Name"});
            this.cmb_SearchBy.Location = new System.Drawing.Point(390, 20);
            this.cmb_SearchBy.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.cmb_SearchBy.Name = "cmb_SearchBy";
            this.cmb_SearchBy.Size = new System.Drawing.Size(314, 39);
            this.cmb_SearchBy.TabIndex = 18;
            this.cmb_SearchBy.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchBy_SelectedIndexChanged);
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(803, 21);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(333, 38);
            this.txt_Search.TabIndex = 17;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Refresh.Location = new System.Drawing.Point(1176, 12);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(190, 57);
            this.btn_Refresh.TabIndex = 20;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // DGV_View_Customer_Data
            // 
            this.DGV_View_Customer_Data.AllowUserToAddRows = false;
            this.DGV_View_Customer_Data.AllowUserToDeleteRows = false;
            this.DGV_View_Customer_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_View_Customer_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_View_Customer_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DGV_View_Customer_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_View_Customer_Data.DefaultCellStyle = dataGridViewCellStyle16;
            this.DGV_View_Customer_Data.Location = new System.Drawing.Point(12, 243);
            this.DGV_View_Customer_Data.Name = "DGV_View_Customer_Data";
            this.DGV_View_Customer_Data.RowHeadersWidth = 51;
            this.DGV_View_Customer_Data.RowTemplate.Height = 24;
            this.DGV_View_Customer_Data.Size = new System.Drawing.Size(1521, 540);
            this.DGV_View_Customer_Data.TabIndex = 24;
            // 
            // Frm_View_Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 811);
            this.Controls.Add(this.DGV_View_Customer_Data);
            this.Controls.Add(this.gb_View_Product);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1563, 858);
            this.Name = "Frm_View_Customer_Details";
            this.Text = "View Customer Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_View_Customer_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.gb_View_Product.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_View_Customer_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Exits;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_View_Product;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_View_CustomerBY;
        private System.Windows.Forms.ComboBox cmb_SearchBy;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView DGV_View_Customer_Data;
    }
}
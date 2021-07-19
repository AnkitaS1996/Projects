
namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    partial class Frm_View_Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.DGV_View_Product_Data = new System.Windows.Forms.DataGridView();
            this.gb_View_Product = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_SearchBy = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_View_ProductBy = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_View_Product_Data)).BeginInit();
            this.gb_View_Product.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.panel1.TabIndex = 20;
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
            this.lbl_Header.Location = new System.Drawing.Point(569, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(552, 69);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "VIEW PRODUCT";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGV_View_Product_Data
            // 
            this.DGV_View_Product_Data.AllowUserToAddRows = false;
            this.DGV_View_Product_Data.AllowUserToDeleteRows = false;
            this.DGV_View_Product_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_View_Product_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_View_Product_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_View_Product_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_View_Product_Data.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_View_Product_Data.Location = new System.Drawing.Point(12, 248);
            this.DGV_View_Product_Data.Name = "DGV_View_Product_Data";
            this.DGV_View_Product_Data.RowHeadersWidth = 51;
            this.DGV_View_Product_Data.RowTemplate.Height = 24;
            this.DGV_View_Product_Data.Size = new System.Drawing.Size(1638, 667);
            this.DGV_View_Product_Data.TabIndex = 21;
            // 
            // gb_View_Product
            // 
            this.gb_View_Product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_View_Product.Controls.Add(this.tableLayoutPanel2);
            this.gb_View_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_View_Product.Location = new System.Drawing.Point(12, 112);
            this.gb_View_Product.Name = "gb_View_Product";
            this.gb_View_Product.Size = new System.Drawing.Size(1638, 130);
            this.gb_View_Product.TabIndex = 22;
            this.gb_View_Product.TabStop = false;
            this.gb_View_Product.Text = "View Product";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.919902F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.18115F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.91559F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.232286F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0154F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.65003F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.02403F));
            this.tableLayoutPanel2.Controls.Add(this.cmb_SearchBy, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_Search, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Refresh, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_View_ProductBy, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1623, 81);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // cmb_SearchBy
            // 
            this.cmb_SearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_SearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SearchBy.FormattingEnabled = true;
            this.cmb_SearchBy.Items.AddRange(new object[] {
            "Product ID",
            "Category",
            "Product Name"});
            this.cmb_SearchBy.Location = new System.Drawing.Point(541, 20);
            this.cmb_SearchBy.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.cmb_SearchBy.Name = "cmb_SearchBy";
            this.cmb_SearchBy.Size = new System.Drawing.Size(267, 39);
            this.cmb_SearchBy.TabIndex = 18;
            this.cmb_SearchBy.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchBy_SelectedIndexChanged);
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(868, 21);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(366, 38);
            this.txt_Search.TabIndex = 17;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Refresh.Location = new System.Drawing.Point(1274, 12);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(214, 57);
            this.btn_Refresh.TabIndex = 20;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_View_ProductBy
            // 
            this.lbl_View_ProductBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_View_ProductBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_ProductBy.Location = new System.Drawing.Point(164, 22);
            this.lbl_View_ProductBy.Name = "lbl_View_ProductBy";
            this.lbl_View_ProductBy.Size = new System.Drawing.Size(354, 36);
            this.lbl_View_ProductBy.TabIndex = 16;
            this.lbl_View_ProductBy.Text = "View Product By";
            this.lbl_View_ProductBy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_View_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 977);
            this.ControlBox = false;
            this.Controls.Add(this.gb_View_Product);
            this.Controls.Add(this.DGV_View_Product_Data);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1680, 995);
            this.Name = "Frm_View_Product";
            this.Text = "View Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_View_Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_View_Product_Data)).EndInit();
            this.gb_View_Product.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView DGV_View_Product_Data;
        private System.Windows.Forms.GroupBox gb_View_Product;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_View_ProductBy;
        private System.Windows.Forms.ComboBox cmb_SearchBy;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Refresh;
    }
}
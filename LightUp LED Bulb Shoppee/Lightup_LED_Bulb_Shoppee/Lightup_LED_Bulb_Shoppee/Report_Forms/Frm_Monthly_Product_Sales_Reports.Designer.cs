
namespace Lightup_LED_Bulb_Shoppee.Report_Forms
{
    partial class Frm_Monthly_Product_Sales_Reports
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
            this.Monthly_Product_Sales_Report = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.lbl_Monthly_Product_Sales_Report = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.Monthly_Product_Sales_Report);
            this.panel1.Controls.Add(this.pb_Exit);
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 91);
            this.panel1.TabIndex = 7;
            // 
            // Monthly_Product_Sales_Report
            // 
            this.Monthly_Product_Sales_Report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Monthly_Product_Sales_Report.AutoSize = true;
            this.Monthly_Product_Sales_Report.BackColor = System.Drawing.Color.White;
            this.Monthly_Product_Sales_Report.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monthly_Product_Sales_Report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Monthly_Product_Sales_Report.Location = new System.Drawing.Point(260, 9);
            this.Monthly_Product_Sales_Report.Name = "Monthly_Product_Sales_Report";
            this.Monthly_Product_Sales_Report.Size = new System.Drawing.Size(973, 69);
            this.Monthly_Product_Sales_Report.TabIndex = 2;
            this.Monthly_Product_Sales_Report.Text = "Monthly Product Sales Report";
            this.Monthly_Product_Sales_Report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Header
            // 
            this.lbl_Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Header.Location = new System.Drawing.Point(497, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(0, 69);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Controls.Add(this.cmb_Month);
            this.panel2.Controls.Add(this.lbl_Monthly_Product_Sales_Report);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1484, 100);
            this.panel2.TabIndex = 8;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Refresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Refresh.Location = new System.Drawing.Point(932, 21);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(173, 52);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cmb_Month
            // 
            this.cmb_Month.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Month.FormattingEnabled = true;
            this.cmb_Month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "Octomber",
            "November",
            "December",
            ""});
            this.cmb_Month.Location = new System.Drawing.Point(683, 32);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(214, 33);
            this.cmb_Month.TabIndex = 1;
            this.cmb_Month.SelectedIndexChanged += new System.EventHandler(this.cmb_Month_SelectedIndexChanged);
            // 
            // lbl_Monthly_Product_Sales_Report
            // 
            this.lbl_Monthly_Product_Sales_Report.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Monthly_Product_Sales_Report.AutoSize = true;
            this.lbl_Monthly_Product_Sales_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Monthly_Product_Sales_Report.Location = new System.Drawing.Point(239, 32);
            this.lbl_Monthly_Product_Sales_Report.Name = "lbl_Monthly_Product_Sales_Report";
            this.lbl_Monthly_Product_Sales_Report.Size = new System.Drawing.Size(424, 32);
            this.lbl_Monthly_Product_Sales_Report.TabIndex = 0;
            this.lbl_Monthly_Product_Sales_Report.Text = "Search Monthly Product Sales";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 191);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1484, 585);
            this.reportViewer1.TabIndex = 9;
            // 
            // pb_Exit
            // 
            this.pb_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Exit.Image = global::Lightup_LED_Bulb_Shoppee.Properties.Resources._77_771475_x_exit_button_icon_symbol_vector_illustration_hong;
            this.pb_Exit.Location = new System.Drawing.Point(1427, 3);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(54, 45);
            this.pb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Exit.TabIndex = 1;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.pb_Exit_Click);
            // 
            // Frm_Monthly_Product_Sales_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 776);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Monthly_Product_Sales_Reports";
            this.Text = "Monthly Product Sales Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Monthly_Product_Sales_Report;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Month;
        private System.Windows.Forms.Label lbl_Monthly_Product_Sales_Report;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
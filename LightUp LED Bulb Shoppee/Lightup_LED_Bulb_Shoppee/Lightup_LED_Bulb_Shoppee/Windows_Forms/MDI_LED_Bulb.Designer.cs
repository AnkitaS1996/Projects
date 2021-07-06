
namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    partial class MDI_LED_Bulb
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_LED_Bulb));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distributorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDistributorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDistributorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDistributorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRetailerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRetailerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRetailerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNormalCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retailerOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pb_Logout = new System.Windows.Forms.PictureBox();
            this.lbl_Logged_In_Uname = new System.Windows.Forms.Label();
            this.viewCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.productToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.distributorsToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.reportsToolStripMenuItem1,
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1729, 40);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryToolStripMenuItem,
            this.updateCategoryToolStripMenuItem,
            this.viewCategoryToolStripMenuItem});
            this.categoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.addCategoryToolStripMenuItem.Text = "Add Category";
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // updateCategoryToolStripMenuItem
            // 
            this.updateCategoryToolStripMenuItem.Name = "updateCategoryToolStripMenuItem";
            this.updateCategoryToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.updateCategoryToolStripMenuItem.Text = "Update Category";
            this.updateCategoryToolStripMenuItem.Click += new System.EventHandler(this.updateCategoryToolStripMenuItem_Click);
            // 
            // viewCategoryToolStripMenuItem
            // 
            this.viewCategoryToolStripMenuItem.Name = "viewCategoryToolStripMenuItem";
            this.viewCategoryToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.viewCategoryToolStripMenuItem.Text = "View Category";
            this.viewCategoryToolStripMenuItem.Click += new System.EventHandler(this.viewCategoryToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.updateProductToolStripMenuItem,
            this.viewProductToolStripMenuItem});
            this.productToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(132, 36);
            this.productToolStripMenuItem.Text = " Product";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(294, 36);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // updateProductToolStripMenuItem
            // 
            this.updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            this.updateProductToolStripMenuItem.Size = new System.Drawing.Size(294, 36);
            this.updateProductToolStripMenuItem.Text = "Update Product";
            this.updateProductToolStripMenuItem.Click += new System.EventHandler(this.updateProductToolStripMenuItem_Click);
            // 
            // viewProductToolStripMenuItem
            // 
            this.viewProductToolStripMenuItem.Name = "viewProductToolStripMenuItem";
            this.viewProductToolStripMenuItem.Size = new System.Drawing.Size(294, 36);
            this.viewProductToolStripMenuItem.Text = "View Product";
            this.viewProductToolStripMenuItem.Click += new System.EventHandler(this.viewProductToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStockToolStripMenuItem,
            this.viewStockToolStripMenuItem});
            this.stockToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(95, 36);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // addStockToolStripMenuItem
            // 
            this.addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            this.addStockToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.addStockToolStripMenuItem.Text = "Add Stock";
            this.addStockToolStripMenuItem.Click += new System.EventHandler(this.addStockToolStripMenuItem_Click);
            // 
            // viewStockToolStripMenuItem
            // 
            this.viewStockToolStripMenuItem.Name = "viewStockToolStripMenuItem";
            this.viewStockToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.viewStockToolStripMenuItem.Text = "View Stock";
            this.viewStockToolStripMenuItem.Click += new System.EventHandler(this.viewStockToolStripMenuItem_Click);
            // 
            // distributorsToolStripMenuItem
            // 
            this.distributorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDistributorsToolStripMenuItem,
            this.updateDistributorsToolStripMenuItem,
            this.viewDistributorsToolStripMenuItem});
            this.distributorsToolStripMenuItem.Name = "distributorsToolStripMenuItem";
            this.distributorsToolStripMenuItem.Size = new System.Drawing.Size(175, 36);
            this.distributorsToolStripMenuItem.Text = "Distributors";
            // 
            // addDistributorsToolStripMenuItem
            // 
            this.addDistributorsToolStripMenuItem.Name = "addDistributorsToolStripMenuItem";
            this.addDistributorsToolStripMenuItem.Size = new System.Drawing.Size(344, 36);
            this.addDistributorsToolStripMenuItem.Text = "Add Distributors";
            this.addDistributorsToolStripMenuItem.Click += new System.EventHandler(this.addDistributorsToolStripMenuItem_Click);
            // 
            // updateDistributorsToolStripMenuItem
            // 
            this.updateDistributorsToolStripMenuItem.Name = "updateDistributorsToolStripMenuItem";
            this.updateDistributorsToolStripMenuItem.Size = new System.Drawing.Size(344, 36);
            this.updateDistributorsToolStripMenuItem.Text = "Update Distributors";
            this.updateDistributorsToolStripMenuItem.Click += new System.EventHandler(this.updateDistributorsToolStripMenuItem_Click);
            // 
            // viewDistributorsToolStripMenuItem
            // 
            this.viewDistributorsToolStripMenuItem.Name = "viewDistributorsToolStripMenuItem";
            this.viewDistributorsToolStripMenuItem.Size = new System.Drawing.Size(344, 36);
            this.viewDistributorsToolStripMenuItem.Text = "View Distributors";
            this.viewDistributorsToolStripMenuItem.Click += new System.EventHandler(this.viewDistributorsToolStripMenuItem_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRetailerToolStripMenuItem,
            this.updateRetailerToolStripMenuItem,
            this.viewRetailerToolStripMenuItem});
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(135, 36);
            this.billingToolStripMenuItem.Text = "Retailers";
            // 
            // addRetailerToolStripMenuItem
            // 
            this.addRetailerToolStripMenuItem.Name = "addRetailerToolStripMenuItem";
            this.addRetailerToolStripMenuItem.Size = new System.Drawing.Size(293, 36);
            this.addRetailerToolStripMenuItem.Text = "Add Retailer";
            this.addRetailerToolStripMenuItem.Click += new System.EventHandler(this.addRetailerToolStripMenuItem_Click);
            // 
            // updateRetailerToolStripMenuItem
            // 
            this.updateRetailerToolStripMenuItem.Name = "updateRetailerToolStripMenuItem";
            this.updateRetailerToolStripMenuItem.Size = new System.Drawing.Size(293, 36);
            this.updateRetailerToolStripMenuItem.Text = "Update Retailer";
            this.updateRetailerToolStripMenuItem.Click += new System.EventHandler(this.updateRetailerToolStripMenuItem_Click);
            // 
            // viewRetailerToolStripMenuItem
            // 
            this.viewRetailerToolStripMenuItem.Name = "viewRetailerToolStripMenuItem";
            this.viewRetailerToolStripMenuItem.Size = new System.Drawing.Size(293, 36);
            this.viewRetailerToolStripMenuItem.Text = "View Retailer";
            this.viewRetailerToolStripMenuItem.Click += new System.EventHandler(this.viewRetailerToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNormalCustomerToolStripMenuItem,
            this.viewCustomerDetailsToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(145, 36);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addNormalCustomerToolStripMenuItem
            // 
            this.addNormalCustomerToolStripMenuItem.Name = "addNormalCustomerToolStripMenuItem";
            this.addNormalCustomerToolStripMenuItem.Size = new System.Drawing.Size(376, 36);
            this.addNormalCustomerToolStripMenuItem.Text = "Add Normal Customer";
            this.addNormalCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNormalCustomerToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retailerOrderToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // retailerOrderToolStripMenuItem
            // 
            this.retailerOrderToolStripMenuItem.Name = "retailerOrderToolStripMenuItem";
            this.retailerOrderToolStripMenuItem.Size = new System.Drawing.Size(279, 36);
            this.retailerOrderToolStripMenuItem.Text = "Retailer Order";
            this.retailerOrderToolStripMenuItem.Click += new System.EventHandler(this.retailerOrderToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.usersToolStripMenuItem.Text = "Billing";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(95, 36);
            this.reportsToolStripMenuItem.Text = "Users";
            // 
            // reportsToolStripMenuItem1
            // 
            this.reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            this.reportsToolStripMenuItem1.Size = new System.Drawing.Size(123, 36);
            this.reportsToolStripMenuItem1.Text = "Reports";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.notepadToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(231, 36);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(231, 36);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // pb_Logout
            // 
            this.pb_Logout.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logout.Image")));
            this.pb_Logout.Location = new System.Drawing.Point(1646, -3);
            this.pb_Logout.Name = "pb_Logout";
            this.pb_Logout.Size = new System.Drawing.Size(83, 40);
            this.pb_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logout.TabIndex = 2;
            this.pb_Logout.TabStop = false;
            this.pb_Logout.Click += new System.EventHandler(this.pb_Logout_Click);
            // 
            // lbl_Logged_In_Uname
            // 
            this.lbl_Logged_In_Uname.AutoSize = true;
            this.lbl_Logged_In_Uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_In_Uname.Location = new System.Drawing.Point(1421, 9);
            this.lbl_Logged_In_Uname.Name = "lbl_Logged_In_Uname";
            this.lbl_Logged_In_Uname.Size = new System.Drawing.Size(219, 29);
            this.lbl_Logged_In_Uname.TabIndex = 4;
            this.lbl_Logged_In_Uname.Text = "Logged In Uname";
            // 
            // viewCustomerDetailsToolStripMenuItem
            // 
            this.viewCustomerDetailsToolStripMenuItem.Name = "viewCustomerDetailsToolStripMenuItem";
            this.viewCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(376, 36);
            this.viewCustomerDetailsToolStripMenuItem.Text = "View Customer Details";
            this.viewCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerDetailsToolStripMenuItem_Click);
            // 
            // MDI_LED_Bulb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1729, 963);
            this.Controls.Add(this.lbl_Logged_In_Uname);
            this.Controls.Add(this.pb_Logout);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1747, 1010);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1747, 1010);
            this.Name = "MDI_LED_Bulb";
            this.Text = "MDI LED Bulb";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_LED_Bulb_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCategoryToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_Logout;
        private System.Windows.Forms.Label lbl_Logged_In_Uname;
        private System.Windows.Forms.ToolStripMenuItem distributorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDistributorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateDistributorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDistributorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRetailerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRetailerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRetailerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNormalCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retailerOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerDetailsToolStripMenuItem;
    }
}




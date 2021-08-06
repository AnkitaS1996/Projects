using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    public partial class MDI_LED_Bulb : Form
    {
        public MDI_LED_Bulb()
        {
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Product Obj = new Frm_Add_Product();
            Obj.MdiParent = this;
            Obj.Show();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Category ACObj = new Frm_Add_Category();
            ACObj.MdiParent = this;
            ACObj.WindowState = FormWindowState.Maximized;
            ACObj.Show();
        }

        private void viewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_View_Category VCObj = new Frm_View_Category();
            VCObj.MdiParent = this;
            VCObj.WindowState = FormWindowState.Maximized;
            VCObj.Show();
        }

        private void MDI_LED_Bulb_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_Uname.Text = "Welcome" + " " + Code_Class_Global_Vars.Uname;
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Stock ASObj = new Frm_Add_Stock();
            ASObj.MdiParent = this;
            ASObj.WindowState = FormWindowState.Maximized;
            ASObj.Show();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_View_Stock VSObj = new Frm_View_Stock();
            VSObj.MdiParent = this;
            VSObj.WindowState = FormWindowState.Maximized;
            VSObj.Show();
        }

        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_View_Product VPObj = new Frm_View_Product();
            VPObj.MdiParent = this;
            VPObj.WindowState = FormWindowState.Maximized;
            VPObj.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Update_Product UPobj = new Frm_Update_Product();
            UPobj.MdiParent = this;
            UPobj.WindowState = FormWindowState.Maximized;
            UPobj.Show();
        }

        private void updateCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Update_Category UCobj = new Frm_Update_Category();
            UCobj.MdiParent = this;
            UCobj.WindowState = FormWindowState.Maximized;
            UCobj.Show();
        }

        private void addDistributorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Distributors ADobj = new Frm_Add_Distributors();
            ADobj.MdiParent = this;
            ADobj.WindowState = FormWindowState.Maximized;
            ADobj.Show();
        }
        private void updateDistributorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Update_Distributors UDobj = new Frm_Update_Distributors();
            UDobj.MdiParent = this;
            UDobj.WindowState = FormWindowState.Maximized;
            UDobj.Show();
        }

        private void viewDistributorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_View_Distributors DVobj = new Frm_View_Distributors();
            DVobj.MdiParent = this;
            DVobj.WindowState = FormWindowState.Maximized;
            DVobj.Show();
        }
        private void pb_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are You Sure Close This Application???...", "Application Close", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Result == DialogResult.Yes)
            {
                Frm_Login Lobj = new Frm_Login();
                Lobj.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void addRetailerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Retailer_Info ARIObj = new Frm_Add_Retailer_Info();
            ARIObj.MdiParent = this;
            ARIObj.WindowState = FormWindowState.Maximized;
            ARIObj.Show();
        }

        private void viewRetailerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_View_Retailer VRObj = new Frm_View_Retailer();
            VRObj.MdiParent = this;
            VRObj.WindowState = FormWindowState.Maximized;
            VRObj.Show();
        }

        private void updateRetailerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Update_Retailer_Info URIObj = new Frm_Update_Retailer_Info();
            URIObj.MdiParent = this;
            URIObj.WindowState = FormWindowState.Maximized;
            URIObj.Show();
        }

        private void addNormalCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Normal_Customer ANCObj = new Frm_Add_Normal_Customer();
            ANCObj.MdiParent = this;
            ANCObj.WindowState = FormWindowState.Maximized;
            ANCObj.Show();
        }

        private void viewCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_View_Customer_Details VCObj = new Frm_View_Customer_Details();
            VCObj.MdiParent = this;
            VCObj.WindowState = FormWindowState.Maximized;
            VCObj.Show();
        }

        private void showPendingBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Show_Pending_Bills SPBill = new Frm_Show_Pending_Bills();
            SPBill.MdiParent = this;
            SPBill.WindowState = FormWindowState.Maximized;
            SPBill.Show();
        }

        private void retailerOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Retailer_Order ROobj = new Frm_Retailer_Order();
            ROobj.MdiParent = this;
            ROobj.WindowState = FormWindowState.Maximized;
            ROobj.Show();
        }

        private void acceptPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Accept_Payment ACPObj = new Frm_Accept_Payment();
            ACPObj.MdiParent = this;
            ACPObj.WindowState = FormWindowState.Maximized;
            ACPObj.Show();
        }
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_User_Managements obj = new Frm_User_Managements();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void monthlyProdutSalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Forms.Frm_Monthly_Product_Sales_Reports Obj1 = new Report_Forms.Frm_Monthly_Product_Sales_Reports();
            Obj1.MdiParent = this;
            Obj1.WindowState = FormWindowState.Maximized;
            Obj1.Show();
        }

        private void monthlyStockReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Forms.Frm_Monthly_Stock_Reports obj2 = new Report_Forms.Frm_Monthly_Stock_Reports();
            obj2.MdiParent = this;
            obj2.WindowState = FormWindowState.Maximized;
            obj2.Show();
        }

        private void monthlyOrderReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Forms.Frm_Monthly_Order_Reports OObj = new Report_Forms.Frm_Monthly_Order_Reports();
            OObj.MdiParent = this;
            OObj.WindowState = FormWindowState.Maximized;
            OObj.Show();
        }

        private void monthlyAddProductReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Forms.Frm_Monthly_Add_Product_Reports APObj = new Report_Forms.Frm_Monthly_Add_Product_Reports();
            APObj.MdiParent = this;
            APObj.WindowState = FormWindowState.Maximized;
            APObj.Show();
        }
    }
}

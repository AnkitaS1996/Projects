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

       
    }
}

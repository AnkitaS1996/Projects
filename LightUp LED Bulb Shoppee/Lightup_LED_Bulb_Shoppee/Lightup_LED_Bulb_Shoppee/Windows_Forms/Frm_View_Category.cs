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
    public partial class Frm_View_Category : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_View_Category()
        {
            InitializeComponent();
        }
        private void cmb_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            txt_Search.Enabled = true;
            txt_Search.Focus();
        }
        private void Frm_View_Category_Load(object sender, EventArgs e)
        {
            txt_Search.Enabled = false;
            GVObj.FillDataGridView("Select * from Category_db", DGV_View_Product_Data);
        }
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
            {
                GVObj.FillDataGridView("Select * from Category_db", DGV_View_Product_Data);
            }
            if (cmb_SearchBy.Text == "Product ID")
            {
                GVObj.FillDataGridView("Select * from Category_db where Category_ID like " + txt_Search.Text + "", DGV_View_Product_Data);
            }
            if (cmb_SearchBy.Text == "Category")
            {
                GVObj.FillDataGridView("Select * from Category_db where Category like '" + txt_Search.Text + "%'", DGV_View_Product_Data);
            }
            if (cmb_SearchBy.Text == "Product Name")
            {
                GVObj.FillDataGridView("Select * from Category_db where Product_Name like '" + txt_Search.Text + "%'", DGV_View_Product_Data);
            }
        }
        private void pb_Exit_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are You Sure Close This Form???...", "Form Close", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            cmb_SearchBy.SelectedIndex = -1;
            DialogResult result = MessageBox.Show("Are You Refresh Clear All Text Box", "Clear Text", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                GVObj.FillDataGridView("Select * from Category_db", DGV_View_Product_Data);
                
            }
            else
            {
                this.Show();
            }
        }
    }
}

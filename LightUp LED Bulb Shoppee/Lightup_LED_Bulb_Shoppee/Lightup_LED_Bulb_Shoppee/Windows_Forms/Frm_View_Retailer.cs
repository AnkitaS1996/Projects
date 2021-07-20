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
    public partial class Frm_View_Retailer : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_View_Retailer()
        {
            InitializeComponent();
        }

        #region View Retailer From Load Code
        private void Frm_View_Retailer_Load(object sender, EventArgs e)
        {
            txt_Search.Enabled = false;
            GVObj.FillDataGridView("Select * from Distributor_db", DGV_View_Product_Data);
        }
        #endregion

        #region Combobox SearchBy SelectedIndexChanged Code
        private void cmb_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            txt_Search.Enabled = true;
            txt_Search.Focus();
        }
        #endregion

        #region Search TextChanged Code
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
            {
                GVObj.FillDataGridView("Select * from Retailer_Details_db",DGV_View_Product_Data);
            }
            if (cmb_SearchBy.Text == "Retailer ID")
            {
                GVObj.FillDataGridView("Select * from Retailer_Details_db where Retailer_ID like '" + txt_Search.Text + "'", DGV_View_Product_Data);
            }
            if (cmb_SearchBy.Text == "Retailer Name")
            {
                GVObj.FillDataGridView("Select * from Retailer_Details_db where Name like '" + txt_Search.Text + "%'", DGV_View_Product_Data);
            }
        }
        #endregion

        #region Refresh Button Code
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            cmb_SearchBy.SelectedIndex = -1;

            GVObj.FillDataGridView("Select * from Retailer_Details_db", DGV_View_Product_Data);
        }
        #endregion

        #region Exit Code
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
        #endregion
    }
}

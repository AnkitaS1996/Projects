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
    public partial class Frm_View_Customer_Details : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_View_Customer_Details()
        {
            InitializeComponent();
        }

        #region View Customer Details Loading Form
        private void Frm_View_Customer_Details_Load(object sender, EventArgs e)
        {
            txt_Search.Enabled = false;
            GVObj.FillDataGridView("Select * from Customer_Details_db", DGV_View_Customer_Data);
        }
        #endregion

        #region Cmbobox SelectedIndex Changed code
        private void cmb_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            txt_Search.Enabled = true;
            txt_Search.Focus();
        }
        #endregion

        #region Search Textchanged code
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
            {
                GVObj.FillDataGridView("Select * from Customer_Details_db", DGV_View_Customer_Data);
            }
            if (cmb_SearchBy.Text == "Customer ID")
            {
                GVObj.FillDataGridView("Select * from Customer_Details_db where Customer_ID like '" + txt_Search.Text + "'", DGV_View_Customer_Data);
            }
            if (cmb_SearchBy.Text == "Customer Name")
            {
                GVObj.FillDataGridView("Select * from Customer_Details_db where Customer_Name like '" + txt_Search.Text + "%'", DGV_View_Customer_Data);
            }
        }
        #endregion

        #region Refresh Code
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            GVObj.FillDataGridView("Select * from Customer_Details_db", DGV_View_Customer_Data);
            txt_Search.Clear();
            cmb_SearchBy.Text = "";
        }
        #endregion

        #region Exit Code
        private void pb_Exits_Click(object sender, EventArgs e)
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

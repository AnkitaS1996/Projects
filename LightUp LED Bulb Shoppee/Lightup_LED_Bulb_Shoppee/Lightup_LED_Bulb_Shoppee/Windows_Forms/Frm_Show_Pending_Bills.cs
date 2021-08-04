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
    public partial class Frm_Show_Pending_Bills : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Show_Pending_Bills()
        {
            InitializeComponent();
        }

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

        #region Show Pending Bill Load From code
        private void Frm_Show_Pending_Bills_Load(object sender, EventArgs e)
        {
            txt_Pending_Bills.Enabled = false;
            GVObj.FillDataGridView("Select ROD.Order_ID,RD.Name,RD.Mobile_No,ROD.Create_Date,ROD.Final_Bills,ROD.Paid_Bills,ROD.Remaining_Bills from Retailer_Details_db RD Inner Join Retailer_Order_Details_db ROD ON RD.Retailer_ID = ROD.Retailer_ID", DGV_Pending_Bills);
            Pending_Bill_Totals();
        }
        #endregion

        #region Combobox SelectedIndexChanged Code
        private void cmb_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            txt_Search.Enabled = true;
            txt_Search.Focus();
        }
        #endregion

        #region Textbox Textchanged Code
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if(txt_Search.Text != "")
            {
                GVObj.FillDataGridView("Select ROD.Order_ID,RD.Name,RD.Mobile_No,ROD.Create_Date,ROD.Final_Bills,ROD.Paid_Bills,ROD.Remaining_Bills from Retailer_Details_db RD Inner Join Retailer_Order_Details_db ROD ON RD.Retailer_ID = ROD.Retailer_ID", DGV_Pending_Bills);
                Pending_Bill_Totals();
            }
            if(cmb_SearchBy.Text == "Retailer ID")
            {
                GVObj.FillDataGridView("Select ROD.Order_ID,RD.Name,RD.Mobile_No,ROD.Create_Date,ROD.Final_Bills,ROD.Paid_Bills,ROD.Remaining_Bills from Retailer_Details_db RD Inner Join Retailer_Order_Details_db ROD ON RD.Retailer_ID = ROD.Retailer_ID where RD.Retailer_ID like'" + txt_Search.Text + "'",DGV_Pending_Bills);
                Pending_Bill_Totals();
            }
            if(cmb_SearchBy.Text == "Retailer Name")
            {
                GVObj.FillDataGridView("Select ROD.Order_ID,RD.Name,RD.Mobile_No,ROD.Create_Date,ROD.Final_Bills,ROD.Paid_Bills,ROD.Remaining_Bills from Retailer_Details_db RD Inner Join Retailer_Order_Details_db ROD ON RD.Retailer_ID = ROD.Retailer_ID where RD.Name like '" + txt_Search.Text + "%' ",DGV_Pending_Bills);
                Pending_Bill_Totals();
            }
        }
        #endregion

        #region Refresh Gridview Code
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            GVObj.FillDataGridView("Select ROD.Order_ID,RD.Name,RD.Mobile_No,ROD.Create_Date,ROD.Final_Bills,ROD.Paid_Bills,ROD.Remaining_Bills from Retailer_Details_db RD Inner Join Retailer_Order_Details_db ROD ON RD.Retailer_ID = ROD.Retailer_ID", DGV_Pending_Bills);
            Pending_Bill_Totals();
            txt_Search.Enabled = false;
            txt_Search.Text = "";
            cmb_SearchBy.Text = "";
        }
        #endregion

        #region Pending Bill Total Function
        private void Pending_Bill_Totals()
        {
            var Total_Row = DGV_Pending_Bills.Rows.Count;
            decimal Total_Pending_Bill = 0;
            for(int i = 0;i < Total_Row;i++)
            {
                Total_Pending_Bill += Convert.ToDecimal(DGV_Pending_Bills.Rows[i].Cells[6].Value); 
            }
            txt_Pending_Bills.Text = Total_Pending_Bill.ToString();
        }
        #endregion
    }
}

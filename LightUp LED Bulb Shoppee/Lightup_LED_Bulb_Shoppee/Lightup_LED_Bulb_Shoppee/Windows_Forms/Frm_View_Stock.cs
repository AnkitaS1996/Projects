using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    public partial class Frm_View_Stock : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_View_Stock()
        {
            InitializeComponent();
        }

        #region Start Fill Gridview Code
        private void Fill_Gridview()
        {
            GVObj.Con_Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select SPD.Sub_Product_ID,MPD.Category,MPD.Product_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Warrenty,SPD.Current_Stock from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON SPD.Main_Product_ID = MPD.Main_Product_ID", GVObj.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DGV_View_Product_Data.DataSource = dt;
            sda.Dispose();
            dt.Dispose();
            GVObj.Con_Close();
        }
        #endregion

        #region Cmb_SearchBy Selected Index changed code
        private void cmb_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            txt_Search.Enabled = true;
            txt_Search.Focus();
        }
        #endregion

        #region Search TextChanged Event Code
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
            {
                GVObj.FillDataGridView("Select SPD.Sub_Product_ID,MPD.Category,MPD.Product_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Warrenty,SPD.Current_Stock from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON SPD.Main_Product_ID = SPD.Main_Product_ID", DGV_View_Product_Data);
            }
            if (cmb_SearchBy.Text == "Product ID")
            {
                GVObj.FillDataGridView("Select SPD.Sub_Product_ID,MPD.Category,MPD.Product_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Current_Stock,SPD.Warrenty from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON SPD.Main_Product_ID = MPD.Main_Product_ID where SPD.Sub_Product_ID = '" + txt_Search.Text + "'", DGV_View_Product_Data);
                //txt_Search.Clear();
            }
            if (cmb_SearchBy.Text == "Category")
            {
                GVObj.FillDataGridView("Select SPD.Sub_Product_ID,MPD.Category,MPD.Product_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Current_Stock,SPD.Warrenty from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON SPD.Main_Product_ID = MPD.Main_Product_ID where MPD.Category like '" + txt_Search.Text + "%'",DGV_View_Product_Data);
            }
            if (cmb_SearchBy.Text == "Product Name")
            {
                GVObj.FillDataGridView("Select SPD.Sub_Product_ID,MPD.Category,MPD.Product_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Current_Stock,SPD.Warrenty from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON SPD.Main_Product_ID = MPD.Main_Product_ID where MPD.Product_Name like '" + txt_Search.Text + "%'",DGV_View_Product_Data);
            }
        }
        #endregion

        #region Refresh Button Code
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Fill_Gridview();
            txt_Search.Text = "";
            cmb_SearchBy.SelectedIndex = -1;
        }
        #endregion

        #region Exit Button Code
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

        private void Frm_View_Stock_Load(object sender, EventArgs e)
        {
            Fill_Gridview();
        }
    }
}

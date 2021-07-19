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
    public partial class Frm_View_Product : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_View_Product()
        {
            InitializeComponent();
        }
        void Fill_Gridview_Code()
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select MPD.Main_Product_ID,MPD.Date,MPD.Category,MPD.Product_Name,MPD.Distributor_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Warrenty,SPD.Current_Stock from Main_Product_Details_db MPD INNER JOIN Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID", GVObj.con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            DGV_View_Product_Data.DataSource = dt;
            GVObj.Con_Close();
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

        private void cmb_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            txt_Search.Enabled = true;
            txt_Search.Focus();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
            {
                GVObj.FillDataGridView("Select MPD.Main_Product_ID,MPD.Date,MPD.Category,MPD.Product_Name,MPD.Distributor_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Warrenty,SPD.Current_Stock from Main_Product_Details_db MPD INNER JOIN Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID", DGV_View_Product_Data);
            }
            if (cmb_SearchBy.Text == "Product ID")
            {
                GVObj.FillDataGridView("Select MPD.Main_Product_ID,MPD.Date,MPD.Category,MPD.Product_Name,MPD.Distributor_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Warrenty,SPD.Current_Stock from Main_Product_Details_db MPD INNER JOIN Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID where MPD.Main_Product_ID like " + txt_Search.Text + "", DGV_View_Product_Data);
            }
            if (cmb_SearchBy.Text == "Category")
            {
                GVObj.FillDataGridView("Select MPD.Main_Product_ID,MPD.Date,MPD.Category,MPD.Product_Name,MPD.Distributor_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Warrenty,SPD.Current_Stock from Main_Product_Details_db MPD INNER JOIN Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID where MPD.Category like '" + txt_Search.Text + "%'", DGV_View_Product_Data);
            }
            if (cmb_SearchBy.Text == "Product Name")
            {
                GVObj.FillDataGridView("Select MPD.Main_Product_ID,MPD.Date,MPD.Category,MPD.Product_Name,MPD.Distributor_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Warrenty,SPD.Current_Stock from Main_Product_Details_db MPD INNER JOIN Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID where MPD.Product_Name like '" + txt_Search.Text + "%'", DGV_View_Product_Data);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Fill_Gridview_Code();
        }

        private void Frm_View_Product_Load(object sender, EventArgs e)
        {
            Fill_Gridview_Code();
        }
    }
}

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
    public partial class Frm_Add_Normal_Customer : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Add_Normal_Customer()
        {
            InitializeComponent();
        }

        #region Bind Combobox code
        private void Bind_Combobox_Category_Data()
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select Distinct(Category) from Category_db", GVObj.con);
            var obj = cmd.ExecuteReader();
            while (obj.Read())
            {
                cmb_Category.Items.Add(obj["Category"].ToString());
            }
            obj.Dispose();
            cmd.Dispose();
            GVObj.Con_Close();
        }
        private void Bind_Product_Name_Combobox()
        {
            GVObj.Con_Open();
            SqlCommand cmd1 = new SqlCommand("Select (Product_Name) from Category_db where Category = '" + cmb_Category.Text + "'", GVObj.con);
            var obj = cmd1.ExecuteReader();
            while (obj.Read())
            {
                cmb_Product_Name.Items.Add(obj["Product_Name"].ToString());
            }
            cmd1.Dispose();
            obj.Dispose();
            GVObj.Con_Close();
        }
        #endregion

        #region Add Normal Customer From Load Code
        private void Frm_Add_Normal_Customer_Load(object sender, EventArgs e)
        {
            Bind_Combobox_Category_Data();
            txt_Unit_Price.Enabled = false;
        }
        #endregion
        #region Combobox SelectedIndexChanged Event Handling Code
        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Product_Name_Combobox();
        }
        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            SqlCommand cmd1 = new SqlCommand("Select SPD.Watts from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID where MPD.Category = '" + cmb_Category.Text + "' And MPD.Product_Name = '" + cmb_Product_Name.Text + "'", GVObj.con);
            var obj = cmd1.ExecuteReader();
            while (obj.Read())
            {
                cmb_Watts.Items.Add(obj["Watts"].ToString());
            }
            cmd1.Dispose();
            obj.Dispose();
            GVObj.Con_Close();
        }
        #endregion

        #region Combobox Textchanged Code
        private void cmb_Category_TextChanged(object sender, EventArgs e)
        {
            cmb_Product_Name.Items.Clear();
            cmb_Product_Name.SelectedIndex = -1;
        }
        private void cmb_Product_Name_TextChanged(object sender, EventArgs e)
        {
            cmb_Watts.Items.Clear();
            cmb_Watts.SelectedIndex = -1;
        }
        #endregion

      
    }
}

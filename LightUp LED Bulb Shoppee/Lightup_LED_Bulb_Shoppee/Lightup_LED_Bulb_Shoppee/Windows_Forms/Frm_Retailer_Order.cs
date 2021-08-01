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
    public partial class Frm_Retailer_Order : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        DataTable DT = new DataTable();
        int Stock = 0;
        public Frm_Retailer_Order()
        {
            InitializeComponent();
        }

        #region AutoIncrement Code
        private void Auto_Increment()
        {
            txt_Order_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(Order_ID) from Retailer_Order_Details_db", "Select Max(Order_ID) from Retailer_Order_Details_db", 10001));
        }
        #endregion

        #region Enable False
        private void Enabled_False()
        {
            txt_Order_ID.Enabled = false;
            dtp_Date.Enabled = false;
            txt_Cust_Name.Enabled = false;
            txt_Mobile_No.Enabled = false;
            txt_Unit_Price.Enabled = false;
            txt_Total_Price.Enabled = false;
        }
        #endregion

        #region Retailer Order Load Form
        private void Frm_Retailer_Order_Load(object sender, EventArgs e)
        {
            Enabled_False();
            //txt_Order_ID.Enabled = false;
            Bind_Combobox_Category_Data();
            Auto_Increment();
        }
        #endregion

        #region Clear Control Code
        private void Clear_Control_Product_Details()
        {
            cmb_Category.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            cmb_Watts.Text = "";
            txt_Unit_Price.Clear();
            txt_Quantity.Text = "";
            txt_Total_Price.Text = "";

        }
        private void Clear_Control_Customer_Details()
        {
            txt_Cust_ID.Text = "";
            dtp_Date.Text = "";
            txt_Cust_Name.Clear();
            txt_Mobile_No.Clear();
            txt_Total_Bill.Clear();
            txt_Discount.Clear();
            txt_GST.Text = "";
            txt_Final_Bills.Clear();
            txt_Remaining_Bills.Clear();
            txt_Paid_Bills.Clear();
           // dt.Rows.Clear();
        }
        #endregion

        #region Create Column
        private void Create_Column()
        {
            //DataTable dt = new DataTable();
            DataColumn c1 = new DataColumn("Category", typeof(string));
            DataColumn c2 = new DataColumn("Product Name", typeof(string));
            DataColumn c3 = new DataColumn("Watts", typeof(string));
            DataColumn c4 = new DataColumn("Unit Price", typeof(decimal));
            DataColumn c5 = new DataColumn("Quantity", typeof(int));
            DataColumn c6 = new DataColumn("Total Price", typeof(decimal));
            DT.Columns.Add(c1);
            DT.Columns.Add(c2);
            DT.Columns.Add(c3);
            DT.Columns.Add(c4);
            DT.Columns.Add(c5);
            DT.Columns.Add(c6);
        }
        #endregion

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

        #region Combobox SelectedIndexChanged Event Handling Code
        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Product_Name_Combobox();
        }
        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            SqlCommand cmd1 = new SqlCommand("Select SPD.Watts from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID where MPD.Category = '" + cmb_Category.Text + "' And MPD.Product_Name = '" + cmb_Product_Name.Text + "'", GVObj.con);
            /*SqlCommand cmd1 = new SqlCommand("SELECT Main_Product_ID FROM Main_Product_Details_db WHERE Category = '" + cmb_Category.Text + "' And Product_Name='" + cmb_Product_Name.Text + "'", GVObj.con);
             var obj = cmd1.ExecuteReader();
             while(obj.Read())
             {
                 ID = Convert.ToInt32(obj["Main_Product_ID"]);
             }
             cmd1.Dispose();
             obj.Dispose();*/

            //SqlCommand cmd2 = new SqlCommand("Select Watts from Sub_Product_Details_db where Main_Product_ID = " + ID + "",GVObj.con);
            var obj1 = cmd1.ExecuteReader();
            while (obj1.Read())
            {
                cmb_Watts.Items.Add(obj1["Watts"].ToString());
            }
            GVObj.Con_Close();
        }
        private void cmb_Watts_SelectedIndexChanged(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select SPD.Unit_Price from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID where MPD.Category = '" + cmb_Category.Text + "' And MPD.Product_Name = '" + cmb_Product_Name.Text + "' And SPD.Watts = '" + cmb_Watts.Text + "'", GVObj.con);
            //SqlCommand cmd = new SqlCommand("SELECT Unit_Price,Sub_Product_ID FROM Sub_Product_Details_db WHERE Watts='" + cmb_Watts.Text + "' AND Main_Product_ID = " + ID + "", GVObj.con);
            var obj = cmd.ExecuteReader();
            if (obj.Read())
            {
                txt_Unit_Price.Text = obj["Unit_Price"].ToString();
                //SPID = Convert.ToInt32(obj["Sub_Product_ID"]);
            }
            cmd.Dispose();
            obj.Dispose();
            GVObj.Con_Close();
        }

        #endregion

        #region Combobox textchanged Code
        private void cmb_Category_TextChanged(object sender, EventArgs e)
        {
            cmb_Product_Name.Items.Clear();
            cmb_Product_Name.SelectedIndex = -1;
            cmb_Product_Name.Text = "";
            txt_Unit_Price.Clear();
        }

        private void cmb_Product_Name_TextChanged(object sender, EventArgs e)
        {
            cmb_Watts.Items.Clear();
            cmb_Watts.SelectedIndex = -1;
            cmb_Watts.Text = "";
            txt_Unit_Price.Clear();
        }

        private void cmb_Watts_TextChanged(object sender, EventArgs e)
        {
            txt_Unit_Price.Clear();
        }
        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("SELECT SPD.Current_Stock FROM Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID WHERE MPD.Category='" + cmb_Category.Text + "' AND MPD.Product_Name = '" + cmb_Product_Name.Text + "'And SPD.Watts='" + cmb_Watts.Text + "'", GVObj.con);
            // SqlCommand cmd = new SqlCommand("Select Current_Stock from Sub_Product_Details_db Where Watts = '" + cmb_Watts.Text + "' And Sub_Product_ID = " + SPID + " ", GVObj.con);
            var Obj = cmd.ExecuteReader();
            if (Obj.Read())
            {
                Stock = Convert.ToInt32(Obj["Current_Stock"]);
            }
            cmd.Dispose();
            Obj.Dispose();

            GVObj.Con_Close();

            if (txt_Quantity.Text != "" && Convert.ToInt32(txt_Quantity.Text) > 0)
            {
                if (Stock >= Convert.ToInt32(txt_Quantity.Text))
                {
                    txt_Total_Price.Text = (Convert.ToDouble(txt_Quantity.Text) * Convert.ToDouble(txt_Unit_Price.Text)).ToString();
                    btn_Add.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No Enough Stock Available", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Quantity.Text = "";
                    txt_Total_Price.Text = "";
                }
            }
        }

        #endregion
        #region Search Button Code
        private void btn_Search_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            txt_Cust_ID.Enabled = false;

            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select Name,Mobile_No From Retailer_Details_db where Retailer_ID = " + Convert.ToInt32(txt_Cust_ID.Text) + "", GVObj.con);
            var Obj = cmd.ExecuteReader();

            if (Obj.Read())
            {
                txt_Cust_Name.Text = Obj["Name"].ToString();
                txt_Mobile_No.Text = Obj["Mobile_No"].ToString();
                MessageBox.Show("Record Search Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid ID There is No Record Please Enter Crrect ID", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cust_ID.Enabled = true;
                txt_Cust_ID.Clear();
                Enabled_False();
            }
            GVObj.Con_Close();
        }
        #endregion
    }
}

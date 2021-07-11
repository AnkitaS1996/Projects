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
    public partial class Frm_Add_Product : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        public Frm_Add_Product()
        {
            InitializeComponent();
        }

        void Auto_Increment()
        {
            txt_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(Main_Product_ID) from Main_Product_Details_db", "Select Max(Main_Product_ID) from Main_Product_Details_db", 101));
        }
        void Bind_Combobox_Category_Data()
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select Distinct(Category) from Category_db", GVObj.con);
            var obj = cmd.ExecuteReader();
            while(obj.Read())
            {
                cmb_Category.Items.Add(obj["Category"].ToString());
            }
            obj.Dispose();
            cmd.Dispose();
            GVObj.Con_Close();
        }
        void Bind_Product_Name_Combobox()
        {
            GVObj.Con_Open();
            SqlCommand cmd1 = new SqlCommand("Select (Product_Name) from Category_db where Category = '" + cmb_Category.Text + "'",GVObj.con);
            var obj = cmd1.ExecuteReader();
            while(obj.Read())
            {
                cmb_Product_Name.Items.Add(obj["Product_Name"].ToString());
            }  
            cmd1.Dispose();
            obj.Dispose();
            GVObj.Con_Close();
        }
        void Bind_Distributor_Name_Combobox()
        {
            GVObj.Con_Open();
            SqlCommand c = new SqlCommand("Select Name from Distributor_db");
            c.Connection = GVObj.con;
            var obj = c.ExecuteReader();
            while(obj.Read())
            {
                cmb_Distributor.Items.Add(obj["Name"].ToString());
            }
            obj.Dispose();
            c.Dispose();
            GVObj.Con_Close();
        }
        void Clear_Control_Sub_Product()
        {
            txt_Watt.Clear();
            txt_Unit_Price.Clear();
            txt_Purchase_Price.Clear();
            txt_Warranty.Clear();
        }
        private void Frm_Add_Product_Load(object sender, EventArgs e)
        {
            Auto_Increment();
            Bind_Combobox_Category_Data();
            Bind_Distributor_Name_Combobox();
        }
        void Create_Column_Gridview()
        {
            DataTable dt = new DataTable();
            DataColumn c1 = new DataColumn("Watts",typeof(string));
            DataColumn c2 = new DataColumn("Unit Price", typeof(decimal));
            DataColumn c3 = new DataColumn("Purchase Price", typeof(decimal));
            DataColumn c4 = new DataColumn("Warrenty", typeof(string));
            dt.Columns.Add(c1);
            dt.Columns.Add(c2);
            dt.Columns.Add(c3);
            dt.Columns.Add(c4);
        }
        void Insert_Gridview()
        {
            GVObj.Con_Open();
            foreach(DataGridViewRow row in dgv_Sub_Product.Rows)
            {
                cmd.CommandText = "Insert into Sub_Product_Details(Watts,Unit_Price,Purchase_Price,Current_Stock,Main_Product_ID) Values('" + row.Cells[0].Value.ToString() + "'," + Convert.ToDecimal(row.Cells[1].Value) + "," + Convert.ToDecimal(row.Cells[2].Value) + ",'" + row.Cells[3].Value.ToString() + "'," + 0 + ",'" + Convert.ToInt32(txt_ID.Text) + "') ";
                cmd.Connection = GVObj.con;
                cmd.ExecuteNonQuery();
            }
            cmd.Dispose();
            GVObj.Con_Close();
        }
        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Product_Name_Combobox();
        }
        private void cmb_Category_TextChanged(object sender, EventArgs e)
        {
            cmb_Product_Name.Items.Clear();
            cmb_Product_Name.SelectedIndex = -1;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            decimal Purchase_Price = 0;
            if(txt_Purchase_Price.Text != "")
            {
                Purchase_Price = Convert.ToDecimal(txt_Purchase_Price.Text);
            }

            GVObj.Con_Open();
            if(txt_Watt.Text != "" && txt_Unit_Price.Text != "" && txt_Warranty.Text != "")
            {
                DialogResult result = MessageBox.Show("Are You Sure Add Data to Grid View", "Message", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    dt.Rows.Add(txt_Watt.Text,Convert.ToDecimal(txt_Unit_Price.Text),Convert.ToDecimal(txt_Purchase_Price.Text),txt_Warranty.Text,"0");
                    dgv_Sub_Product.DataSource = dt;
                    Clear_Control_Sub_Product();
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields....", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
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

        

        
    }
}

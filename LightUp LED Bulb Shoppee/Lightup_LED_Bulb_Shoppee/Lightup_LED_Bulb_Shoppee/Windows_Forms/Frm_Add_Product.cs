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
        DataTable dt = new DataTable();
        public Frm_Add_Product()
        {
            InitializeComponent();
        }
        #region AutoIncrement Code
        private void Auto_Increment()
        {
            txt_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(Main_Product_ID) from Main_Product_Details_db", "Select Max(Main_Product_ID) from Main_Product_Details_db", 101));
        }
        #endregion

        #region Bind Combobox code
        private void Bind_Combobox_Category_Data()
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
        private void Bind_Distributor_Name_Combobox()
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
        #endregion

        #region Clear Control Field Code
        private void clear_Control_All_Field()
        {
            Auto_Increment();
            cmb_Category.SelectedIndex = -1;
            cmb_Product_Name.Text = "";
            cmb_Distributor.SelectedIndex = -1;
            dt.Rows.Clear();
            Clear_Control_Sub_Product();
        }
        private void Clear_Control_Sub_Product()
        {
            txt_Watt.Clear();
            txt_Unit_Price.Clear();
            txt_Purchase_Price.Clear();
            txt_Warranty.Clear();
        }
        #endregion

        #region Add Product From Loding Code
        private void Frm_Add_Product_Load(object sender, EventArgs e)
        {
            Auto_Increment();
            Bind_Combobox_Category_Data();
            Bind_Distributor_Name_Combobox();
            Create_Column_Gridview();
        }
        #endregion

        #region Column Create Gridview Code
        void Create_Column_Gridview()
        {
            //DataTable dt = new DataTable();
            DataColumn c1 = new DataColumn("Watts",typeof(string));
            DataColumn c2 = new DataColumn("Unit Price",typeof(decimal));
            DataColumn c3 = new DataColumn("Purchase Price",typeof(decimal));
            DataColumn c4 = new DataColumn("Warrenty",typeof(string));
            dt.Columns.Add(c1);
            dt.Columns.Add(c2);
            dt.Columns.Add(c3);
            dt.Columns.Add(c4); 
        }
        #endregion

        #region Insert Gridview Code
        void Insert_Gridview()
        {
            int Stock = 0;
            GVObj.Con_Open();
            foreach(DataGridViewRow row in dgv_Sub_Product.Rows)
            {
                SqlCommand Cmd2 = new SqlCommand("Insert into Sub_Product_Details_db(Watts,Unit_Price,Purchase_Price,Warrenty,Current_Stock,Main_Product_ID) Values('" + row.Cells[2].Value.ToString() + "'," + Convert.ToDecimal(row.Cells[3].Value) + "," + Convert.ToDecimal(row.Cells[4].Value) + ",'" + row.Cells[4].Value.ToString() + "'," + Stock + "," + Convert.ToInt32(txt_ID.Text) + ")",GVObj.con);
                Cmd2.ExecuteNonQuery();
                Cmd2.Dispose();
            }
           
            GVObj.Con_Close();
        }
        #endregion
        #region Combobox SelectedIndexchanged Event Handling Code
        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Product_Name_Combobox();
        }
        #endregion

        #region Category Combobox Textchanged Code
        private void cmb_Category_TextChanged(object sender, EventArgs e)
        {
            cmb_Product_Name.Items.Clear();
            cmb_Product_Name.SelectedIndex = -1;
        }
        #endregion

        #region KeyPress Handling
        private void txt_Watt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txt_Unit_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txt_Purchase_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region KeyDown Event Handling
        private void cmb_Distributor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Watt.Focus();
            }
        }
        private void txt_Watt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Unit_Price.Focus();
            }
        }
        private void txt_Unit_Price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Purchase_Price.Focus();
            }
        }
        private void txt_Purchase_Price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Warranty.Focus();
            }
        }
        private void txt_Warranty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Add.Focus();
            }
        }
        #endregion
        
        #region Add Button Click Code
        private void btn_Add_Click(object sender, EventArgs e)
        {
            decimal Purchase_Price = 0;
            if(txt_Purchase_Price.Text != "")
            {
                Purchase_Price = Convert.ToDecimal(txt_Purchase_Price.Text);
            }

            GVObj.Con_Open();
            int flag = -1;
            if (txt_Watt.Text != "" && txt_Unit_Price.Text != "" && txt_Warranty.Text != "")
            {
                DialogResult result = MessageBox.Show("Are You Sure Add Data to Grid View", "Message", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewButtonColumn Edit = new DataGridViewButtonColumn();
                    Edit.Name = "Edit";
                    Edit.Text = "Edit";
                    Edit.UseColumnTextForButtonValue = true;
                    int columnIndex = 0;

                    if (dgv_Sub_Product.Columns["Edit"] == null)
                    {
                        dgv_Sub_Product.Columns.Insert(columnIndex, Edit);
                    }
                    foreach (DataGridViewRow row in dgv_Sub_Product.Rows)
                    {
                        if (Convert.ToString(row.Cells[0].Value) == txt_Watt.Text + "W")
                        {
                            flag = 0;
                            row.Cells[1].Value = Convert.ToDecimal(txt_Unit_Price.Text);
                            row.Cells[2].Value = Purchase_Price;
                            row.Cells[3].Value = Convert.ToString(txt_Warranty.Text);
                            Clear_Control_Sub_Product();
                        }
                    } 
                    if (flag == -1)
                    {
                        dt.Rows.Add(txt_Watt.Text + "W", Convert.ToDecimal(txt_Unit_Price.Text), Purchase_Price, txt_Warranty.Text);
                        dgv_Sub_Product.DataSource = dt;
                        Clear_Control_Sub_Product();
                        dt.Dispose();
                    }
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.Name = "Remove";
                    btn.Text = "Remove";
                    btn.UseColumnTextForButtonValue = true;
                    columnIndex = 1;
                    if (dgv_Sub_Product.Columns["Remove"] == null)
                    {
                        dgv_Sub_Product.Columns.Insert(columnIndex, btn);
                    }
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields.....!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GVObj.Con_Close();
        }
        #endregion

        #region Save Button Code
        private void btn_Save_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            if(txt_ID.Text != "" && cmb_Category.Text != "" && cmb_Product_Name.Text != "" && cmb_Distributor.Text != "" && dgv_Sub_Product.Rows.Count > 0)
            {
                SqlCommand cmd3 = new SqlCommand("Insert into Main_Product_Details_db Values(@id,@Date,@Category,@ProductName,@Distributor)", GVObj.con);
                cmd3.Parameters.Add("@id", SqlDbType.Int).Value = txt_ID.Text;
                cmd3.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Date.Text;
                cmd3.Parameters.Add("@Category", SqlDbType.NVarChar).Value = cmb_Category.Text;
                cmd3.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = cmb_Product_Name.Text;
                cmd3.Parameters.Add("@Distributor", SqlDbType.NVarChar).Value = cmb_Distributor.Text;
                cmd3.ExecuteNonQuery();
                Insert_Gridview();
                MessageBox.Show("Record Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd3.Dispose();
                clear_Control_All_Field();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields.....!!!", "Fill The Field Completely", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GVObj.Con_Close();
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

        #region Refresh Button Code
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Are Sure Clear Data","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(R == DialogResult.Yes)
            {
                MessageBox.Show("Clear All Text Box");
                clear_Control_All_Field();
            }
            else
            {
                MessageBox.Show("Refresh Data");
                this.Show();
            }
        }
        #endregion

        #region Gridview Cell Click
        private void dgv_Sub_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            string w = "";
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                txt_Watt.Text = dt.Rows[i][0].ToString();
                txt_Unit_Price.Text = dt.Rows[i][1].ToString();
                txt_Purchase_Price.Text = dt.Rows[i][2].ToString();
                txt_Warranty.Text = dt.Rows[i][3].ToString();
                w = (Convert.ToInt32(txt_Watt.Text.Remove(txt_Watt.Text.Length - 1))).ToString();
                txt_Watt.Text = w;
            }
            if (e.RowIndex >= 0)
            {
                DataRow dr = dt.Rows[e.RowIndex];
                dr.Delete();
                dgv_Sub_Product.DataSource = dt;
            }
        }
        #endregion
    }
}

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
    public partial class Frm_Add_Stock : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Add_Stock()
        {
            InitializeComponent();
        }

        #region Clear Control Field
        private void Clear_Control_Field()
        {
            txt_ID.Clear();
            txt_Category.Clear();
            txt_Product_Name.Clear();
            txt_Watts.Clear();
            txt_Current_Stock.Clear();
            txt_New_Stock.Clear();
            dtp_Current_Date.Text = "";

        }
        #endregion

        #region Enabled False Code
        private void Enabled_False()
        {
            txt_ID.Enabled = false;
            txt_Category.Enabled = false;
            txt_Product_Name.Enabled = false;
            txt_Watts.Enabled = false;
            txt_Current_Stock.Enabled = false;
        }
        #endregion

        #region Start Fill Gridview Code
        private void Fill_Gridview()
        {
            GVObj.Con_Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select SPD.Sub_Product_ID,MPD.Category,MPD.Product_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Current_Stock from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON SPD.Main_Product_ID = MPD.Main_Product_ID",GVObj.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Stock_Data.DataSource = dt;
            sda.Dispose();
            dt.Dispose();
            GVObj.Con_Close();
        }
        #endregion

        #region Start Update Stock Code
        private void Update_Stock()
        {
            int Stock = 0;
            GVObj.Con_Open();
            Stock = Convert.ToInt32(txt_Current_Stock.Text) + Convert.ToInt32(txt_New_Stock.Text);
            SqlDataAdapter s = new SqlDataAdapter("Update Sub_Product_Details_db SET Current_Stock = " + Stock + " where Sub_Product_ID = " + txt_ID.Text + "", GVObj.con);
            DataTable d = new DataTable();
            s.Fill(d);
            s.Dispose();
            d.Dispose();
            GVObj.Con_Close();
        }
        #endregion

        #region Stock From Load Code
        private void Frm_Add_Stock_Load(object sender, EventArgs e)
        {
            Fill_Gridview();
            Enabled_False();
        }
        #endregion

        #region Searchby Selected Index event Code
        private void cb_Searchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            txt_Search.Enabled = true;
            txt_Search.Focus();
        }
        #endregion

        #region Search textchanged event Code
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
            {
                GVObj.FillDataGridView("Select SPD.Sub_Product_ID,MPD.Category,MPD.Product_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Current_Stock from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON SPD.Main_Product_ID = SPD.Main_Product_ID", dgv_Stock_Data);
            }
            if (cb_Searchby.Text == "Product ID")
            {
                GVObj.FillDataGridView("Select SPD.Sub_Product_ID,MPD.Category,MPD.Product_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Current_Stock from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON SPD.Main_Product_ID = MPD.Main_Product_ID where SPD.Sub_Product_ID like '" + txt_Search.Text + "'", dgv_Stock_Data);
            }
            if (cb_Searchby.Text == "Category")
            {
                GVObj.FillDataGridView("Select SPD.Sub_Product_ID,MPD.Category,MPD.Product_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Current_Stock from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON SPD.Main_Product_ID = MPD.Main_Product_ID where MPD.Category like '" + txt_Search.Text + "%'", dgv_Stock_Data);
            }
            if (cb_Searchby.Text == "Product Name")
            {
                GVObj.FillDataGridView("Select SPD.Sub_Product_ID,MPD.Category,MPD.Product_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Current_Stock from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON SPD.Main_Product_ID = MPD.Main_Product_ID where MPD.Product_Name like '" + txt_Search.Text + "%'", dgv_Stock_Data);
            }
        }
        #endregion

        #region Save Button Code
        private void btn_Save_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            if (txt_New_Stock.Text != "" && txt_ID.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Are Sure Save The Data", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    SqlCommand cmd1 = new SqlCommand("Insert into Stock_Details Values(" + txt_ID.Text + "," + txt_New_Stock.Text + ",@Current_Date) ");
                    cmd1.Parameters.Add("@Current_Date", SqlDbType.Date).Value = dtp_Current_Date.Text;
                    cmd1.Connection = GVObj.con;
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    Update_Stock();
                    Fill_Gridview();
                    MessageBox.Show("Record Save Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Control_Field();
                }
                else
                {
                    this.Show();
                }   
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields.....!!!", "Fill The Field Completely", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GVObj.Con_Close();
        }
        #endregion

        #region Gridview Cell Click Event Code
        private void dgv_Stock_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string W = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Stock_Data.Rows[e.RowIndex];
                txt_ID.Text = row.Cells[0].Value.ToString();
                txt_Category.Text = row.Cells[1].Value.ToString();
                txt_Product_Name.Text = row.Cells[2].Value.ToString();
                txt_Watts.Text = row.Cells[3].Value.ToString();
                txt_Current_Stock.Text = row.Cells[6].Value.ToString();

                W = (Convert.ToInt32(txt_Watts.Text.Remove(txt_Watts.Text.Length - 1))).ToString();
                txt_Watts.Text = W;
            }
        }
        #endregion

        #region Clear Button Code
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are You Sure Data Clear All Text Box", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                Clear_Control_Field();
            }
            else
            {
                this.Show();
            }
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

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
    public partial class Frm_Update_Product : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Update_Product()
        {
            InitializeComponent();
        }
        private void Enabled_False()
        {
            txt_ID.Enabled = false;
            dtp_Date.Enabled = false;
            txt_Category.Enabled = false;
            txt_Product_Name.Enabled = false;
            cmb_Distributor.Enabled = false;
            txt_Watt.Enabled = false;
           
        }
        private void Enabled_True()
        {
            txt_Unit_Price.Enabled = true;
            txt_Purchase_Price.Enabled = true;
            txt_Warranty.Enabled = true;

        }
        //#region Clear Control Field
        void clear_Control_All_Field()
        {
            txt_ID.Text = "";
            dtp_Date.Text = "";
            txt_Category.Text = "";
            txt_Product_Name.Text = "";
            cmb_Distributor.SelectedIndex = -1;
            txt_Watt.Clear();
            txt_Unit_Price.Clear();
            txt_Purchase_Price.Clear();
            txt_Warranty.Clear();
        }
        //#Endregion
        private void Fill_Gridview_Code()
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select MPD.Main_Product_ID,MPD.Date,MPD.Category,MPD.Product_Name,MPD.Distributor_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Warrenty from Main_Product_Details_db MPD INNER JOIN Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID", GVObj.con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dgv_Data.DataSource = dt;
            GVObj.Con_Close();
        }
        private void Frm_Update_Product_Load(object sender, EventArgs e)
        {
            Fill_Gridview_Code();
            Enabled_False();
            //GVObj.FillDataGridView("Select * from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID ", dgv_Data);
        }
        private void cb_Searchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            txt_Search.Enabled = true;
            txt_Search.Focus();
        }
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
            {
                GVObj.FillDataGridView("Select MPD.Main_Product_ID,MPD.Date,MPD.Category,MPD.Product_Name,MPD.Distributor_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Warrenty from Main_Product_Details_db MPD INNER JOIN Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID", dgv_Data);
            }
            if (cb_Searchby.Text == "Product ID")
            {
                GVObj.FillDataGridView("Select MPD.Main_Product_ID,MPD.Date,MPD.Category,MPD.Product_Name,MPD.Distributor_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Warrenty from Main_Product_Details_db MPD INNER JOIN Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID where MPD.Main_Product_ID like " + txt_Search.Text + "", dgv_Data);
            }
            if (cb_Searchby.Text == "Category")
            {
                GVObj.FillDataGridView("Select MPD.Main_Product_ID,MPD.Date,MPD.Category,MPD.Product_Name,MPD.Distributor_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Warrenty from Main_Product_Details_db MPD INNER JOIN Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID where MPD.Category like '" + txt_Search.Text + "%'", dgv_Data);
            }
            if (cb_Searchby.Text == "Product Name")
            {
                GVObj.FillDataGridView("Select MPD.Main_Product_ID,MPD.Date,MPD.Category,MPD.Product_Name,MPD.Distributor_Name,SPD.Watts,SPD.Unit_Price,SPD.Purchase_Price,SPD.Warrenty from Main_Product_Details_db MPD INNER JOIN Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID where MPD.Product_Name like '" + txt_Search.Text + "%'", dgv_Data);
            }
        }
        //#region Grid Cell Click Code
        private void dgv_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Data.Rows[e.RowIndex];
                txt_ID.Text = row.Cells[0].Value.ToString();
                dtp_Date.Text = row.Cells[1].Value.ToString();
                txt_Category.Text = row.Cells[2].Value.ToString();
                txt_Product_Name.Text = row.Cells[3].Value.ToString();
                cmb_Distributor.Text = row.Cells[4].Value.ToString();
                txt_Watt.Text = row.Cells[5].Value.ToString();
                txt_Unit_Price.Text = row.Cells[6].Value.ToString();
                txt_Purchase_Price.Text = row.Cells[7].Value.ToString();
                txt_Warranty.Text = row.Cells[8].Value.ToString();
            }
        }
        //#endregion

        //#region Keypress Handling
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
        //#Endreion

        //#region Keydown Handling Code
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
                btn_Update.Focus();
            }
        }
        //#region End
        //#region Update Button Code
        private void btn_Update_Click(object sender, EventArgs e)
        {
            decimal Purchase_Price = 0;
            if (txt_Purchase_Price.Text != "")
            {
                Purchase_Price = Convert.ToDecimal(txt_Purchase_Price.Text);
            }

            GVObj.Con_Open();
            if (txt_ID.Text != "" && txt_Category.Text != "" && txt_Product_Name.Text != "" && cmb_Distributor.Text != "" && txt_Watt.Text != "" && txt_Unit_Price.Text != "" && txt_Warranty.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are You Updated Record Successfully", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    //And MP.Category = '" + cmb_Category.Text + "' AND MP.Product_Name = '" + cmb_Product_Name.Text + "'
                    SqlCommand cmd = new SqlCommand("Update Sub_Product_Details_db SET Unit_Price=" + Convert.ToDecimal(txt_Unit_Price.Text) + ",Purchase_Price=" + Purchase_Price + ",Warrenty= '" + txt_Warranty.Text + "' where Main_Product_ID = " + txt_ID.Text + "", GVObj.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Update Successfully", "Success", MessageBoxButtons.OK);
                    Fill_Gridview_Code();
                    clear_Control_All_Field();
                    cmd.Dispose();
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
        //#region end
        //#Start region Clear Control Code
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Are You Sure Clear Data", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(R == DialogResult.Yes)
            {
                clear_Control_All_Field();
            }
            else
            {
                this.Show();
            }
        }
        //#region End
        //#region Exit Button Code
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
        //#region end
    }
}

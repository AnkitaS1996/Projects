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
    public partial class Frm_Update_Category : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Update_Category()
        {
            InitializeComponent();
        }
        private void Enable_True()
        {
            txt_Category.Enabled = true;
            txt_Product_Name.Enabled = true;
        }
        private void Enabled_False()
        {
            txt_Category.Enabled = false;
            txt_Product_Name.Enabled = false;
        }
        private void Data_Clear_Control()
        {
            txt_PID.Clear();
            txt_Category.Clear();
            txt_Product_Name.Clear();  
        }
        private void Frm_Update_Category_Load(object sender, EventArgs e)
        {
            txt_PID.Enabled = false;
            GVObj.FillDataGridView("Select * from Category_db", dgv_Data);
        }
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
            {
                GVObj.FillDataGridView("Select * from Category_db", dgv_Data);
            }
            if (cmb_SearchBy.Text == "Product ID")
            {
                GVObj.FillDataGridView("Select * from Category_db where Category_ID like '" + txt_Search.Text + "'", dgv_Data);
            }
            if (cmb_SearchBy.Text == "Category")
            {
                GVObj.FillDataGridView("Select * from Category_db where Category like '" + txt_Search.Text + "%'", dgv_Data);
            }
            if (cmb_SearchBy.Text == "Product Name")
            {
                GVObj.FillDataGridView("Select * from Category_db where Product_Name like '" + txt_Search.Text + "%'", dgv_Data);
            }
        }
        private void cmb_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            txt_Search.Enabled = true;
            txt_Search.Focus();
        }
        private void dgv_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Data.Rows[e.RowIndex];
                txt_PID.Text = row.Cells[0].Value.ToString();
                txt_Category.Text = row.Cells[1].Value.ToString();
                txt_Product_Name.Text = row.Cells[2].Value.ToString();
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            if(txt_PID.Text != "" && txt_Category.Text != "" && txt_Product_Name.Text != "")
            {
                DialogResult Result = MessageBox.Show("Are You Update Record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(Result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Update Category_db SET Category = '" + txt_Category.Text + "',Product_Name = '" + txt_Product_Name.Text + "' where Category_ID = " + txt_PID.Text + "");
                    cmd.Connection = GVObj.con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Update Successfully", "Success", MessageBoxButtons.OK);
                    cmd.Dispose();
                    GVObj.FillDataGridView("Select * from Category_db",dgv_Data);
                    Data_Clear_Control();
                }
                else
                {
                    this.Show();
                }
            }
            GVObj.Con_Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are You Clear All Text Box", "Clear Text", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result1 == DialogResult.Yes)
            {
                Data_Clear_Control();
            }
            else
            {
                this.Show();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            if (txt_PID.Text != "" && txt_Category.Text != "" && txt_Product_Name.Text != "")
            {
                DialogResult Result = MessageBox.Show("Are You Delete Record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Delete from Category_db where Category_ID = " + txt_PID.Text + "");
                    cmd.Connection = GVObj.con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Delete Successfully", "Success", MessageBoxButtons.OK);
                    cmd.Dispose();
                    GVObj.FillDataGridView("Select * from Category_db", dgv_Data);
                    Data_Clear_Control();
                }
                else
                {
                    this.Show();
                }
            }
            GVObj.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Refresh Clear All Text Box", "Clear Text", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Data_Clear_Control();
            }
            else
            {
                this.Show();
            }
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

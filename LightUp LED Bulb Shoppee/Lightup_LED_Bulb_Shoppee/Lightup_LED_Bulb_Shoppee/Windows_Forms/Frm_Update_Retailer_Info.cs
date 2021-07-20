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
    public partial class Frm_Update_Retailer_Info : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Update_Retailer_Info()
        {
            InitializeComponent();
        }

        #region Fill Gridview Code
        private void Fill_Gridview_Code()
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select * from Retailer_Details_db", GVObj.con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dgv_View_Data.DataSource = dt;
            GVObj.Con_Close();
        }
        #endregion

        #region Enabled True Code
        private void Enabled_True()
        {
            //txt_Retailer_ID.Enabled = true;
            txt_Name.Enabled = true;
            dtp_Date.Enabled = true;
            txt_M_No.Enabled = true;
            txt_Alter_No.Enabled = true;
            txt_Addhar_No.Enabled = true;
            txt_Address.Enabled = true;
            txt_PAN_No.Enabled = true;
            txt_Note.Enabled = true;
        }
        #endregion

        #region Enabled False code
        private void Enabled_False()
        {
            //txt_Retailer_ID.Enabled = false;
            txt_Name.Enabled = false;
            dtp_Date.Enabled = false;
            txt_M_No.Enabled = false;
            txt_Alter_No.Enabled = false;
            txt_Addhar_No.Enabled = false;
            txt_Address.Enabled = false;
            txt_PAN_No.Enabled = false;
            txt_Note.Enabled = false;
        }
        #endregion

        #region Clear Control All Field
        private void Clear_Control()
        {
            txt_Retailer_ID.Text = "";
            txt_Name.Text = "";
            dtp_Date.Text = "";
            txt_M_No.Clear();
            txt_Alter_No.Clear();
            txt_PAN_No.Clear();
            txt_Address.Clear();
            txt_Addhar_No.Clear();
            txt_Note.Clear();
        }
        #endregion

        #region Update Retailer Code
        private void Frm_Update_Retailer_Info_Load(object sender, EventArgs e)
        {
            Fill_Gridview_Code();
        }
        #endregion

        #region KeyPress Event Handling
        private void txt_M_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txt_Alter_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txt_Addhar_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.CapsLock || e.KeyChar == (char)Keys.ShiftKey))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region KeyPress Event Handling
        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_Date.Focus();
            }
        }
        private void dtp_Date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_M_No.Focus();
            }
        }
        private void txt_M_No_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Alter_No.Focus();
            }
        }
        private void txt_Alter_No_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PAN_No.Focus();
            }
        }
        private void txt_PAN_No_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Address.Focus();
            }
        }
        private void txt_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Addhar_No.Focus();
            }
        }
        private void txt_Addhar_No_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Note.Focus();
            }
        }
        private void txt_Note_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Update.Focus();
            }
        }
        #endregion

        #region Search Button Code
        private void btn_Search_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            Enabled_True();
            txt_Retailer_ID.Enabled = false;

            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select * From Retailer_Details_db where Retailer_ID = " + Convert.ToInt32(txt_Retailer_ID.Text) + "", GVObj.con);
            var Obj = cmd.ExecuteReader();

            if (Obj.Read())
            {
                txt_Name.Text = Obj["Name"].ToString();
                dtp_Date.Text = Obj["Date"].ToString();
                txt_M_No.Text = Obj["Mobile_No"].ToString();
                txt_Alter_No.Text = Obj["Alter_No"].ToString();
                txt_PAN_No.Text = Obj.GetString(Obj.GetOrdinal("Pan_No")).ToString();
                txt_Address.Text = Obj.GetString(Obj.GetOrdinal("Address")).ToString();
                txt_Addhar_No.Text = Obj["Addhar_No"].ToString();
                txt_Note.Text = Obj.GetString(Obj.GetOrdinal("Note")).ToString();

                MessageBox.Show("Record Search Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Invalid ID There is No Record Please Enter Crrect ID", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Retailer_ID.Enabled = true;
                txt_Retailer_ID.Clear();
                Enabled_False();
            }
            GVObj.Con_Close();
        }
        #endregion

        #region Gridview Date Cellclick Event Handling Code
        private void dgv_View_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Enabled_True();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_View_Data.Rows[e.RowIndex];
                txt_Retailer_ID.Text = row.Cells[0].Value.ToString();
                txt_Name.Text = row.Cells[1].Value.ToString();
                dtp_Date.Text = row.Cells[2].Value.ToString();
                txt_M_No.Text = row.Cells[3].Value.ToString();
                txt_Alter_No.Text = row.Cells[4].Value.ToString();
                txt_PAN_No.Text = row.Cells[5].Value.ToString();
                txt_Address.Text = row.Cells[6].Value.ToString();
                txt_Addhar_No.Text = row.Cells[7].Value.ToString();
                txt_Note.Text = row.Cells[8].Value.ToString();
                txt_Retailer_ID.Enabled = false;    
            }
        }
        #endregion

        #region Clear Control Code
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are You Clear TextBox", "Clear Textbox", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result == DialogResult.Yes)
            {
                Clear_Control();
                Enabled_False();
                txt_Retailer_ID.Enabled = true;
            }
            else
            {
                this.Show();
                txt_Retailer_ID.Enabled = false;
            }
        }
        #endregion

        #region Update Button Code
        private void btn_Update_Click(object sender, EventArgs e)
        {
            double Alter_MNO = 0;
            string Note = "";
            if (txt_Alter_No.Text != "")
            {
                Alter_MNO = Convert.ToDouble(txt_Alter_No.Text);
            }
            if (txt_Note.Text != "")
            {
                Note = txt_Note.Text;
            }
            GVObj.Con_Open();
            if (txt_Name.Text != "" && txt_M_No.Text != "" && txt_PAN_No.Text != "" && txt_Address.Text != "" && txt_Addhar_No.Text != "")
            {
                DialogResult result = MessageBox.Show("Are You Update Record", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd1 = new SqlCommand("Update Retailer_Details_db SET Name = '" + txt_Name.Text + "',Date = @date,Mobile_No = " + txt_M_No.Text + ",Alter_No = " + Alter_MNO + ",Pan_No = '" + txt_PAN_No.Text + "',Address = '" + txt_Address.Text + "',Addhar_No = " + txt_Addhar_No.Text + ",Note = '" + txt_Note.Text + "' where Retailer_ID = " + txt_Retailer_ID.Text + " ");
                    cmd1.Parameters.Add("@date", SqlDbType.Date).Value = dtp_Date.Text;
                    cmd1.Connection = GVObj.con;
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Update Record Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Fill_Gridview_Code();
                    cmd1.Dispose();
                    Clear_Control();
                    Enabled_False();
                    txt_Retailer_ID.Enabled = true;
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("1st Fill All field", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GVObj.Con_Close();
        }
        #endregion

        #region Delete Button Code
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            DialogResult dialogResult = MessageBox.Show("Are You Sure Delete Data", "Records", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Delete From Retailer_Details_db where Retailer_ID = " + txt_Retailer_ID.Text + "");
                cmd.Connection = GVObj.con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Fill_Gridview_Code();
                Clear_Control();
                Enabled_False();
            }
            else
            {
                this.Show();
            }
            txt_Retailer_ID.Enabled = true;
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
    }
}

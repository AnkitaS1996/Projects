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
    public partial class Frm_Update_Distributors : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Update_Distributors()
        {
            InitializeComponent();
        }
        private void Clear_Controls()
        {
            txt_Distributor_ID.Clear();
            txt_Name.Clear();
            dtp_Tie_Up_Date.Text = "";
            txt_Mob_No1.Text = "";
            txt_Mob_No2.Text = "";
            txt_Address.Text = "";
            txt_Email_ID.Text = "";
            txt_Addhar_No.Text = "";
            txt_PanNo.Text = "";
            txt_Brand.Text = "";
        }
        void Enabled_True()
        {
            txt_Distributor_ID.Enabled = true;
            txt_Name.Enabled = true;
            dtp_Tie_Up_Date.Enabled = true;
            txt_Mob_No1.Enabled = true;
            txt_Mob_No2.Enabled = true;
            txt_Address.Enabled = true;
            txt_Email_ID.Enabled = true;
            txt_Addhar_No.Enabled = true;
            txt_PanNo.Enabled = true;
            txt_Brand.Enabled = true;
        }
        void Enabled_False()
        {
            //txt_Distributor_ID.Enabled = false;
            txt_Name.Enabled = false;
            dtp_Tie_Up_Date.Enabled = false;
            txt_Mob_No1.Enabled = false;
            txt_Mob_No2.Enabled = false;
            txt_Address.Enabled = false;
            txt_Email_ID.Enabled = false;
            txt_Addhar_No.Enabled = false;
            txt_PanNo.Enabled = false;
            txt_Brand.Enabled = false;
        }
        private void Frm_Update_Distributors_Load(object sender, EventArgs e)
        {
            Enabled_False();
            txt_Distributor_ID.Enabled = true;
        }
        //Search Button Coding
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Enabled_True();
            txt_Distributor_ID.Enabled = false;

            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select * From Distributor_db where ID = " + Convert.ToInt32(txt_Distributor_ID.Text) + "",GVObj.con);
            var Obj = cmd.ExecuteReader();

            if(Obj.Read())
            {
                txt_Name.Text = Obj["Name"].ToString();
                dtp_Tie_Up_Date.Text = Obj["Tie_Up_Date"].ToString();
                txt_Mob_No1.Text = Obj["Mobile_No1"].ToString();
                txt_Mob_No2.Text = Obj["Mobile_No2"].ToString();
                txt_Address.Text = Obj.GetString(Obj.GetOrdinal("Address")).ToString();
                txt_Email_ID.Text = Obj.GetString(Obj.GetOrdinal("Email_ID")).ToString();
                txt_Addhar_No.Text = Obj["Addhar_No"].ToString();
                txt_PanNo.Text = Obj["PAN_No"].ToString();
                txt_Brand.Text = Obj.GetString(Obj.GetOrdinal("Brand")).ToString();

                MessageBox.Show("Record Search Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Invalid ID There is No Record Please Enter Crrect ID", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Distributor_ID.Enabled = true;
                txt_Distributor_ID.Clear();
                Enabled_False();
            }
            GVObj.Con_Close();
        }
        //region End

        //Update button Code
        private void btn_Update_Click(object sender, EventArgs e)
        {
            double Mobile_No2 = 0;
            string Email = "";
            if (txt_Mob_No2.Text != "")
            {
                Mobile_No2 = Convert.ToDouble(txt_Mob_No2.Text);
            }
            if (txt_Email_ID.Text != "")
            {
                Email = txt_Email_ID.Text;
            }
            GVObj.Con_Open();

            if(txt_Name.Text != "" && txt_Mob_No1.Text != "" && txt_Address.Text != "" && txt_Addhar_No.Text != "" && txt_PanNo.Text != "" && txt_Brand.Text != "")
            {
                DialogResult result = MessageBox.Show("Are You Update Record", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    SqlCommand cmd1 = new SqlCommand("Update Distributor_db SET Name = '" + txt_Name.Text + "',Tie_Up_Date = '" + dtp_Tie_Up_Date.Text + "',Mobile_No1 = " + txt_Mob_No1.Text + ",Mobile_No2 = " + Mobile_No2 + ",Address = '" + txt_Address.Text + "',Email_ID = '" + Email + "',Addhar_No = " + txt_Addhar_No.Text + ",PAN_No = '" + txt_PanNo.Text + "',Brand = '" + txt_Brand.Text + "' where ID = " + txt_Distributor_ID.Text + " ");
                    cmd1.Connection = GVObj.con;
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Update Record Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd1.Dispose();
                    Clear_Controls();
                    Enabled_False();
                    txt_Distributor_ID.Enabled = true;
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
        //End Region

        //#region Delete Button Code
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            DialogResult dialogResult = MessageBox.Show("Are You Sure Delete Data", "Records", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Delete From Distributor_db where ID = " + txt_Distributor_ID.Text + "");
                cmd.Connection = GVObj.con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
                Enabled_False();
            }
            else
            {
                this.Show();
            }
            txt_Distributor_ID.Enabled = true;
            GVObj.Con_Close();
        }
        //#End Region

        //#region KeyDown Event Handling
        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_Tie_Up_Date.Focus();
            }
        }
        private void dtp_Tie_Up_Date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Mob_No1.Focus();
            }
        }

        private void txt_Mob_No1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Mob_No2.Focus();
            }
        }
        private void txt_Mob_No2_KeyDown(object sender, KeyEventArgs e)
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
                txt_Email_ID.Focus();
            }
        }
        private void txt_Email_ID_KeyDown(object sender, KeyEventArgs e)
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
                txt_PanNo.Focus();
            }
        }
        private void txt_PanNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Brand.Focus();
            }
        }
        private void txt_Brand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Update.Focus();
            }
        }
        //#region End

        //#region KeyPress Handling Event
        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.CapsLock || e.KeyChar == (char)Keys.ShiftKey || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txt_Mob_No2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txt_Mob_No1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Distributor_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are You Refresh TextBox", "Refresh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(Result == DialogResult.Yes)
            {
                Clear_Controls();
                Enabled_False();
                txt_Distributor_ID.Enabled = true;
            }
            else
            {
                this.Show();
                txt_Distributor_ID.Enabled = false;
            }
        }
        //#region End
    }
}

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
    public partial class Frm_User_Managements : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        int Cnt = 0;
        string Password = "";
        public Frm_User_Managements()
        {
            InitializeComponent();
        }

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

        #region Add New User Code
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            SqlCommand Cmd = new SqlCommand("Select ID From Login_db Where Username = '" + txt_Username.Text + "'", GVObj.con);
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            if(Cnt > 0)
            {
                MessageBox.Show("Username Already Use..Use Different Username", "Username Changed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txt_Username.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("First Fill Up Username And Password..", "Fill Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txt_Password.Text == txt_Confirm_Password.Text)
            {
                SqlCommand cmd1 = new SqlCommand("Insert into Login_db Values ('" + txt_Username.Text + "','" + txt_Confirm_Password.Text + "')", GVObj.con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Record Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd1.Dispose();
                Cmd.Dispose();
                txt_Username.Text = "";
                txt_Password.Text = "";
                txt_Confirm_Password.Text = "";
            }
            else
            {
                MessageBox.Show("Password Does not MAtch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GVObj.Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are You Sure Data Entered Will be Lost", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
        #endregion

        #region Change Password Code
        private void btn_Update_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            if (txt_CP_Username.Text == "" || txt_Current_Password.Text == "" || txt_New_Password.Text == "")
            {
                MessageBox.Show("First Fill The Username And Password", "Fill The Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand Cmd2 = new SqlCommand("Select * from Login_db where Username = '" + txt_CP_Username.Text + "'", GVObj.con);
                Cnt = Convert.ToInt32(Cmd2.ExecuteNonQuery());
                if (Cnt == 0)
                {
                    MessageBox.Show("Inalid Username", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var obj = Cmd2.ExecuteReader();
                    if (obj.Read())
                    {
                        Password = obj.GetString(obj.GetOrdinal("Password"));
                    }
                    obj.Dispose();
                    Cmd2.Dispose();
                    if (txt_Current_Password.Text == Password)
                    {
                        SqlCommand cmd3 = new SqlCommand("Update Login_db Set Password = '" + txt_New_Password.Text + "' where Username = '" + txt_CP_Username.Text + "'", GVObj.con);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Password Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_CP_Username.Text = "";
                        txt_Current_Password.Text = "";
                        txt_New_Password.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Password is Not Matched", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            GVObj.Con_Close();
        }
        private void btn_Close_CP_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Are You Sure Data Entered Will be Lost", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        #endregion

        #region Delete User code
        private void btn_Delete_User_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            if(txt_Delete_Username.Text == "" || txt_Admin_Password.Text == "")
            {
                MessageBox.Show("Fill Details Username And Password", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(txt_Delete_Username.Text == "Admin")
            {
                MessageBox.Show("Admin User Can't Be Deleted", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd4 = new SqlCommand("Select * from Login_db where Username = 'Admin'",GVObj.con);
                var obj = cmd4.ExecuteReader();
                string Admin_Password = "";

                if(obj.Read())
                {
                    Admin_Password = obj.GetString(obj.GetOrdinal("Password"));
                }
                obj.Dispose();
                cmd4.Dispose();
                if(txt_Admin_Password.Text == Admin_Password)
                {
                    SqlCommand Cmd5 = new SqlCommand("Delete from Login_db where Username = '" + txt_Delete_Username.Text + "'", GVObj.con);
                    Cmd5.ExecuteNonQuery();
                    MessageBox.Show("Delete User Successfully", "User Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Delete_Username.Text = "";
                    txt_Admin_Password.Text = "";
                }
                else
                {
                    MessageBox.Show(" Admin Password Didnot Match ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            GVObj.Con_Close();
        }

        private void btn_Close_Dlt_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are You Sure Data Entered Will be Lost", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        #region Checkbox CheckedChanged Code
        private void chkb_Show_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb_Show_Pass.Checked)
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
            }
        }
        private void chkb_Confirm_Pass_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb_Confirm_Pass_Show.Checked)
            {
                txt_Confirm_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Confirm_Password.PasswordChar = '*';
            }
        }
        private void chkb_Current_Pass_show_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb_Current_Pass_show.Checked)
            {
                txt_Current_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Current_Password.PasswordChar = '*';
            }
        }
        private void chkb_New_Pass_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb_New_Pass_Show.Checked)
            {
                txt_New_Password.PasswordChar = '\0';
            }
            else
            {
                txt_New_Password.PasswordChar = '*';
            }
        }
        private void chkb_Admin_Pass_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb_Admin_Pass_Show.Checked)
            {
                txt_Admin_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Admin_Password.PasswordChar = '*';
            }
        }
        #endregion
    }
}

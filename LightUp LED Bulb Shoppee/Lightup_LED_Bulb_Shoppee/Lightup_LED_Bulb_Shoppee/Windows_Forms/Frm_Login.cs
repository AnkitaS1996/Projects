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
    public partial class Frm_Login : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Login()
        {
            InitializeComponent();
        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txt_Username.Focus();
            lbl_Note.Visible = true;
            lbl_Note.Text = "Please Enter Username And Password";
            lbl_Note.ForeColor = Color.Green;
        }
        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            txt_Username.Focus();
            txt_Password.Enabled = true;
        }
        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
        //#KeyDown code Event Handling
        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Password.Focus();
            }
        }
        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Submit.Focus();
            }
        }

        //Clear Control Code
        private void Clear_Control()
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_Password.Enabled = false;
            btn_Submit.Enabled = false;
            txt_Username.Focus();
        }
        
        //#Submit Button Code
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select ID From Login_db where Username = '" + txt_Username.Text + "' And Password = '" + txt_Password.Text + "'",GVObj.con);
            if(Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                lbl_Note.Visible = false;
                Code_Class_Global_Vars.Uname = txt_Username.Text;
                
                MessageBox.Show("Login Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MDI_LED_Bulb obj = new MDI_LED_Bulb();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Visible = true;
                lbl_Note.Text = "Invalid Username And Password";
                lbl_Note.ForeColor = Color.Red;
            }
        }

        //# Exit Application Code
        private void pb_Exit_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are You Sure Close This Application???...", "Application Close", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(Result == DialogResult.Yes)
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

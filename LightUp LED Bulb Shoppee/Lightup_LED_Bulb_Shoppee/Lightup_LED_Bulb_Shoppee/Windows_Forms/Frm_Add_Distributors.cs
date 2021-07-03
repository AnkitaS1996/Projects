using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightup_LED_Bulb_Shoppee.Windows_Forms
{
    public partial class Frm_Add_Distributors : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Add_Distributors()
        {
            InitializeComponent();
        }
        private void Clear_Controls()
        {
            Auto_Increment();
            txt_Name.Clear();
            dtp_Tie_UPDate.Text = "";
            txt_Mob_No1.Text = "";
            txt_Mob_No2.Text = "";
            rbtn_Female.Checked = false;
            rbtn_Male.Checked = false;
            txt_Address.Text = "";
            txt_Email_ID.Text = "";
            txt_Addhar_No.Text = "";
            txt_PanNo.Text = "";
            txt_Brand.Text = "";
        }
        private void Auto_Increment()
        {
            txt_Distributor_ID.Text = Convert.ToString(GVObj.AutoIncrement("select Count(ID) from Distributor_db", "Select Max(ID) from Distributor_db", 101));
        }
        private void Frm_Add_Distributors_Load(object sender, EventArgs e)
        {
            txt_Distributor_ID.Enabled = false;
            Auto_Increment();
            txt_Name.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Refresh Clear All Text Box", "Clear Text", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(result == DialogResult.Yes)
            {
                Clear_Controls();
            }
            else
            {
                this.Show();
            }
        }
        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.CapsLock || e.KeyChar == (char)Keys.ShiftKey))
            {
                e.Handled = true;
            }
        }

        private void txt_Mob_No1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txt_Mob_No2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

        }
        //#Endregion
        private void txt_Addhar_No_TextChanged(object sender, EventArgs e)
        {
            if(txt_Addhar_No.TextLength > 12)
            {
                DialogResult result = MessageBox.Show("Invalid Addharcard Number..Please Enter Valid Addhar card Number","Please Valid Addhar Card Number",MessageBoxButtons.OK);
                if(result == DialogResult.OK)
                {
                    txt_Addhar_No.Text = "";
                    MessageBox.Show("Plase Valid 12 Digits Addhar Card Number");
                }
            }

        }

        //#region KeyPress Event Handling
        private void txt_Addhar_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        //#Save Button Code
        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        //#region Keydown Event Hwndling
        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_Tie_UPDate.Focus();
            }
        }

        private void dtp_Tie_UPDate_KeyDown(object sender, KeyEventArgs e)
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
                rbtn_Male.Focus();
            }
        }

        private void rbtn_Male_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rbtn_Female.Focus();
            }
        }

        private void rbtn_Female_KeyDown(object sender, KeyEventArgs e)
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
            if(e.KeyCode == Keys.Enter)
            {
                txt_Brand.Focus();
            }
        }

        private void txt_Brand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Save.Focus();
            }
        }
        //#End Region
    }
}
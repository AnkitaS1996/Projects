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

namespace Lightup_LED_Bulb_Shoppee
{
    public partial class Frm_Add_Retailer_Info : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Add_Retailer_Info()
        {
            InitializeComponent();
        }

        #region AutoIncrement Code
        private void Auto_Increment()
        {
            txt_Retailer_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(Retailer_ID) from Retailer_Details_db", "Select Max(Retailer_ID) from Retailer_Details_db", 1001));
        }
        #endregion

        #region Clear Control All Field Code
        private void Clear_Control_AllField()
        {
            Auto_Increment();
            txt_Name.Text = "";
            dtp_Date.Text = "";
            txt_Name.Clear();
            txt_M_No.Clear();
            txt_Alter_No.Clear();
            txt_PAN_No.Clear();
            txt_Address.Clear();
            txt_Addhar_No.Clear();
            txt_Note.Clear();
            txt_Name.Focus();
        }
        #endregion

        #region From Add Retailer Information Loading Code
        private void Frm_Add_Retailer_Info_Load(object sender, EventArgs e)
        {
            txt_Retailer_ID.Enabled = false;
            Auto_Increment();
            txt_Name.Focus();
        }
        #endregion

        #region Keydown Event Handling Code
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
            if (e.KeyCode == Keys.Enter)
            {
               btn_Save.Focus();
            }
        }
        #endregion

        #region Keypress Event Handling code
        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.CapsLock || e.KeyChar == (char)Keys.ShiftKey))
            {
                e.Handled = true;
            }
        }
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
        #endregion

        #region Save Button Code
        private void btn_Save_Click(object sender, EventArgs e)
        {
            double Alter_MNO = 0;
            string Note = "";
            if(txt_Alter_No.Text != "")
            {
                Alter_MNO = Convert.ToDouble(txt_Alter_No.Text);
            }
            if(txt_Note.Text != "")
            {
                Note = txt_Note.Text;
            }
            GVObj.Con_Open();
            if(txt_Retailer_ID.Text != "" && txt_Name.Text != "" && txt_M_No.Text != "" && txt_PAN_No.Text != "" && txt_Address.Text != "" && txt_Addhar_No.Text != "")
            {
                DialogResult result = MessageBox.Show("Are You Sure Record Save Data Successfully..!!", "Record Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Insert into Retailer_Details_db Values(@RetailerID,@Name,@Date," + txt_M_No.Text + "," + Alter_MNO + ",'" + txt_PAN_No.Text + "','" + txt_Address.Text + "'," + txt_Addhar_No.Text + ",'" + Note + "')", GVObj.con);
                    cmd.Parameters.Add("@RetailerID", SqlDbType.Int).Value = txt_Retailer_ID.Text;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txt_Name.Text;
                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Date.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Control_AllField();
                }
                else
                {
                    this.Show();
                }         
            }
            else
            {
                MessageBox.Show("First Fill All The Field", "First Data field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GVObj.Con_Close();
        }
        #endregion

        #region Clear Button Code
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure Clear All Data..!!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Clear_Control_AllField();
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

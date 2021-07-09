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
    public partial class Frm_Add_Category : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Add_Category()
        {
            InitializeComponent();
        }
        void Clear_Controls()
        {
            Auto_Increment();
            txt_Category.Clear();
            txt_Product_Name.Clear();
        }
        void Auto_Increment()
        {
            txt_PID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(Category_ID) from Category_db", "Select Max(Category_ID) from Category_db",101));
        }
        void Bind_Data_Gridview()
        {
            GVObj.Con_Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Category_db",GVObj.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Data.DataSource = dt;
            sda.Dispose();
            dt.Dispose();
            GVObj.Con_Close();
        }
        private void Frm_Add_Category_Load(object sender, EventArgs e)
        {
            txt_PID.Enabled = false;
            Auto_Increment();
            txt_Category.Focus();
            Bind_Data_Gridview();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            if(txt_PID.Text != "" && txt_Category.Text != "" && txt_Product_Name.Text != "")
            {
                DialogResult result = MessageBox.Show("Are You Sure Save The Data", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Insert into Category_db Values (" + txt_PID.Text + ",'" + txt_Category.Text + "','" + txt_Product_Name.Text + "')",GVObj.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bind_Data_Gridview();
                    Clear_Controls();
                    cmd.Dispose();
                }
                else
                {
                    this.Show();
                }
            }

            GVObj.Con_Close();
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

        private void txt_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Product_Name.Focus();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Refresh Clear All Text Box", "Clear Text", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Clear_Controls();
            }
            else
            {
                this.Show();
            }
        }
    }
}

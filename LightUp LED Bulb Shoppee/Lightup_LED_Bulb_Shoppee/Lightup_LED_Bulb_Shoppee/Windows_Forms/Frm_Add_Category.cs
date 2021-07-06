﻿using System;
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
    public partial class Frm_Add_Category : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Add_Category()
        {
            InitializeComponent();
        }
        void Auto_Increment()
        {
            txt_PID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(Category_ID) from Category_db", "Select Max(Category_ID) from Category_db",101));
        }
        private void Frm_Add_Category_Load(object sender, EventArgs e)
        {
            Auto_Increment();
            txt_PID.Focus();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();

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

       
    }
}
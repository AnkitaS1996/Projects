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
    public partial class Frm_Accept_Payment : Form
    {
        public Frm_Accept_Payment()
        {
            InitializeComponent();
        }
        #region Exit Code
        private void pb_Exits_Click(object sender, EventArgs e)
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

        #region Accept Payment Page Load
        private void Frm_Accept_Payment_Load(object sender, EventArgs e)
        {
            txt_Total_Final_Bill.Enabled = false;
            txt_Total_Pay_Bill.Enabled = false;
            txt_Pending_Bills.Enabled = false;
        }
        #endregion


    }
}

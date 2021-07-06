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
    public partial class Frm_Retailer_Order : Form
    {
        public Frm_Retailer_Order()
        {
            InitializeComponent();
        }

        private void Frm_Retailer_Order_Load(object sender, EventArgs e)
        {
            txt_Cust_ID.Enabled = false;
        }

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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightup_LED_Bulb_Shoppee.Report_Forms
{
    public partial class Frm_Monthly_Add_Product_Reports : Form
    {
        public Frm_Monthly_Add_Product_Reports()
        {
            InitializeComponent();
        }

        private void Frm_Monthly_Add_Product_Reports_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

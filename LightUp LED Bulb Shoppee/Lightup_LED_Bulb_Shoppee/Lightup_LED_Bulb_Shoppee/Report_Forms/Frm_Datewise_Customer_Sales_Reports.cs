using Microsoft.Reporting.WinForms;
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

namespace Lightup_LED_Bulb_Shoppee.Report_Forms
{
    public partial class Frm_Datewise_Customer_Sales_Reports : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Datewise_Customer_Sales_Reports()
        {
            InitializeComponent();
        }

        private void Frm_Datewise_Customer_Sales_Reports_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void Display_Data()
        {
            GVObj.Con_Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from customer_Details_db where Created_Date >= @FromDate And Created_Date <= @ToDate", GVObj.con);
            cmd.Parameters.Add("@FromDate", SqlDbType.Date).Value = dtp_From_Date.Text;
            cmd.Parameters.Add("@ToDate", SqlDbType.Date).Value = dtp_To_Date.Text;
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            //return dt;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //cmd.ExecuteNonQuery();
            //DataSet1 ds = new DataSet1();
            //sda.Fill("DataSets_Product_Sales"ds);
            //sda.Fill("DataSet2",ds);
            ReportDataSource Customer_Report = new ReportDataSource("Customer_Sales_Report", dt);
            
            reportViewer1.LocalReport.ReportPath = @"F:\Ankita\C# Projects\LightUp LED Bulb Shoppee\Lightup_LED_Bulb_Shoppee\Lightup_LED_Bulb_Shoppee\Reports\Rpt_Datewise_Customer_Sales_Report.rdlc";
            reportViewer1.LocalReport.DataSources.Add(Customer_Report);
          
            reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            GVObj.Con_Close();

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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            Display_Data();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Display_Data();
        }
    }
}

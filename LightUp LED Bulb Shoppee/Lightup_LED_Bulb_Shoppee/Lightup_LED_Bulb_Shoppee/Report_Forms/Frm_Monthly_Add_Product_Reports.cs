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
    public partial class Frm_Monthly_Add_Product_Reports : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
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
        private void Display_Data()
        {
            GVObj.Con_Open();
            int C_Month = cmb_Month.SelectedIndex + 1;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select MPD.Main_Product_ID,MPD.Date,MPD.Category,MPD.Product_Name,MPD.Distributor_Name,SPD.Watts,SPD.Unit_Price,SPD.Warrenty,SPD.Current_Stock from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID Where Month(MPD.Date) = '" + C_Month + "'", GVObj.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            //return dt;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //cmd.ExecuteNonQuery();
            //DataSet1 ds = new DataSet1();
            //sda.Fill("DataSets_Product_Sales"ds);
            //sda.Fill("DataSet2",ds);
            ReportDataSource Main_Product_Details = new ReportDataSource("Dataset_Main_Product_Details", dt);
            ReportDataSource Sub_Product_Details = new ReportDataSource("Dataset_Sub_Product_Details", dt);
            reportViewer1.LocalReport.ReportPath = @"F:\Ankita\C# Projects\LightUp LED Bulb Shoppee\Lightup_LED_Bulb_Shoppee\Lightup_LED_Bulb_Shoppee\Reports\Rpt_Monthly_Product_Details.rdlc";
            reportViewer1.LocalReport.DataSources.Add(Main_Product_Details);
            reportViewer1.LocalReport.DataSources.Add(Sub_Product_Details);
            reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            GVObj.Con_Close();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            int C_Month = System.DateTime.Today.Month;
            cmb_Month.SelectedIndex = C_Month - 1;
            reportViewer1.Reset();
            Display_Data();
        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            Display_Data();
        }
    }
}

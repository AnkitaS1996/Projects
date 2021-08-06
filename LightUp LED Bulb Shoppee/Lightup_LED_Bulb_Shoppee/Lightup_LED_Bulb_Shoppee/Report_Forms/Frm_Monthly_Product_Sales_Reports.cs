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
    public partial class Frm_Monthly_Product_Sales_Reports : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Monthly_Product_Sales_Reports()
        {
            InitializeComponent();
        }
        private void DisplayReport()
        {
            GVObj.Con_Open();
            int C_Month = cmb_Month.SelectedIndex + 1;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select CPD.Customer_Product_ID,CD.Created_Date,CPD.Category,CPD.Product_Name,CPD.Watts,CPD.Unit_Price,CPD.Quantity,CPD.Total_Price from Customer_Details_db CD Inner Join Customer_Purchase_Details CPD ON CD.Customer_ID = CPD.Customer_ID Where Month(CD.Created_Date) = '" + C_Month + "'", GVObj.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            //return dt;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //cmd.ExecuteNonQuery();
            //DataSet1 ds = new DataSet1();
            //sda.Fill("DataSets_Product_Sales"ds);
            //sda.Fill("DataSet2",ds);
            ReportDataSource Product_Data = new ReportDataSource("DataSet_Product_Sales", dt);
            ReportDataSource Sales_Product = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.ReportPath = @"F:\Ankita\C# Projects\LightUp LED Bulb Shoppee\Lightup_LED_Bulb_Shoppee\Lightup_LED_Bulb_Shoppee\Reports\Rpt_Monthly_Product_Sales_Report.rdlc";
            reportViewer1.LocalReport.DataSources.Add(Product_Data);
            reportViewer1.LocalReport.DataSources.Add(Sales_Product);
            reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            GVObj.Con_Close();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            int C_Month = System.DateTime.Today.Month;
            cmb_Month.SelectedIndex = C_Month - 1;
            reportViewer1.Reset();
            DisplayReport();
        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            DisplayReport();
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

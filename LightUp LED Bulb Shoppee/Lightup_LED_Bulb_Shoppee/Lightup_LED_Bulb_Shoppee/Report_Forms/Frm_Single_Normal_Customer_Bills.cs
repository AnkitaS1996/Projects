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
    public partial class Frm_Single_Normal_Customer_Bills : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        public Frm_Single_Normal_Customer_Bills()
        {
            InitializeComponent();
        }

        private void Frm_Single_Normal_Customer_Bills_Load(object sender, EventArgs e)
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
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select CD.Customer_ID,CD.Created_Date,CD.Customer_Name,CD.Mobile_No,CPD.Category,CPD.Product_Name,CPD.Watts,CPD.Unit_Price,CPD.Quantity,CPD.Total_Price,CD.Total_Bills,CD.Discount,CD.GST,CD.Final_Bills From Customer_Details_db CD Inner Join Customer_Purchase_Details CPD ON CD.Customer_ID = CPD.Customer_ID where CD.Customer_ID = " + txt_Customer_ID.Text + "",GVObj.con);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            ReportDataSource customer_Details = new ReportDataSource("Dataset_Customer_Details", dt);
            ReportDataSource Purchase_Product = new ReportDataSource("Dataset_Customer_Sales_Details", dt);
            reportViewer1.LocalReport.ReportPath = @"F:\Ankita\C# Projects\LightUp LED Bulb Shoppee\Lightup_LED_Bulb_Shoppee\Lightup_LED_Bulb_Shoppee\Reports\Rpt_Single_Normal_Customer_Bill.rdlc";
            reportViewer1.LocalReport.DataSources.Add(customer_Details);
            reportViewer1.LocalReport.DataSources.Add(Purchase_Product);
            reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
           
            GVObj.Con_Close();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Display_Data();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            txt_Customer_ID.Clear();
        }
    }
}

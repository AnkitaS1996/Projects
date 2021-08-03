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
    public partial class Frm_Retailer_Order : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        DataTable DT = new DataTable();
        int Stock = 0;
        public Frm_Retailer_Order()
        {
            InitializeComponent();
        }

        #region AutoIncrement Code
        private void Auto_Increment()
        {
            txt_Order_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(Order_ID) from Retailer_Order_Details_db", "Select Max(Order_ID) from Retailer_Order_Details_db", 10001));
        }
        #endregion

        #region Enable False
        private void Enabled_False()
        {
            txt_Order_ID.Enabled = false;
            dtp_Date.Enabled = false;
            txt_Cust_Name.Enabled = false;
            txt_Mobile_No.Enabled = false;
            txt_Unit_Price.Enabled = false;
            txt_Total_Price.Enabled = false;
            txt_Remaining_Bills.Enabled = false;
        }
        #endregion

        #region Retailer Order Load Form
        private void Frm_Retailer_Order_Load(object sender, EventArgs e)
        {
            Create_Column();
            Enabled_False();
            txt_Total_Bill.Text = "0";
            //txt_Paid_Bills.Text = "0";
            //txt_Order_ID.Enabled = false;
            Bind_Combobox_Category_Data();
            Auto_Increment();
        }
        #endregion

        #region Clear Control Code
        private void Clear_Control_Product_Details()
        {
            cmb_Category.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            cmb_Watts.Text = "";
            txt_Unit_Price.Clear();
            txt_Quantity.Text = "";
            txt_Total_Price.Text = "";

        }
        private void Clear_Control_Customer_Details()
        {
            Auto_Increment();
            txt_Cust_ID.Text = "";
            dtp_Date.Text = "";
            txt_Cust_Name.Clear();
            txt_Mobile_No.Clear();
            txt_Total_Bill.Text = "0";
            txt_Discount.Text = "0.0";
            txt_GST.Text = "0.0";
            txt_Final_Bills.Text = "0"; 
            txt_Remaining_Bills.Text = "0";
            txt_Paid_Bills.Text = "0";
            DT.Rows.Clear();
            Clear_Control_Product_Details();
        }
        #endregion

        #region Create Column
        private void Create_Column()
        {
            //DataTable dt = new DataTable();
            DataColumn c1 = new DataColumn("Category", typeof(string));
            DataColumn c2 = new DataColumn("Product Name", typeof(string));
            DataColumn c3 = new DataColumn("Watts", typeof(string));
            DataColumn c4 = new DataColumn("Unit Price", typeof(decimal));
            DataColumn c5 = new DataColumn("Quantity", typeof(int));
            DataColumn c6 = new DataColumn("Total Price", typeof(decimal));
            DT.Columns.Add(c1);
            DT.Columns.Add(c2);
            DT.Columns.Add(c3);
            DT.Columns.Add(c4);
            DT.Columns.Add(c5);
            DT.Columns.Add(c6);
        }
        #endregion

        #region Bind Combobox code
        private void Bind_Combobox_Category_Data()
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select Distinct(Category) from Category_db", GVObj.con);
            var obj = cmd.ExecuteReader();
            while (obj.Read())
            {
                cmb_Category.Items.Add(obj["Category"].ToString());
            }
            obj.Dispose();
            cmd.Dispose();
            GVObj.Con_Close();
        }
        private void Bind_Product_Name_Combobox()
        {
            GVObj.Con_Open();
            SqlCommand cmd1 = new SqlCommand("Select (Product_Name) from Category_db where Category = '" + cmb_Category.Text + "'", GVObj.con);
            var obj = cmd1.ExecuteReader();
            while (obj.Read())
            {
                cmb_Product_Name.Items.Add(obj["Product_Name"].ToString());
            }
            cmd1.Dispose();
            obj.Dispose();
            GVObj.Con_Close();
        }
        #endregion

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

        #region Combobox SelectedIndexChanged Event Handling Code
        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Product_Name_Combobox();
        }
        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            SqlCommand cmd1 = new SqlCommand("Select SPD.Watts from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID where MPD.Category = '" + cmb_Category.Text + "' And MPD.Product_Name = '" + cmb_Product_Name.Text + "'", GVObj.con);
            /*SqlCommand cmd1 = new SqlCommand("SELECT Main_Product_ID FROM Main_Product_Details_db WHERE Category = '" + cmb_Category.Text + "' And Product_Name='" + cmb_Product_Name.Text + "'", GVObj.con);
             var obj = cmd1.ExecuteReader();
             while(obj.Read())
             {
                 ID = Convert.ToInt32(obj["Main_Product_ID"]);
             }
             cmd1.Dispose();
             obj.Dispose();*/

            //SqlCommand cmd2 = new SqlCommand("Select Watts from Sub_Product_Details_db where Main_Product_ID = " + ID + "",GVObj.con);
            var obj1 = cmd1.ExecuteReader();
            while (obj1.Read())
            {
                cmb_Watts.Items.Add(obj1["Watts"].ToString());
            }
            GVObj.Con_Close();
        }
        private void cmb_Watts_SelectedIndexChanged(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select SPD.Unit_Price from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID where MPD.Category = '" + cmb_Category.Text + "' And MPD.Product_Name = '" + cmb_Product_Name.Text + "' And SPD.Watts = '" + cmb_Watts.Text + "'", GVObj.con);
            //SqlCommand cmd = new SqlCommand("SELECT Unit_Price,Sub_Product_ID FROM Sub_Product_Details_db WHERE Watts='" + cmb_Watts.Text + "' AND Main_Product_ID = " + ID + "", GVObj.con);
            var obj = cmd.ExecuteReader();
            if (obj.Read())
            {
                txt_Unit_Price.Text = obj["Unit_Price"].ToString();
                //SPID = Convert.ToInt32(obj["Sub_Product_ID"]);
            }
            cmd.Dispose();
            obj.Dispose();
            GVObj.Con_Close();
        }

        #endregion

        #region Combobox And Textbox textchanged Code
        private void cmb_Category_TextChanged(object sender, EventArgs e)
        {
            cmb_Product_Name.Items.Clear();
            cmb_Product_Name.SelectedIndex = -1;
            cmb_Product_Name.Text = "";
            txt_Unit_Price.Clear();
        }

        private void cmb_Product_Name_TextChanged(object sender, EventArgs e)
        {
            cmb_Watts.Items.Clear();
            cmb_Watts.SelectedIndex = -1;
            cmb_Watts.Text = "";
            txt_Unit_Price.Clear();
        }

        private void cmb_Watts_TextChanged(object sender, EventArgs e)
        {
            txt_Unit_Price.Clear();
        }
        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("SELECT SPD.Current_Stock FROM Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID WHERE MPD.Category='" + cmb_Category.Text + "' AND MPD.Product_Name = '" + cmb_Product_Name.Text + "'And SPD.Watts='" + cmb_Watts.Text + "'", GVObj.con);
            // SqlCommand cmd = new SqlCommand("Select Current_Stock from Sub_Product_Details_db Where Watts = '" + cmb_Watts.Text + "' And Sub_Product_ID = " + SPID + " ", GVObj.con);
            var Obj = cmd.ExecuteReader();
            if (Obj.Read())
            {
                Stock = Convert.ToInt32(Obj["Current_Stock"]);
            }
            cmd.Dispose();
            Obj.Dispose();

            GVObj.Con_Close();

            if (txt_Quantity.Text != "" && Convert.ToInt32(txt_Quantity.Text) > 0)
            {
                if (Stock >= Convert.ToInt32(txt_Quantity.Text))
                {
                    txt_Total_Price.Text = (Convert.ToDouble(txt_Quantity.Text) * Convert.ToDouble(txt_Unit_Price.Text)).ToString();
                    btn_Add.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No Enough Stock Available", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Quantity.Text = "";
                    txt_Total_Price.Text = "";
                }
            }
        }
        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_Discount.Text != "")
            {
                decimal Total_Bill = decimal.Parse(txt_Total_Bill.Text);
                decimal Disc = decimal.Parse(txt_Discount.Text);
                decimal Final_Bill = ((100 - Disc) / 100) * Total_Bill;
                //Display Final Bills in textbox
                txt_Final_Bills.Text = Final_Bill.ToString();
                //double Tot_Bill = Convert.ToDouble(txt_Final_Bills.Text) - Disc;
                btn_Save.Enabled = true;
            }
        }
        private void txt_GST_TextChanged(object sender, EventArgs e)
        {
            if (txt_GST.Text != "")
            {
                decimal PreviousGT = decimal.Parse(txt_Final_Bills.Text);
                decimal GST = decimal.Parse(txt_GST.Text);
                decimal Final_BillswithGST = ((100 + GST) / 100) * PreviousGT;
                //decimal GST = decimal.Parse(txt_Total_Bill.Text) * (decimal.Parse(txt_GST.Text) / 100);

                // decimal Tot_Bill = decimal.Parse(txt_Total_Bill.Text) + GST;
                //Displaying new FinalBills with GST
                txt_Final_Bills.Text = Final_BillswithGST.ToString();
                btn_Save.Enabled = true;
            }
        }
        private void txt_Paid_Bills_TextChanged(object sender, EventArgs e)
        {
           
                decimal Final_Bill = decimal.Parse(txt_Final_Bills.Text);
                decimal Paid_Amount = decimal.Parse(txt_Paid_Bills.Text);
                decimal Remaining_Bill = Final_Bill - Paid_Amount;
                txt_Remaining_Bills.Text = Remaining_Bill.ToString();
           
            
        }
        #endregion

        #region Search Button Code
        private void btn_Search_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            txt_Cust_ID.Enabled = false;

            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select Name,Mobile_No From Retailer_Details_db where Retailer_ID = " + Convert.ToInt32(txt_Cust_ID.Text) + "", GVObj.con);
            var Obj = cmd.ExecuteReader();

            if (Obj.Read())
            {
                txt_Cust_Name.Text = Obj["Name"].ToString();
                txt_Mobile_No.Text = Obj["Mobile_No"].ToString();
                MessageBox.Show("Record Search Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid ID There is No Record Please Enter Crrect ID", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cust_ID.Enabled = true;
                txt_Cust_ID.Clear();
                Enabled_False();
            }
            GVObj.Con_Close();
        }
        #endregion

        #region Add Button Code
        private void btn_Add_Click(object sender, EventArgs e)
        {
            int Qty = Convert.ToInt32(txt_Quantity.Text);
            decimal Total_Bills = decimal.Parse(txt_Total_Bill.Text);
            Total_Bills = Total_Bills + decimal.Parse(txt_Total_Price.Text);
            int flag = -1;
            if (cmb_Category.Text != "" && cmb_Product_Name.Text != "" && cmb_Watts.Text != "" && txt_Unit_Price.Text != "" && txt_Quantity.Text != "" && txt_Total_Price.Text != "")
            {
                /*DataGridViewButtonColumn Edit = new DataGridViewButtonColumn();
                Edit.Name = "Edit";
                Edit.Text = "Edit";
                Edit.UseColumnTextForButtonValue = true;
                int columnIndex = 0;

                if (dgv_Data_View.Columns["Edit"] == null)
                {
                    dgv_Data_View.Columns.Insert(columnIndex, Edit);
                }*/
                foreach (DataGridViewRow row in dgv_Retailer_Purchase_Details.Rows)
                {
                    if (Convert.ToString(row.Cells[3].Value) == cmb_Watts.Text)
                    {
                        flag = 0;
                        Qty += Convert.ToInt32(row.Cells[5].Value);
                        if (Stock >= Qty)
                        {
                            double Tot_Price = Convert.ToDouble(Qty) * Convert.ToDouble(txt_Unit_Price.Text);
                            row.Cells[4].Value = Convert.ToDouble(txt_Unit_Price.Text);
                            row.Cells[5].Value = Qty;
                            row.Cells[6].Value = Tot_Price;
                            Stock_Update();
                            Clear_Control_Product_Details();
                        }
                        else
                        {
                            MessageBox.Show("Can't Add More Quantity", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            flag = 1;
                        }
                        txt_Total_Bill.Text = Total_Bills.ToString();
                        // txt_Total_Bill.Text = Total_Bills.ToString();
                    }
                    //Stock_Update();
                    ///txt_Total_Bill.Text = Total_Bills.ToString();

                }
                if (flag == -1)
                {
                    if (Stock >= Qty)
                    {
                        DT.Rows.Add(cmb_Category.Text, cmb_Product_Name.Text, cmb_Watts.Text, Convert.ToDouble(txt_Unit_Price.Text), Convert.ToInt32(txt_Quantity.Text), Convert.ToDouble(txt_Total_Price.Text));
                        dgv_Retailer_Purchase_Details.DataSource = DT;
                    }
                    else
                    {
                        MessageBox.Show("No Enough Stock Available", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = 1;
                    }

                    Stock_Update();
                    
                    txt_Total_Bill.Text = Total_Bills.ToString();
                    Clear_Control_Product_Details();
                }
                if (flag < 1)
                {
                    txt_Total_Bill.Text = Total_Bills.ToString();
                }
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "Remove";
                btn.Text = "Remove";
                btn.UseColumnTextForButtonValue = true;
                int columnIndex = 0;
                if (dgv_Retailer_Purchase_Details.Columns["Remove"] == null)
                {
                    dgv_Retailer_Purchase_Details.Columns.Insert(columnIndex, btn);
                }
            }
        }

        #endregion

        #region Leave Event Handling
        private void txt_Discount_Leave(object sender, EventArgs e)
        {
            if (txt_Discount.Text == "")
            {
                txt_Discount.Text = "0";
            }
        }

        private void txt_GST_Leave(object sender, EventArgs e)
        {
            if (txt_GST.Text == "")
            {
                MessageBox.Show("GST Should be a Zero Or Positive Values");
                txt_GST.Text = "0";
                txt_GST.Focus();
                btn_Save.Enabled = false;
            }
        }



        #endregion

        #region Stock Update
        private void Stock_Update()
        {
            GVObj.Con_Open();
            //string s = txt_Quantity.Text;
            Stock = (Stock - Convert.ToInt32(txt_Quantity.Text));
            SqlDataAdapter Sa = new SqlDataAdapter("Update Sub_Product_Details_db SET Sub_Product_Details_db.Current_Stock = " + Stock + " from Main_Product_Details_db MP inner join Sub_Product_Details_db SP on MP.Main_Product_ID = SP.Main_Product_ID where MP.Category='" + cmb_Category.Text + "' And MP.Product_Name = '" + cmb_Product_Name.Text + "' And SP.Watts = '" + cmb_Watts.Text + "' ", GVObj.con);
            DataTable dt2 = new DataTable();
            Sa.Fill(dt2);
            Sa.Dispose();
            dt2.Dispose();
            Stock = 0;
            GVObj.Con_Close();
        }
        #endregion

        #region Insert Gridview Data
        private void Insert_Gridview()
        {
            int i = 0;
            GVObj.Con_Open();
            for(i = 0;i <= dgv_Retailer_Purchase_Details.Rows.Count-1;i++)
            {
                SqlCommand cmd1 = new SqlCommand("Insert into Order_Details Values(@O_ID,@Category,@Product_Name,@Watts,@Unit_Price,@Quantity,@Total_Price) ",GVObj.con);
                cmd1.Parameters.Add("@O_ID", SqlDbType.Int).Value = txt_Order_ID.Text;
                cmd1.Parameters.Add("@Category", SqlDbType.NVarChar).Value = dgv_Retailer_Purchase_Details.Rows[i].Cells[1].Value;
                cmd1.Parameters.Add("@Product_Name", SqlDbType.NVarChar).Value = dgv_Retailer_Purchase_Details.Rows[i].Cells[2].Value;
                cmd1.Parameters.Add("@Watts", SqlDbType.NVarChar).Value = dgv_Retailer_Purchase_Details.Rows[i].Cells[3].Value;
                cmd1.Parameters.Add("@Unit_Price", SqlDbType.Money).Value = dgv_Retailer_Purchase_Details.Rows[i].Cells[4].Value;
                cmd1.Parameters.Add("@Quantity", SqlDbType.BigInt).Value = dgv_Retailer_Purchase_Details.Rows[i].Cells[5].Value;
                cmd1.Parameters.Add("@Total_Price", SqlDbType.Money).Value = dgv_Retailer_Purchase_Details.Rows[i].Cells[6].Value;
                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
            }
            GVObj.Con_Close();
        }
        #endregion

        #region Save Code
        private void btn_Save_Click(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            if(txt_Order_ID.Text != "" && txt_Cust_ID.Text != "" && txt_Total_Bill.Text != "" && txt_Discount.Text != "" && txt_GST.Text != "" && txt_Final_Bills.Text != "" && txt_Paid_Bills.Text != "" && txt_Remaining_Bills.Text != "" && dgv_Retailer_Purchase_Details.Rows.Count > 0)
            {
                SqlCommand cmd = new SqlCommand("Insert into Retailer_Order_Details_db Values(@R_ID,@O_ID,@Date,@Total_Bills,@Discount,@GST,@Final_Bill,@Paid_Bill,@Remaining_Bill) Select Retailer_ID from Retailer_Details_db", GVObj.con);
               // SqlCommand cmd = new SqlCommand("Insert into Retailer_Order_Details_db(Retailer_ID,Order_ID,Create_Date,Total_Bills,Discount,GST,Final_Bills,Paid_Bills,Remaining_Bills) Values(@R_Id,@O_ID,@Date,@Total_Bills,@Discount,@GST,@Final_Bill,@Paid_Bill,@Remaining_Bill)", GVObj.con);
                cmd.Parameters.Add("@R_Id", SqlDbType.Int).Value = txt_Cust_ID.Text;
                cmd.Parameters.Add("@O_ID", SqlDbType.Int).Value = txt_Order_ID.Text;
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Date.Text;
                cmd.Parameters.Add("@Total_Bills", SqlDbType.Money).Value = txt_Total_Bill.Text;
                cmd.Parameters.Add("@Discount", SqlDbType.Float).Value = txt_Discount.Text;
                cmd.Parameters.Add("@GST", SqlDbType.Float).Value = txt_GST.Text;
                cmd.Parameters.Add("@Final_Bill", SqlDbType.Money).Value = txt_Final_Bills.Text;
                cmd.Parameters.Add("@Paid_Bill", SqlDbType.Money).Value = txt_Paid_Bills.Text;
                cmd.Parameters.Add("@Remaining_Bill", SqlDbType.Money).Value = txt_Remaining_Bills.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Insert_Gridview();
                MessageBox.Show("Record Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control_Customer_Details();
            }
            else
            {
                MessageBox.Show("First Fill All The Field Data", "Fill Record Completely", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GVObj.Con_Close();
        }
        #endregion

        #region Clear Code
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Are Sure Clear Data", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (R == DialogResult.Yes)
            {
                MessageBox.Show("Clear All Text Box");
                Clear_Control_Customer_Details();
            }
            else
            {
                MessageBox.Show("Refresh Data");
                this.Show();
            }
        }
        #endregion
    }
}

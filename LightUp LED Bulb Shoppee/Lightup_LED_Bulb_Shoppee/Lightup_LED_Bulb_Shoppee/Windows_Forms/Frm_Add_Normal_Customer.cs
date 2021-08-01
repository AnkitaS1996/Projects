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
    public partial class Frm_Add_Normal_Customer : Form
    {
        Code_Class_Global_Vars GVObj = new Code_Class_Global_Vars();
        int SPID = 0;
        int ID = 0;
        int Stock = 0;
        DataTable dt = new DataTable();
        public Frm_Add_Normal_Customer()
        {
            InitializeComponent();
        }

        #region AutoIncrement Code
        private void Auto_Increment()
        {
            txt_Cust_ID.Text = Convert.ToString(GVObj.AutoIncrement("Select Count(Customer_ID) from Customer_Details_db", "Select Max(Customer_ID) from Customer_Details_db", 1001));
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
            txt_Cust_ID.Text = "";
            dtp_Date.Text = "";
            txt_Cust_Name.Clear();
            txt_Mobile_No.Clear();
            txt_Total_Bill.Clear();
            txt_Discount.Clear();
            txt_GST.Text = "";
            txt_Final_Bills.Clear();
            dt.Rows.Clear();
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
            dt.Columns.Add(c1);
            dt.Columns.Add(c2);
            dt.Columns.Add(c3);
            dt.Columns.Add(c4);
            dt.Columns.Add(c5);
            dt.Columns.Add(c6);
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

        #region Button Enable Code
        private void Enable_False_Button()
        {
            txt_Total_Bill.Enabled = false;
            btn_Add.Enabled = false;
            txt_Unit_Price.Enabled = false;
            txt_Total_Price.Enabled = false;
            btn_Save.Enabled = false;
        }
        #endregion

        #region Add Normal Customer From Load Code
        private void Frm_Add_Normal_Customer_Load(object sender, EventArgs e)
        {
            Auto_Increment();
            //txt_Total_Bill.Enabled = false;
            Enable_False_Button();
            txt_Total_Bill.Text = "0";
            Bind_Combobox_Category_Data();
            Create_Column();
        }
        #endregion

        #region Insert Gridview Code
        void Insert_Gridview()
        {
            GVObj.Con_Open();
            foreach (DataGridViewRow row in dgv_Data_View.Rows)
            {
                SqlCommand Cmd2 = new SqlCommand("Insert into Customer_Purchase_Details(Customer_ID,Category,Product_Name,Watts,Unit_Price,Quantity,Total_Price) Values(" + Convert.ToInt32(txt_Cust_ID.Text) + ",'" + row.Cells[1].Value.ToString() + "','" + row.Cells[2].Value.ToString() + "','" + row.Cells[3].Value.ToString() + "'," + Convert.ToDecimal(row.Cells[4].Value) + "," + Convert.ToInt32(row.Cells[5].Value) + "," + Convert.ToDouble(row.Cells[6].Value) + " ", GVObj.con);
                Cmd2.ExecuteNonQuery();
                Cmd2.Dispose();
            }

            GVObj.Con_Close();
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
            while(obj1.Read())
            {
                cmb_Watts.Items.Add(obj1["Watts"].ToString());
            }
            GVObj.Con_Close();
        }
        private void cmb_Watts_SelectedIndexChanged(object sender, EventArgs e)
        {
            GVObj.Con_Open();
            SqlCommand cmd = new SqlCommand("Select SPD.Unit_Price from Main_Product_Details_db MPD Inner Join Sub_Product_Details_db SPD ON MPD.Main_Product_ID = SPD.Main_Product_ID where MPD.Category = '" + cmb_Category.Text + "' And MPD.Product_Name = '" + cmb_Product_Name.Text + "' And SPD.Watts = '" + cmb_Watts.Text + "'",GVObj.con);
            //SqlCommand cmd = new SqlCommand("SELECT Unit_Price,Sub_Product_ID FROM Sub_Product_Details_db WHERE Watts='" + cmb_Watts.Text + "' AND Main_Product_ID = " + ID + "", GVObj.con);
            var obj = cmd.ExecuteReader();
            if(obj.Read())
            {
                txt_Unit_Price.Text = obj["Unit_Price"].ToString();
                //SPID = Convert.ToInt32(obj["Sub_Product_ID"]);
            }
            cmd.Dispose();
            obj.Dispose();
            GVObj.Con_Close();
        }
        #endregion

        #region Combobox Textchanged Code
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
                decimal Final_BillswithGST = ((100+GST)/ 100) * PreviousGT;
                //decimal GST = decimal.Parse(txt_Total_Bill.Text) * (decimal.Parse(txt_GST.Text) / 100);

                // decimal Tot_Bill = decimal.Parse(txt_Total_Bill.Text) + GST;
                //Displaying new FinalBills with GST
                txt_Final_Bills.Text = Final_BillswithGST.ToString();

                btn_Save.Enabled = true;
            }
        }
        #endregion

        #region Stock Update
        private void Stock_Update()
        {
            GVObj.Con_Open();
            //string s = txt_Quantity.Text;
            Stock = (Stock - Convert.ToInt32(txt_Quantity.Text));
            SqlDataAdapter Sa = new SqlDataAdapter("Update Sub_Product_Details_db SET Sub_Product_Details_db.Current_Stock = " + Stock + " from Main_Product_Details_db MP inner join Sub_Product_Details_db SP on MP.Main_Product_ID = SP.Main_Product_ID where MP.Category='" + cmb_Category.Text + "' And MP.Product_Name = '" + cmb_Product_Name.Text + "' And SP.Watts = '" + cmb_Watts.Text + "' ",GVObj.con);
            DataTable dt2 = new DataTable();
            Sa.Fill(dt2);
            Sa.Dispose();
            dt2.Dispose();
            Stock = 0;
            SPID = 0;
            ID = 0;
            GVObj.Con_Close();
        }
        #endregion

        #region Leave Event Handling Code
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

        #region Add Button Code
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //display total Bills From textbox
            //double Total = Convert.ToDouble(txt_Total_Price.Text);
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
                foreach (DataGridViewRow row in dgv_Data_View.Rows)
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
                            row.Cells[6].Value = Total_Bills;
                            Clear_Control_Product_Details();
                        }
                        else
                        {
                            MessageBox.Show("Can't Add More Quantity", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            flag = 1;
                        }

                        // txt_Total_Bill.Text = Total_Bills.ToString();
                    }
                    //Stock_Update();
                    txt_Total_Bill.Text = Total_Bills.ToString();

                }
                if (flag == -1)
                {
                    if (Stock >= Qty)
                    {
                        dt.Rows.Add(cmb_Category.Text, cmb_Product_Name.Text, cmb_Watts.Text, Convert.ToDouble(txt_Unit_Price.Text), Convert.ToInt32(txt_Quantity.Text), Convert.ToDouble(txt_Total_Price.Text));
                        dgv_Data_View.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No Enough Stock Available", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = 1;
                    }

                    Stock_Update();
                    Clear_Control_Product_Details();
                    //Total_Bills = Total_Bills + decimal.Parse(txt_Total_Price.Text);
                    txt_Total_Bill.Text = Total_Bills.ToString();
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
                if (dgv_Data_View.Columns["Remove"] == null)
                {
                    dgv_Data_View.Columns.Insert(columnIndex, btn);
                }
            }
                /* decimal Total_Bills = decimal.Parse(txt_Total_Bill.Text);
                 Total_Bills = Total_Bills + decimal.Parse(txt_Total_Price.Text);

                 if (cmb_Category.Text != "" && cmb_Product_Name.Text != "" && cmb_Watts.Text != "" && txt_Unit_Price.Text != "" && txt_Quantity.Text != "" && txt_Total_Price.Text != "")
                  {
                      dt.Rows.Add(cmb_Category.Text,cmb_Product_Name.Text,cmb_Watts.Text,Convert.ToDouble(txt_Unit_Price.Text),Convert.ToInt32(txt_Quantity.Text),Convert.ToDouble(txt_Total_Price.Text));
                      dgv_Data_View.DataSource = dt;

                      Clear_Control_Product_Details();
                     //Stock_Update();
                     //Total_Bills = Total_Bills + decimal.Parse(txt_Total_Price.Text);
                     txt_Total_Bill.Text = Total_Bills.ToString();
                 }
                  else
                  {
                      MessageBox.Show("1st Fill All The Fields.....!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }*/
        }
        #endregion
        #region Dridview Cellclick code
        private void dgv_Data_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            

            if (e.RowIndex >= 0)
            {
                DataRow dr = dt.Rows[e.RowIndex];

                for (i= 0; i <= dgv_Data_View.Rows.Count; i++)
                {
                    double Total_Bills = Convert.ToDouble(txt_Total_Bill.Text);
                    Total_Bills = (Total_Bills + (Convert.ToDouble(txt_Total_Price.Text)));

                    txt_Total_Bill.Text = Total_Bills.ToString();     

                }
                dr.Delete();
                dgv_Data_View.DataSource = dt;
                //txt_Total_Bill.Text = ;
                
            } 
        }
        #endregion

        #region Save Button code
        private void btn_Save_Click(object sender, EventArgs e)
        {
            decimal Discount = 0;

            if(txt_Discount.Text != "")
            {
                Discount = Convert.ToDecimal(txt_Discount.Text);
            }

            if(txt_Cust_ID.Text != "" && txt_Cust_Name.Text != "" && txt_Mobile_No.Text != "" && txt_Total_Bill.Text != "" && txt_GST.Text != "" && txt_Final_Bills.Text != "" && dgv_Data_View.Rows.Count > 0)
            {
                GVObj.Con_Open();
                SqlCommand cmd = new SqlCommand("Insert into Customer_Details_db Values(@C_ID,@Date,@C_Name,@M_No,@Total_Bill,@Discount,@GST,@Final_Bill)",GVObj.con);
                cmd.Parameters.Add("@C_ID", SqlDbType.Int).Value = txt_Cust_ID.Text;
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Date.Value.Date;
                cmd.Parameters.Add("@C_Name", SqlDbType.NVarChar).Value = txt_Cust_Name.Text;
                cmd.Parameters.Add("@M_No", SqlDbType.Decimal).Value = txt_Mobile_No.Text;
                cmd.Parameters.Add("@Total_Bill", SqlDbType.Money).Value = txt_Total_Bill.Text;
                cmd.Parameters.Add("@Discount", SqlDbType.Float).Value = Discount;
                cmd.Parameters.Add("@GST", SqlDbType.Float).Value = txt_GST.Text;
                cmd.Parameters.Add("@Final_Bill", SqlDbType.Money).Value = txt_Final_Bills.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Insert_Gridview();
                MessageBox.Show("Record Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                GVObj.Con_Close();
            }
        }
        #endregion
        #region Keydown Event Handling
        private void txt_Cust_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_Mobile_No.Focus();
            }
        }
        private void txt_Mobile_No_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Category.Focus();
            }
        }
        private void cmb_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Product_Name.Focus();
            }
        }

        private void cmb_Product_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Watts.Focus();
            }
        }
        private void cmb_Watts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Quantity.Focus();
            }
        }

        #endregion

        #region Keypress Event Handling
        private void txt_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}

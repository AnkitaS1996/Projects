using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightup_LED_Bulb_Shoppee
{
    class Code_Class_Global_Vars
    {
        public static string Uname = "User";

        public SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Lightup_LED_Bulb_Shoppee_db;Integrated Security=True");
        public void Con_Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void Con_Close()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        // Region AutoIncrement Function
        public int AutoIncrement(string Get_Count, string Get_Max, int StartNo)
        {
            int cnt = 0;
            Con_Open();
            try
            {
                SqlCommand cmd = new SqlCommand(Get_Count, con);
                cnt = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                if (cnt > 0)
                {
                    cmd.CommandText = Get_Max;
                    cmd.Connection = con;
                    cnt = Convert.ToInt32(cmd.ExecuteScalar());
                    cnt = cnt + 1;   /// cnt += 1;
                    cmd.Dispose();
                    Con_Close();
                }
                else
                {
                    cnt += StartNo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cnt;
        }
        //End Region Auto Increment


    }
}

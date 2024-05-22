using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkDistributionApp
{
    class ClassConn
    {
        //for local connection
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HG2U0S4\\SQLEXPRESS;Initial Catalog=evmilkDB;Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        DataSet ds;
        SqlDataAdapter adp = new SqlDataAdapter();
        public static string ReportType = "";
        public static string RptID = "";       
        public static string Companyid = "";
        public static string CustID = "";
        public static string PinCodeMilkMan = "";
        public static DateTime DateEvenOdd =new DateTime();
        string ct;
        public static int st;




        // for server connection
        //OleDbConnection con = new OleDbConnection("PROVIDER=SQLOLEDB.1;Network Library=DBMSSOCN;Data Source=43.231.126.108;Initial Catalog=evmilkDB;Trusted_Connection=False;UID=SA;PWD=Mit@1234");
        //OleDbDataAdapter adp = new OleDbDataAdapter();
        //OleDbCommand cmd = new OleDbCommand();
        //DataSet ds = new DataSet();

        //ExecuteNonQry
        public void exeNonQry(string sql)
        {
            cmd = new SqlCommand(sql, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //ExecuteScaler
        public string exeSclQry(string sql)
        {
            cmd = new SqlCommand(sql, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            ct = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
            return ct;
        }

        //method To fill ds
        public DataSet fillDs(string sql)
        {
            ds = new DataSet();
            adp = new SqlDataAdapter(sql, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            adp.Fill(ds);
            con.Close();
            return ds;
        }

        //method To insert,update,delete
        public void execute(string str)
        {
            cmd = new SqlCommand(str, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // //method To select
        int cnt;
        public int executescal(string str)
        {
            cmd = new SqlCommand(str, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cnt;
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    // MessageBox.Show("Internet is Connected");
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Please Check your internet");
                return false;
            }
        }

        public DataTable GetDataTable(string strsql)
        {
            con.Open();
            adp = new SqlDataAdapter(strsql, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            adp.Dispose();
            con.Close();
           // DisposeConnection();
            return dt;
        }
    }
    }


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BBMS
{
    public static class DBManager
    {
        public static SqlConnection conn = new SqlConnection(@"Data source=SUBHAN\SUBHAN;initial catalog=BBSM;integrated security=true");
        //public DBManager(){
        //    //conn = new SqlConnection(conn = new SqlConnection(@"Data source=SUBHAN\SUBHAN;initial catalog=FileHandling;integrated security=true"););
        //    conn = new SqlConnection(@"Data source=SUBHAN\SUBHAN;initial catalog=BBSM;integrated security=true");
        //}
        public static void Open()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public static void Close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PFF_Projet
{
    class DBConnect
    {
        private SqlConnection con = new SqlConnection(@"Data Source=LOCAL-HOST;Initial Catalog=DB_Marchet;Integrated Security=True");
        public SqlConnection GetCon()
        {
            return con;
        }
        public void openCon()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeCon()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

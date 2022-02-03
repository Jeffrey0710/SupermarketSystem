using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SupermarketSystem.Classes
{
    public class csUser
    {

        public DataSet list_Users() {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
            cn.Open();

            MySqlDataAdapter da;
            da = new MySqlDataAdapter("select * from users", cn);
            
            DataSet ds = new DataSet();
            da.Fill(ds);

            cn.Close();

            return ds;
        }
    }
}
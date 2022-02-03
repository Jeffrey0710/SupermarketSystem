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
        DataSet ds = new DataSet();
        public DataSet list_Users() {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from users", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch(Exception ex) {
                
            }
            return ds;
        }

        public DataSet user(string user, string password)
        {
            DataSet ds = new DataSet();
            try {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from users where userName = '" + user + "' and userPassword = '" + password + "' ", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch(Exception ex)
            {

            }
            return ds;
        }

        public Int32 insert_User(Int32 idEmployee, string user, string password, string nationality, string altEmail, string favFood) {
            int result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into users(idEmployee, userName, userPassword, nationality, alternativeEmail, favoriteFood)" +
                    " values (" + idEmployee + ", '" + user + "', '" + password + "', '" + nationality + "', '" + altEmail + "', '" + favFood + "')", cn);

                result = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex) { 
            
            }
            return result;
        }

        public Int32 update_User(Int32 idUser, Int32 idEmployee, string user, string password, string nationality, string altEmail, string favFood) {
            int result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update users set idEmployee = '" + idEmployee + "', userName = '" + user + "', userPassword = '" + password + "', nationality = '" + nationality + "', alternativeEmail = '" + altEmail + "', favoriteFood = '" + favFood + "' where idUser = '" + idUser + "' ",cn) ;

                result = cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex) { 
            
            }
            return result;
        }

        public Int32 deleteUser(Int32 idUser) {
            int result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from users where idUser = " + idUser + " ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex) { 
            }
            return result;
        }
    }
}
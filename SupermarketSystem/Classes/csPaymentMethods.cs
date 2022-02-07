using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SupermarketSystem.Classes
{
    public class csPaymentMethods
    {
        DataSet ds = new DataSet();
        public DataSet list_PaymentMethods()
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from paymentMethods", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading ", ex);
            }
            return ds;
        }

        public DataSet paymentMethod(Int32 idPaymentMethod)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from paymentMethods where idPaymentMethod = " + idPaymentMethod + " ", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading ", ex);
            }
            return ds;
        }

        public Int32 insert_PaymentMethod(string methodName)
        {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into paymentMethods(methodName) values ('" + methodName + "' ) ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading", ex);
            }
            return result;
        }

        public Int32 update_PaymentMethod(Int32 idPaymentMethod, string methodName)
        {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update paymentMethods set methodName = '" + methodName + "' where idPaymentMethod = " + idPaymentMethod + " ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading", ex);
            }
            return result;
        }

        public Int32 delete_PaymentMethod(Int32 idPaymentMethod)
        {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from paymentMethods where idPaymentMethod = " + idPaymentMethod + " ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading ", ex);
            }
            return result;
        }
    }
}
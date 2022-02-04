using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SupermarketSystem.Classes
{
    public class csCheckoutCounter
    {
        DataSet ds = new DataSet();
        public DataSet list_CheckoutCounter(){
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from checkoutCounter", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch (Exception ex) 
            {
                throw new Exception("Error reading ", ex);
            }
            return ds;
        }

        public DataSet checkoutCounter(Int32 counterNum) {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from checkoutCounter where counterNumber = " + counterNum + " ", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch (Exception ex) 
            {
                throw new Exception("Error reading ", ex);
            }
            return ds;
        }

        public Int32 insert_CheckoutCounter(Int32 idEmployee, Int32 counterNum, string employeeName) {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into checkoutCounter(idEmployee, counterNumber, employeeName) values(" + idEmployee + ", " + counterNum + ", '" + employeeName + "' ) ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex) 
            {
                throw new Exception("Error reading ", ex);
            }
            return result;
        }

        public Int32 update_CheckoutCounter(Int32 idCheckoutCounter, Int32 idEmployee, Int32 counterNum, string employeeName) {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update checkoutCounter set idEmployee = " + idEmployee + ", counterNumber = " + counterNum + ", employeeName = '" + employeeName + "' where idCheckoutCounter = "+idCheckoutCounter+" ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex) 
            {
                throw new Exception("Error reading ", ex);
            }
            return result;
        }

        public Int32 delete_CheckoutCounter(Int32 idCheckoutCounter) {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from checkoutCounter where idCheckoutCounter = " + idCheckoutCounter + " ", cn);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SupermarketSystem.Classes
{
    public class csCustomers
    {
        DataSet ds = new DataSet();
        public DataSet list_Customers() {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from customers", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading ", ex);
            }
            return ds;
        }

        public DataSet customer(Int32 idCustomer){
            try 
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from customers where idCustomer = " + idCustomer + " ", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch(Exception ex)
            {
                throw new Exception("Error reading ", ex);
            }
            return ds;
        }

        public Int32 insert_Customer(string custName, Int32 ssn, string address, Int32 phoneNum) {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into customers(customerName, ssn, address, phoneNumber) values ('" + custName + "', " + ssn + ", '" + address + "', " + phoneNum + " ) ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex) 
            {
                throw new Exception("Error reading", ex);
            }
            return result;
        }

        public Int32 update_Customer(Int32 idCustomer, string custName, Int32 ssn, string address, Int32 phoneNum) {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update customers set customerName = '" + custName + "', ssn = " + ssn + ", address = '" + address + "', phoneNumber = " + phoneNum + " where idCustomer = " + idCustomer + " ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex) 
            {
                throw new Exception("Error reading", ex);
            }
            return result;
        }

        public Int32 delete_Customer(Int32 idCustomer) {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from customers where idCustomer = " + idCustomer + "", cn);
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
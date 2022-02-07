using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SupermarketSystem.Classes
{
    public class csProducts
    {
        DataSet ds = new DataSet();
        public DataSet list_Products()
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from products", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading ", ex);
            }
            return ds;
        }

        public DataSet product(Int32 idProduct)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from products where idProduct = " + idProduct + " ", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading ", ex);
            }
            return ds;
        }

        public Int32 insert_Product(string productName, string productType, double cost)
        {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into products(productName, productType, cost) values ('" + productName + "', '" + productType + "', " + cost + " ) ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading", ex);
            }
            return result;
        }

        public Int32 update_Product(Int32 idProduct, string productName, string productType, double cost)
        {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update products set productName = '" + productName + "', productType = '" + productType + "', cost = " + cost + " where idProduct = " + idProduct + " ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading", ex);
            }
            return result;
        }

        public Int32 delete_Product(Int32 idProduct)
        {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from products where idProduct = " + idProduct + " ", cn);
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
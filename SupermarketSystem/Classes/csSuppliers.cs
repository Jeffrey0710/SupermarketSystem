using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SupermarketSystem.Classes
{
    public class csSuppliers
    {
        DataSet ds = new DataSet();
        public DataSet list_Suppliers()
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from suppliers", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading ", ex);
            }
            return ds;
        }

        public DataSet supplier(Int32 idSupplier)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from suppliers where idSupplier = " + idSupplier + " ", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading ", ex);
            }
            return ds;
        }

        public Int32 insert_Supplier(Int32 idProduct, Int32 lot, string supplierName, string supplierDate)
        {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into suppliers(idProduct, lot, supplierName, supplierDate) values (" + idProduct + ", " + lot + "  ,'" + supplierName + "', '" + supplierDate + "') ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading", ex);
            }
            return result;
        }

        public Int32 update_Supplier(Int32 idSupplier, Int32 idProduct, Int32 lot, string supplierName, string supplierDate)
        {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update suppliers set idProduct = " + idProduct + ", lot = " + lot + ", supplierName = '" + supplierName + "', supplierDate = '" + supplierDate + "' where idSupplier = " + idSupplier + " ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading", ex);
            }
            return result;
        }

        public Int32 delete_Supplier(Int32 idSupplier)
        {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from suppliers where idSupplier = " + idSupplier + "", cn);
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
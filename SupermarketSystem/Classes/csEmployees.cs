using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SupermarketSystem.Classes
{
    public class csEmployees
    {
        DataSet ds = new DataSet();
        public DataSet list_Employees()
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from employees", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading ", ex);
            }
            return ds;
        }

        public DataSet employee(Int32 idEmployee)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlDataAdapter da;
                da = new MySqlDataAdapter("select * from employees where idEmployee = " + idEmployee + " ", cn);
                da.Fill(ds);

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading ", ex);
            }
            return ds;
        }

        public Int32 insert_Employee(string empName, string email, string address, Int32 phoneNum)
        {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into employees(employeeName, email, address, phoneNumber) values ('" + empName + "', '" + email + "', '" + address + "', " + phoneNum + " ) ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading", ex);
            }
            return result;
        }

        public Int32 update_Employee(Int32 idEmployee, string empName, string email, string address, Int32 phoneNum)
        {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("update employees set employeeName = '" + empName + "', email = '" + email + "', address = '" + address + "', phoneNumber = " + phoneNum + " where idEmployee = " + idEmployee + " ", cn);
                result = cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading", ex);
            }
            return result;
        }

        public Int32 delete_Employee(Int32 idEmployee)
        {
            Int32 result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["cnConnection"].ConnectionString;
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from employees where idEmployee = " + idEmployee + "", cn);
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
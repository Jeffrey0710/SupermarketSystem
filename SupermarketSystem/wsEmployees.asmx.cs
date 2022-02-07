using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace SupermarketSystem
{
    /// <summary>
    /// Descripción breve de wsEmployees
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsEmployees : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet list_Employees()
        {
            return new Classes.csEmployees().list_Employees();
        }

        [WebMethod]
        public DataSet employee(Int32 idEmployee)
        {
            return new Classes.csEmployees().employee(idEmployee);
        }

        [WebMethod]
        public Int32 insert_Employee(string empName, string email, string address, Int32 phoneNum)
        {
            return new Classes.csEmployees().insert_Employee(empName, email, address, phoneNum);
        }

        [WebMethod]
        public Int32 update_Employee(Int32 idEmployee, string empName, string email, string address, Int32 phoneNum)
        {
            return new Classes.csEmployees().update_Employee(idEmployee, empName, email, address, phoneNum);
        }

        [WebMethod]
        public Int32 delete_Employee(Int32 idEmployee)
        {
            return new Classes.csEmployees().delete_Employee(idEmployee);
        }
    }
}

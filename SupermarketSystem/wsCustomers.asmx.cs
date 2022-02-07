using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace SupermarketSystem
{
    /// <summary>
    /// Descripción breve de wsCustomers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsCustomers : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet list_Customers()
        {
            return new Classes.csCustomers().list_Customers();
        }

        [WebMethod]
        public DataSet customer(Int32 idCustomer) 
        {
            return new Classes.csCustomers().customer(idCustomer);    
        }

        [WebMethod]
        public Int32 insert_Customer(string custName, Int32 ssn, string address, Int32 phoneNum) 
        {
            return new Classes.csCustomers().insert_Customer(custName, ssn, address, phoneNum);
        }

        [WebMethod]
        public Int32 update_Customer(Int32 idCustomer, string custName, Int32 ssn, string address, Int32 phoneNum) 
        {
            return new Classes.csCustomers().update_Customer(idCustomer, custName, ssn, address, phoneNum);
        }

        [WebMethod]
        public Int32 delete_Customer(Int32 idCustomer) 
        {
            return new Classes.csCustomers().delete_Customer(idCustomer);
        }
    }
}

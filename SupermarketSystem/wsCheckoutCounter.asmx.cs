using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace SupermarketSystem
{
    /// <summary>
    /// Descripción breve de wsCheckoutCounter
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsCheckoutCounter : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet list_CheckoutCounter()
        {
            return new Classes.csCheckoutCounter().list_CheckoutCounter();
        }

        [WebMethod]
        public DataSet checkoutCounter(Int32 counterNum) 
        {
            return new Classes.csCheckoutCounter().checkoutCounter(counterNum);        
        }

        [WebMethod]
        public Int32 insert_CheckoutCounter(Int32 idEmployee, Int32 counterNum, string employeeName) 
        {
            return new Classes.csCheckoutCounter().insert_CheckoutCounter(idEmployee, counterNum, employeeName);
        }

        [WebMethod]
        public Int32 update_CheckoutCounter(Int32 idCheckoutCounter, Int32 idEmployee, Int32 counterNum, string employeeName) 
        {
            return new Classes.csCheckoutCounter().update_CheckoutCounter(idCheckoutCounter, idEmployee, counterNum, employeeName); 
        }

        [WebMethod]
        public Int32 delete_CheckoutCounter(Int32 idCheckoutCounter) 
        {
            return new Classes.csCheckoutCounter().delete_CheckoutCounter(idCheckoutCounter);
        }
    }
}

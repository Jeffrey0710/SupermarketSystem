using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace SupermarketSystem
{
    /// <summary>
    /// Descripción breve de wsPaymentMethods
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsPaymentMethods : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet list_PaymentMethods()
        {
            return new Classes.csPaymentMethods().list_PaymentMethods();
        }

        [WebMethod]
        public DataSet paymentMethod(Int32 idPaymentMethod)
        {
            return new Classes.csPaymentMethods().paymentMethod(idPaymentMethod);
        }

        [WebMethod]
        public Int32 insert_PaymentMethod(string methodName)
        {
            return new Classes.csPaymentMethods().insert_PaymentMethod(methodName);
        }

        [WebMethod]
        public Int32 update_PaymentMethod(Int32 idPaymentMethod, string methodName)
        {
            return new Classes.csPaymentMethods().update_PaymentMethod(idPaymentMethod, methodName);
        }

        [WebMethod]
        public Int32 delete_PaymentMethod(Int32 idPaymentMethod)
        {
            return new Classes.csPaymentMethods().delete_PaymentMethod(idPaymentMethod);
        }
    }
}

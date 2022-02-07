using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace SupermarketSystem
{
    /// <summary>
    /// Descripción breve de wsProducts
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsProducts : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet list_Products()
        {
            return new Classes.csProducts().list_Products();
        }

        [WebMethod]
        public DataSet product(Int32 idProduct)
        {
            return new Classes.csProducts().product(idProduct);
        }

        [WebMethod]
        public Int32 insert_Product(string productName, string productType, double cost)
        {
            return new Classes.csProducts().insert_Product(productName, productType, cost);
        }

        [WebMethod]
        public Int32 update_Product(Int32 idProduct, string productName, string productType, double cost)
        {
            return new Classes.csProducts().update_Product(idProduct, productName, productType, cost);
        }

        [WebMethod]
        public Int32 delete_Product(Int32 idProduct)
        {
            return new Classes.csProducts().delete_Product(idProduct);
        }
    }
}

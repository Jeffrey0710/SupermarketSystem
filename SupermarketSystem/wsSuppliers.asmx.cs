using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace SupermarketSystem
{
    /// <summary>
    /// Descripción breve de wsSuppliers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsSuppliers : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet list_Suppliers()
        {
            return new Classes.csSuppliers().list_Suppliers();
        }

        [WebMethod]
        public DataSet supplier(Int32 idSupplier)
        {
            return new Classes.csSuppliers().supplier(idSupplier);
        }

        [WebMethod]
        public Int32 insert_Supplier(Int32 idProduct, Int32 lot, string supplierName, string supplierDate)
        {
            return new Classes.csSuppliers().insert_Supplier(idProduct, lot, supplierName, supplierDate);
        }

        [WebMethod]
        public Int32 update_Supplier(Int32 idSupplier, Int32 idProduct, Int32 lot, string supplierName, string supplierDate)
        {
            return new Classes.csSuppliers().update_Supplier(idSupplier, idProduct, lot, supplierName, supplierDate);
        }

        [WebMethod]
        public Int32 delete_Supplier(Int32 idSupplier)
        {
            return new Classes.csSuppliers().delete_Supplier(idSupplier);
        }
    }
}

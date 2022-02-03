using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace SupermarketSystem
{
    /// <summary>
    /// Descripción breve de wsUsers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsUsers : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet list_Users()
        {
            return new Classes.csUser().list_Users();
        }

        [WebMethod]
        public DataSet user(string user, string password)
        {
            return new Classes.csUser().user(user, password);
        }

        [WebMethod]
        public Int32 insert_User(Int32 idEmployee, string user, string password, string nationality, string altEmail, string favFood)
        {
            return new Classes.csUser().insert_User(idEmployee, user, password, nationality, altEmail, favFood);
        }

        [WebMethod]
        public Int32 update_User(Int32 idUser, Int32 idEmployee, string user, string password, string nationality, string altEmail, string favFood)
        {
            return new Classes.csUser().update_User(idUser, idEmployee, user, password, nationality, altEmail, favFood);
        }

        [WebMethod]
        public Int32 delete_User(Int32 idUser) {
            return new Classes.csUser().deleteUser(idUser);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace FirstWebApplication
{
    /// <summary>
    /// Summary description for ws_MyService
    /// </summary>
    [WebService(Description = "Serviciu Web pentru Cursul de C#",
        Name = "My fisrt Web Service" , Namespace = "Web Services")]
    //[WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ws_MyService : System.Web.Services.WebService
    {

        [WebMethod(Description = "This method display's a message")]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(Description = "This method add's two integers")]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}

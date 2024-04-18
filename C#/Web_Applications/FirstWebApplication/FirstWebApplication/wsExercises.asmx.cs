using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace FirstWebApplication
{
    /// <summary>
    /// Summary description for wsExercises
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsExercises : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(Description = "This method converts Fahrenheit to Celsius")]
        public double ConvertFC(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }

        [WebMethod(Description = "This method converts Celsius to Fahrenheit")]
        public double ConvertCF(double celsius)
        {
            return (celsius * 1.8) + 32;
        }

        [WebMethod(Description = "This method returns the date and time")]
        public DateTime DateTimeNow()
        {
            return DateTime.Now;
        }

        [WebMethod(Description = "This method returns a list of 5 elements")]
        public List<String> Build5ItemList()
        {
            List<String> list = new List<String>();
            list.Add("BMW");
            list.Add("Audi");
            list.Add("Mercedes");
            list.Add("Lotus");
            list.Add("Lada");
            return list;
        }

        [WebMethod(Description = "This method converts Euros to Ron")]
        public double ConvertEuroToRon(double e)
        {
            return e * 4.97;
        }

        [WebMethod(Description = "This method converts Ron to euro")]
        public double ConvertRontoEuro(double r)
        {
            return r / 4.97;
        }
    }
}

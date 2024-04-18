using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClient1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleAppClient1.sr_MyService.MyfisrtWebServiceSoapClient serviceSoapClient = new sr_MyService.MyfisrtWebServiceSoapClient();

            int sum = serviceSoapClient.Add(2, 3);
            Console.WriteLine("The sum is " + sum.ToString());
            Console.ReadKey();
        }
    }
}

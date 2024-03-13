using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSR_Laborator1_Exercitiul3
{
    internal class Program
    {
        public class TemperatureConvertor
        {
            float degrees;
            float result;
            public TemperatureConvertor(float degrees)
            { this.degrees = degrees; }
            public void CtoF()
            {
                this.result = this.degrees * 9 / 5 + 32;
            }
            public void FtoC()
            {
                this.result = (this.degrees - 32) * 5 / 9;
            }
            public override string ToString()
            {
                return " " + result + " " ;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("What do you want to do? \n" +
                "1. Convert from C to F \n" +
                "2. Convert from F to C \n");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    {
                        Console.WriteLine(" Please enter the temperature in C: ");
                        float temp = float.Parse(Console.ReadLine());
                        TemperatureConvertor TC = new TemperatureConvertor(temp);
                        TC.CtoF();
                        Console.WriteLine("The temperature in F is:");
                        Console.Write(TC.ToString());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" Please enter the temperature in F: ");
                        float temp = float.Parse(Console.ReadLine());
                        TemperatureConvertor TC = new TemperatureConvertor(temp);
                        TC.FtoC();
                        Console.WriteLine("The temperature in C is:");
                        Console.Write(TC.ToString());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Input not valid");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}

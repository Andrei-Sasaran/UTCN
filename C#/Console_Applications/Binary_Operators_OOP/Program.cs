using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSR_Laborator1_Exercitiul2
{
    internal class Program
    {
        public class Math
        {
            double a, b;

            public Math(double a, double b)
            {
                this.a = a;
                this.b = b;
            }

            public double Add()
            {
                return this.a + this.b;
            }

            public double Sub()
            {
                return this.a - this.b;
            }

            public double Mul()
            {
                return this.a * this.b;
            }

            public double Div()
            {
                return this.a / this.b;
            }

            public override string ToString()
            {
                return "" + a + " " + b + " ";
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Math math = new Math(a, b);
            Console.WriteLine(math.ToString());
            Console.WriteLine("a + b = {0}", math.Add());
            Console.WriteLine("a - b = {0}", math.Sub());
            Console.WriteLine("a * b = {0}", math.Mul());
            Console.WriteLine("a / b = {0}", math.Div());
            Console.ReadKey();
        }
    }
}

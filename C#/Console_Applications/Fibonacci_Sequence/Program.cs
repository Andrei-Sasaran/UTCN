using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSR_Laborator1_Exercitiul1
{
    internal class Program
    {
        public static void FibonacciSequence(int a, int b, int count, int len)
        {
            if (len == 1) Console.WriteLine(a);
            if (len == 2) Console.WriteLine("{0} {1} ", a, b);
            if (count <= len)
            {
                Console.Write("{0} ", a);
                FibonacciSequence(b, a + b, count + 1, len);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms you want to see from the Fibonacci Sequence: ");
            int number = Convert.ToInt32(Console.ReadLine());
            FibonacciSequence(0, 1, 1, number);
            Console.ReadKey();
        }
    }
}

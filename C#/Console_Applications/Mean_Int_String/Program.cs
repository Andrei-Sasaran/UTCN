using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SSR_Laborator1_Exercitiul5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Please enter the integers separated by 'Space' : ");
            string[] tokens = Console.ReadLine().Split();
            int[] ints = new int[tokens.Length];
            for (int i = 0; i < ints.Length; i++)
                ints[i] = int.Parse(tokens[i]);
            int sum = 0, mult = 1;
            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
                mult *= ints[i];
            }
            float mA = sum / ints.Length;
            double mG = Math.Pow(mult, (1.0 / ints.Length));
            Console.WriteLine("Arithmethic mean is: {0} \n Geometric mean is: {1}", mA, mG);
            Console.ReadKey();
        }
    }
}

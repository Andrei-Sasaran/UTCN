using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSR_Laborator1_Exercitiul4
{
    internal class Program
    {
        public class Person
        {
            public int Age { get; set; }
            public int Height { get; set; }
            public string Gender { get; set; }
            public float IdealWeight { get; set; }

            public void IWCalculatorM()
            {
                this.IdealWeight = (this.Height - 100 - (this.Height - 150) / 4 + (this.Age - 20) / 4);
            }
            public void IWCalculatorF()
            {
                this.IdealWeight = ((float)(this.Height - 100 - (this.Height - 150) / 2.5 + (this.Age - 20) / 6));
            }
            public override string ToString()
            {
                return "Your ideal weight is " + this.IdealWeight;
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.Write("Please enter your age: ");
            person.Age = int.Parse(Console.ReadLine());
            Console.Write("\nPlease enter your height [cm] : ");
            person.Height = int.Parse(Console.ReadLine());
            Console.Write("\nPlease enter your gender ( m / f) : ");
            person.Gender = Console.ReadLine();
            if (person.Gender == "m")
            {
                person.IWCalculatorM();
                Console.WriteLine(person.ToString());
            }
            else
            {
                person.IWCalculatorF();
                Console.WriteLine(person.ToString());
            }
            Console.ReadKey();
        }
    }
}

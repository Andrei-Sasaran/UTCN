using ConsoleAppExercisesClient.srExercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercisesClient
{
    internal class Program
    {
        ConsoleAppExercisesClient.srExercices.wsExercisesSoapClient soapClient = new ConsoleAppExercisesClient.srExercices.wsExercisesSoapClient();
        static void Main(string[] args)
        {
            Program program = new Program();
            String[] menuOptions = new string[] { "Print Hello World\t",
            "Convert F to C\t", "Convert C to F\t","Print date and time\t",
            "Print a list of 5 elements\t","Convert Euro to Ron\t",
            "Convert Ron to Euro\t"};
            int menuSelect = 0;
            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.WriteLine("Hello! Please select would you like to do?");
                
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    Console.WriteLine((i == menuSelect ? "* " : "") + menuOptions[i] + (i == menuSelect ? "<--" : ""));
                }
                
                var keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1)
                {
                    menuSelect++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1)
                {
                    menuSelect--;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    switch (menuSelect)
                    {
                        case 0:
                            program.HelloWorld();
                            break;
                        case 1:
                            program.ConvertFC();
                            break;
                        case 2:
                            program.ConvertCF();
                            break;
                        case 3:
                            program.DateTimeNow();
                            break;
                        case 4:
                            program.Build5ItemList();
                            break;
                        case 5:
                            program.ConvertEuroToRon();
                            break;
                        case 6:
                            program.ConvertRonToEuro();
                            break;
                    }
                }
            }
        }

        private void ConvertRonToEuro()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t Please enter the amount of ron you want to change ");
            Console.Write("\t\t\t");
            Double ron = Double.Parse(Console.ReadLine());
            Console.WriteLine("\t That will be " + soapClient.ConvertRontoEuro(ron).ToString("0.0000")
                + " euro");
            Console.ReadLine();
        }

        private void ConvertEuroToRon()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t Please enter the amount of euro you want to change ");
            Console.Write("\t\t\t");
            Double euro = Double.Parse(Console.ReadLine());
            Console.WriteLine("\t That will be " + soapClient.ConvertEuroToRon(euro).ToString("0.0000") 
                + " ron");
            Console.ReadLine();
        }

        private void Build5ItemList()
        {
            Console.WriteLine("\n\n\n");
            StringBuilder sb = new StringBuilder();
            sb.Append("\tThe list is:\n");
            List<String> list = soapClient.Build5ItemList();
            foreach (String item in list)
            {
                sb.Append("\n\t\t" + item);
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }

        private void DateTimeNow()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t The time right now is: " + soapClient.DateTimeNow().ToString());
            Console.ReadLine();
        }

        private void ConvertCF()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t Please enter the temperature in Fahrenheit ");
            Console.Write("\t\t\t");
            Double celsius = Double.Parse(Console.ReadLine());
            Console.WriteLine("\t The temperature in Celsius is: " + soapClient.ConvertCF(celsius).ToString("0.0000"));
            Console.ReadLine();
        }

        private void ConvertFC()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t Please enter the temperature in Fahrenheit ");
            Console.Write("\t\t\t");
            Double fahrenheit = Double.Parse(Console.ReadLine());
            Console.WriteLine("\t The temperature in Celsius is: " + soapClient.ConvertFC(fahrenheit).ToString("0.0000"));
            Console.ReadLine();
        }

        private void HelloWorld()
        {
            System.Console.WriteLine(soapClient.HelloWorld());
            Console.ReadLine();
        }
    }
}

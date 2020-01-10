using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator MyCalc = new Calculator();


            Console.WriteLine("###################################");
            Console.WriteLine("######## C# Calculator ############");
            Console.WriteLine("###################################");


            bool calcLoop = true;
            while (calcLoop == true)
            {
                Console.Write("\nEnter your first number:  ");
                double inputOne = Convert.ToDouble(Console.Readline());

                Console.Write("\nEnter your second number:  ");
                double inputTwo = Convert.ToDouble(Console.Readline());

                Console.WriteLine("\nMenu");
                Console.WriteLine("Enter 1 for addition");
                Console.WriteLine("Enter 2 for subtraction");
                Console.WriteLine("Enter 3 for multiplication");
                Console.WriteLine("Enter 4 for division");
                Console.WriteLine("");

                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        Console.WriteLine("\nYour answer is: " + MyCalc.Add(inputOne, inputTwo).ToString());
                        break;

                    case 2:
                        Console.WriteLine("\nYour answer is: " + MyCalc.Subtract(inputOne, inputTwo).ToString());
                        break;

                    case 3:
                        Console.WriteLine("\nYour answer is: " + MyCalc.Multiply(inputOne, inputTwo).ToString());
                        break;

                    case 4:
                        Console.WriteLine("\nYour answer is: " + MyCalc.Divide(inputOne, inputTwo).ToString());
                        break;
                    default:
                        Console.WriteLine("\nYou should enter a number from the menu.");
                        break;

                        Console.WriteLine("");
                        Console.Write("\nDo you want to try another sum? Y/N: ");
                        string restart = Console.ReadLine().ToUpper();

                        if (restartChoice =="Y")
                        {
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Press any key to exit")
                            calcLoop = false;

                        }

                }
                Console.ReadKey();







            }






        }
    }
}

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

            double answer ;
            string yayornay = "";

            do
            {

                Console.WriteLine("Please enter a left value");
                double lh = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Please enter a right value");
                double rh = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Which calculation would you like to perform?(Add, Subtract, Multiply, Power)");
                string userInput = Console.ReadLine();

                //double left= eq1.Left;
                //double right = eq1.Right;

                List<Equation> equations = new List<Equation>();
                Equation eq1 = new Equation(lh, rh);

                if (userInput == "add")
                {
                    answer = eq1.Add();
                }
                else if (userInput == "subtract")
                {
                    answer = eq1.Subtract();

                }
                else if (userInput == "multiply")
                {
                    answer = eq1.Multiply();

                }
                else if (userInput == "power")
                {
                    Console.WriteLine("What would you like to raise the power to?");
                    int toThePowerOf = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Left or Right");
                    string leftOrRight = Console.ReadLine().ToLower();

                    if (leftOrRight == "left")
                    {
                        answer = eq1.LeftToThePower(toThePowerOf);
                        //double power = Equations.LeftToThePower();


                    }
                    else if (leftOrRight == "right")
                    {
                        answer = eq1.RightToThePower(toThePowerOf);
                        //Console.WriteLine(Equation.RightToThePower()); 
                    }

                }
                else
                {
                    Console.WriteLine("You suck");
                }
                equations.Add($"{lh}{rh}+{answer}");


                

                Console.WriteLine("would you like to perform again?(Yes or No)");
                yayornay = Console.ReadLine().ToLower();

                Console.ReadKey();

            } while (yayornay=="yes"||yayornay=="y");
        }
    }
}
        

       

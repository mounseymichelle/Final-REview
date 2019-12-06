using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ANOTHERONE = "";
            double yeeeeeeee = 0;
            double addONprice = 0;
            double price = 0;
            double thatsalottaSHOTS = 0;

            List<double> bill = new List<double>();

            do
            {
                Console.WriteLine("Say hello to begin");
                string hllo = Console.ReadLine().ToLower();
                if (hllo == "hello")
                {
                    Console.WriteLine("Hello! Please buy my coffee");
                    Console.WriteLine("Espresso $2.15");
                    Console.WriteLine("Cappuccino $4.20");
                    Console.WriteLine("Americano $3.55");
                    Console.WriteLine("Latte $5.00");
                    Console.WriteLine("Drip $1.25");

                    Console.WriteLine("Please pick a drink");
                    
                    string drink = Console.ReadLine().ToLower();
                        if (drink == "espresso")
                    {
                        price = 2.15;
                    }
                        else if (drink == "cappuccino")
                    {
                        price = 4.20;
                    }
                        else if (drink == "latte")
                    {
                        price = 5.00;
                    }
                        else if (drink == "americano")
                    {
                        price = 3.55;
                    }
                        else if (drink == "drip")
                    {
                        price = 1.25;
                    }
                        else
                    {
                        Console.WriteLine("dude pick a drink!!");
                    }
                    bill.Add(price);


                    Console.WriteLine("For an additional cost, we offer add ons.");
                    Console.WriteLine("Shot of Vanilla $0.75");
                    Console.WriteLine("Shot of Espresso $0.80");
                    Console.WriteLine("TWO SHOTS OF VODKA $$FREE$$");
                    Console.WriteLine("Are you interested???");
                    string addOns = Console.ReadLine().ToLower();
                    
                    if (addOns == "yes" || addOns == "y")
                    {
                        Console.WriteLine("What do u want, fool?(Vanilla, Espresso, or the obvious answer-VODKA)");
                        string yesAddon = Console.ReadLine().ToLower();
                        
                        if (yesAddon == "vanilla")
                        {
                            addONprice = .75;
                        }
                        else if (yesAddon == "espresso")
                        {
                            addONprice = .80;
                        }
                        else if (yesAddon == "vodka")
                        {
                            addONprice = 0;
                        }
                        else
                        {
                            Console.WriteLine("You should probably just go to starbucks");
                        }
                        

                        Console.WriteLine("How many shots?(HINT: if you want vodka, the answer is 2)");
                        thatsalottaSHOTS = Convert.ToDouble(Console.ReadLine());

                        yeeeeeeee = addONprice * thatsalottaSHOTS;

                        bill.Add(yeeeeeeee);


                    }
                    Console.WriteLine("I assume you want some more coffee to go with your vodka?");
                    ANOTHERONE = Console.ReadLine().ToLower();
                    

                }

            } while (ANOTHERONE == "yes") ;
            double ordertotal = price + yeeeeeeee;
                Console.WriteLine($"your total: {ordertotal}");
                Console.WriteLine($"shots: Quantity: {thatsalottaSHOTS} and price:{addONprice} for {yeeeeeeee}");
                Console.WriteLine($"coffee:{drink} {price}");
                Console.ReadLine();
            
            }
    }
}

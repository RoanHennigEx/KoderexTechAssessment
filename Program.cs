using KoderexTechAssessment.VendingMachine;
using System;
using System.Linq;

namespace KoderexTechAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the coin denomination seperated by commas in order to process a sale:");           
            var coinDenominations = Array.ConvertAll(Console.ReadLine().Split(','),
                                                    s => !decimal.TryParse(s, out decimal coin) ? PrintErrorAndExit() : coin / 100);

            var purchaseAmount = DecimalInput("Please input your purchase amount");
            var tenderAmount = DecimalInput("Please input your tender amount");
            
            if(purchaseAmount > tenderAmount)
            {
                  PrintErrorAndExit();
            }

            var machine = new AcmeVendingMachine(coinDenominations.ToList());
            var change = machine.CalculateChange(purchaseAmount, tenderAmount);

            foreach(var coin in change)
            {
                Console.WriteLine(coin);
            }

            Console.ReadLine();
        }

        static int PrintErrorAndExit()
        {
            Console.WriteLine("Invalid input - press any key to exit");
            Console.ReadLine();
            Environment.Exit(-1);

            return 0;
        }

        static decimal DecimalInput(string prompt)
        {
            Console.WriteLine(prompt);
            if (!decimal.TryParse(Console.ReadLine(), out decimal output))
            {
                PrintErrorAndExit();
            }

            return output;
        }
    }
}

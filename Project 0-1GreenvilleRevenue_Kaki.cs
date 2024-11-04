using System;

namespace GreenvilleRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            
            while (continueProgram)
            {
                DisplayMotto();

                Console.WriteLine("Please Enter the following number below from the following menu:");
                Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
                Console.WriteLine("2. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CalculateRevenue();
                        break;
                    case "2":
                        Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        break;
                }
            }
        }

        static void DisplayMotto()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*  The stars shine in Greenville.  *");
            Console.WriteLine("************************************");
        }

        static void CalculateRevenue()
        {
            Console.WriteLine("Enter the number of contestants from last year:");
            int lastYearContestants = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of contestants for this year:");
            int thisYearContestants = int.Parse(Console.ReadLine());

            int revenueThisYear = thisYearContestants * 25;

            Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants.");
            Console.WriteLine($"Revenue expected this year is ${revenueThisYear}");

            if (thisYearContestants > lastYearContestants)
            {
                Console.WriteLine("It is true that this year's competition is bigger than last year's.");
            }
            else
            {
                Console.WriteLine("It is false that this year's competition is bigger than last year's.");
            }

            Console.WriteLine();
        }
    }
}

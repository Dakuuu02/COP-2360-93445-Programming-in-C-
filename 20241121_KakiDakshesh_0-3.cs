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
                Console.WriteLine("1. CALCULATE Greenville Idol Revenue Year-Over-Year");
                Console.WriteLine("2. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CalculateRevenue();
                        break;
                    case "2":
                        Console.WriteLine("Thank you for using the Greenville Idol App, good-bye!");
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
            int lastYearContestants = GetContestantCount("last year");
            int thisYearContestants = GetContestantCount("this year");

            int revenueThisYear = thisYearContestants * 25;

            Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants.");
            Console.WriteLine($"Revenue expected this year is ${revenueThisYear}");

            if (thisYearContestants == 2 * lastYearContestants)
            {
                Console.WriteLine("The competition is more than twice as big this year!");
            }
            else if (thisYearContestants > lastYearContestants)
            {
                Console.WriteLine("The competition is bigger than ever!");
            }
            else
            {
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");
            }

            Console.WriteLine();
        }

        static int GetContestantCount(string year)
        {
            int contestants;
            while (true)
            {
                Console.WriteLine($"Enter the number of contestants for {year} (between 0 and 30):");
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out contestants) && contestants >= 0 && contestants <= 30)
                {
                    return contestants;
                }
                else
                {
                    Console.WriteLine("Invalid number. Please enter a number between 0 and 30.");
                }
            }
        }
    }
}

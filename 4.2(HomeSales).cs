using System;

class HomeSales
{
    static void Main()
    {
        double dTotal = 0;
        double eTotal = 0;
        double fTotal = 0;
        double grandTotal = 0;
        
        while (true)
        {
            Console.Write("Enter Salesperson Initial (D, E, F) or Z to exit: ");
            string input = Console.ReadLine();

            if (input.Equals("Z", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            char initial;
            if (input.Length != 1 || !char.TryParse(input, out initial) || "DEFdef".IndexOf(initial) == -1)
            {
                Console.WriteLine("Error, invalid salesperson selected, please try again");
                continue; 
            }

            Console.Write($"Enter amount for salesperson {initial}: ");
            double saleAmount;
            if (!double.TryParse(Console.ReadLine(), out saleAmount))
            {
                continue;
            }

            switch (char.ToUpper(initial))
            {
                case 'D':
                    dTotal += saleAmount;
                    break;
                case 'E':
                    eTotal += saleAmount;
                    break;
                case 'F':
                    fTotal += saleAmount;
                    break;
            }

            grandTotal += saleAmount;
        }

        Console.WriteLine("Sales Totals:");
        Console.WriteLine($"Salesperson D: {dTotal:C}");
        Console.WriteLine($"Salesperson E: {eTotal:C}");
        Console.WriteLine($"Salesperson F: {fTotal:C}");
        Console.WriteLine($"Grand Total: {grandTotal:C}");

        double highestTotal = Math.Max(dTotal, Math.Max(eTotal, fTotal));
        string highestSalesperson;

        if (highestTotal == dTotal)
        {
            highestSalesperson = "Salesperson D";
        }
        else if (highestTotal == eTotal)
        {
            highestSalesperson = "Salesperson E";
        }
        else
        {
            highestSalesperson = "Salesperson F";
        }

        Console.WriteLine($"Highest Salesperson: {highestSalesperson} with total {highestTotal:C}");
    }
}

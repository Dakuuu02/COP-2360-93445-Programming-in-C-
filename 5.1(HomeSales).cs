using System;

class HomeSales
{
    static void Main()
    {
        string[] salespersonNames = { "Danielle", "Edward", "Francis" };
        char[] salespersonInitials = { 'D', 'E', 'F' };
        double[] salesTotals = new double[salespersonNames.Length];

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
                Console.WriteLine("Invalid amount entered, please try again.");
                continue;
            }

            int index = Array.IndexOf(salespersonInitials, char.ToUpper(initial));
            if (index != -1)
            {
                salesTotals[index] += saleAmount;
                grandTotal += saleAmount;
            }
        }

        Console.WriteLine("Sales Totals:");
        for (int i = 0; i < salespersonNames.Length; i++)
        {
            Console.WriteLine($"Salesperson {salespersonInitials[i]} ({salespersonNames[i]}): {salesTotals[i]:C}");
        }
        Console.WriteLine($"Grand Total: {grandTotal:C}");

        double highestTotal = salesTotals[0];
        int highestIndex = 0;
        for (int i = 1; i < salesTotals.Length; i++)
        {
            if (salesTotals[i] > highestTotal)
            {
                highestTotal = salesTotals[i];
                highestIndex = i;
            }
        }

        Console.WriteLine($"Highest Salesperson: Salesperson {salespersonInitials[highestIndex]} ({salespersonNames[highestIndex]}) with total {highestTotal:C}");
    }
}

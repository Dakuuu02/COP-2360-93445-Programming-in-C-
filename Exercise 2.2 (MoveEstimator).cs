using System;

class MoveEstimator
{
    static void Main()
    {
        const double BASE_RATE = 200.0;
        const double HOURLY_RATE = 150.0;
        const double MILEAGE_RATE = 2.0;
        
        double hours, miles, totalCost;

        Console.Write("Enter the number of hours: ");
        hours = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the number of miles: ");
        miles = Convert.ToDouble(Console.ReadLine());

        totalCost = BASE_RATE + (hours * HOURLY_RATE) + (miles * MILEAGE_RATE);

        Console.WriteLine($"Total moving cost is: ${totalCost:F2}");
    }
}

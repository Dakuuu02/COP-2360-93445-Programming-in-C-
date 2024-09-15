using System;

class InchesToCentimetersInteractive
{
    static void Main()
    {
        // Constant for conversion factor
        const double centimetersPerInch = 2.54;

        // Ask for user input
        Console.Write("Enter a value in inches: ");
        double inches = Convert.ToDouble(Console.ReadLine());

        // Convert inches to centimeters
        double centimeters = inches * centimetersPerInch;

        // Display the result
        Console.WriteLine($"{inches} inches is {centimeters} centimeters");
    }
}

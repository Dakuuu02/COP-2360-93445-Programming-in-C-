using System;

class InchesToCentimetersInteractive
{
    static void Main()
    {
        const double centimetersPerInch = 2.54;

        Console.Write("Enter a value in inches: ");
        double inches = Convert.ToDouble(Console.ReadLine());

        double centimeters = inches * centimetersPerInch;

        Console.WriteLine($"{inches} inches is {centimeters} centimeters");
    }
}

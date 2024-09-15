using System;

class InchesToCentimeters
{
    static void Main()
    {
        const double centimetersPerInch = 2.54;
        
        double inches = 5; 

        double centimeters = inches * centimetersPerInch;

        Console.WriteLine($"{inches} inches is {centimeters} centimeters");
    }
}

using System;

class Hurricane
{
    static void Main()
    {
        Console.Write("Enter Wind Speed (MPH) : ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double windSpeed))
        {
            string category = ClassifyHurricane(windSpeed);
            Console.WriteLine($"{category}");
        }
    }

    static string ClassifyHurricane(double windSpeed)
    {
        if (windSpeed < 74)
        {
            return "Not a Hurricane";
        }
        else if (windSpeed < 96)
        {
            return "Category One Hurricane";
        }
        else if (windSpeed < 111)
        {
            return "Category Two Hurricane";
        }
        else if (windSpeed < 130)
        {
            return "Category Three Hurricane";
        }
        else if (windSpeed < 157)
        {
            return "Category Four Hurricane";
        }
        else
        {
            return "Category Five Hurricane";
        }
    }
}

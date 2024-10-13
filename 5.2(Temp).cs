using System;

class TemperaturesComparison
{
    static void Main()
    {
        double[] temperatures = new double[5];
        int index = 0;

        while (index < 5)
        {
            try
            {
                Console.Write("Enter a temperature between -30 and 130: ");
                if (double.TryParse(Console.ReadLine(), out double temp))
                {
                    if (temp < -30 || temp > 130)
                    {
                        throw new ArgumentOutOfRangeException(nameof(temp), $"Temperature {temp} is invalid. Please enter a valid temperature between -30 and 130.");
                    }

                    temperatures[index] = temp;
                    index++;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        bool isGettingWarmer = true;
        bool isGettingCooler = true;

        for (int i = 1; i < temperatures.Length; i++)
        {
            if (temperatures[i] <= temperatures[i - 1])
            {
                isGettingWarmer = false;
            }
            if (temperatures[i] >= temperatures[i - 1])
            {
                isGettingCooler = false;
            }
        }

        if (isGettingWarmer)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (isGettingCooler)
        {
            Console.WriteLine("Getting cooler");
        }
        else
        {
            Console.WriteLine("It's a mixed bag");
        }

        Console.WriteLine("5-day Temperature: [" + string.Join(", ", temperatures) + "]");

        double sum = 0;
        foreach (double temp in temperatures)
        {
            sum += temp;
        }
        double average = sum / temperatures.Length;
        Console.WriteLine($"Average Temperature is {average:F1} degrees");
    }
}

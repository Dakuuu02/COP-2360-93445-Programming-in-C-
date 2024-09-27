using System;

class Perfect
{
    static void Main()
    {
        Console.Write("Enter Number");
        long number = long.Parse(Console.ReadLine());

        if (IsPerfect(number))
        {
            Console.WriteLine("Perfect number");
        }
        else
        {
            Console.WriteLine("Not A Perfect Number");
        }
    }
    static bool IsPerfect(long number)
    {
        long sum = 0;

        for (long i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        return sum == number;
    }
}

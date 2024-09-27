using System;

class Perfect
{
    static void Main()
    {
        Console.Write("Enter Number");
        int number = int.Parse(Console.ReadLine());

        if (IsPerfect(number))
        {
            Console.WriteLine("Perfect number");
        }
        else
        {
            Console.WriteLine("Not A Perfect Number");
        }
    }
    static bool IsPerfect(int number)
    {
        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        return sum == number;
    }
}

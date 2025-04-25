
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter your number:");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isprime = true;
        if (number < 2)
        {
            isprime = false;
        }
        else
        {
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
        }
        if (isprime)
            Console.WriteLine($"{number} is a prime number");
        else
            Console.WriteLine($"{number} is not a prime number");
    }
}



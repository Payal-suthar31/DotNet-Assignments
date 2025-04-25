using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter your number:");
        int number = Convert.ToInt32(Console.ReadLine());
        {
            if (number % 2 == 0)
                Console.WriteLine($"Even number is {number}");

            else
                Console.WriteLine($"Odd number is {number}");
        }

    }
}
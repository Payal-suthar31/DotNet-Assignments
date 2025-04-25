using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter your number:");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number}*{i}={number * i}");
        }
    }
}


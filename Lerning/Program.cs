using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter first number:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second number:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Sum: {a + b}");

    }
}
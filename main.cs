using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("MATANDA KA NA.");
        }
        else
        {
            Console.WriteLine("BATA KA PA.");
        }
    }
}
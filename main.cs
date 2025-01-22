using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are not an adult.");
        }
    }
}
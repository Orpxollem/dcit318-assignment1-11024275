using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your age:");

        try
        {
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("Age cannot be negative.");
            }
            else if (age <= 12 || age >= 65)
            {
                Console.WriteLine("Your age qualifies you for a ticket discount.");
                Console.WriteLine("Ticket Price: GHC7");
            }
            else
            {
                Console.WriteLine("Ticket Price: GHC10");
            }
        }
        catch
        {
            Console.WriteLine("Please enter a valid age in numerical form.");
        }
    }
}

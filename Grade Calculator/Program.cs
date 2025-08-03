using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter a numerical in the range 0 to 100");

        try
        {
            double grade = Convert.ToDouble(Console.ReadLine());

            if (grade >= 90 && grade < 100)
                Console.WriteLine("Grade : A");
            else if (grade >= 80 && grade < 90)
                Console.WriteLine("Grade : B");
            else if (grade >= 70 && grade < 80)
                Console.WriteLine("Grade : C");
            else if (grade >= 60 && grade < 70)
                Console.WriteLine("Grade : D");
            else if (grade >= 0 && grade < 60)
                Console.WriteLine("Grade : F");
            else
                Console.WriteLine("Kindly ensure the number provided is in the range 0 - 100");
        }
        catch
        {
            Console.WriteLine("Kindly input a valid number in the range 0 - 100");
        }

    }
}
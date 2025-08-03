using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the sides of the triangle:");

        try
        {
            Console.Write("Side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side C: ");
            double sideC = Convert.ToDouble(Console.ReadLine());

            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.WriteLine("Length inputs must be positive numbers.");
                return;
            }

            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                if (sideA == sideB && sideB == sideC)
                    Console.WriteLine("Equilateral Triangle");
                else if (sideA == sideB || sideA == sideC || sideB == sideC)
                    Console.WriteLine("Isosceles Triangle");
                else
                    Console.WriteLine("Scalene Triangle");
            }
            else
            {
                Console.WriteLine("The lengths entered do not form a valid triangle.");
            }
        }
        catch
        {
            Console.WriteLine("Length inputs must be numbers.");
        }
    }
}

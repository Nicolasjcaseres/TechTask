using System;

namespace Triangle
{
    class Program
    {  
        static void Main(string[] args)
        {
            Console.Write("Enter Coordinate x of dot A: ");
            double ax = double.Parse(Console.ReadLine());
            Console.Write("Enter Coordinate y of dot A: ");
            double ay = double.Parse(Console.ReadLine());
            Console.Write("Enter Coordinate x of dot B: ");
            double bx = double.Parse(Console.ReadLine());
            Console.Write("Enter Coordinate y of dot B: ");
            double by = double.Parse(Console.ReadLine());
            Console.Write("Enter Coordinate x of dot C: ");
            double cx = double.Parse(Console.ReadLine());
            Console.Write("Enter Coordinate y of dot C: ");
            double cy = double.Parse(Console.ReadLine());

            double sideAB = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
            double sideBC = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
            double sideAC = Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2));

            double perimeter = sideAB + sideAC + sideBC;

            Console.WriteLine($"Length of AB is: '{sideAB}'");
            Console.WriteLine($"Length of BC is: '{sideBC}'");
            Console.WriteLine($"Length of AC is: '{sideAC}'");

            double delta = 0.001;
            double hypotenuse = Math.Max(sideAB, Math.Max(sideAC, sideBC));

            if (sideAB == sideAC && sideAB == sideBC)
            {
                Console.WriteLine($"Triangle IS 'Equilateral'");
            }
            else
            {
                Console.WriteLine($"Triangle IS NOT 'Equilateral'");
            }

            if (sideAB == sideAC || sideAB == sideBC || sideAC == sideBC)
            {
                Console.WriteLine($"Triangle IS 'Isosceles'");
            }
            else
            {
                Console.WriteLine($"Triangle IS NOT 'Isosceles'");
            }

            if (Math.Abs(Math.Pow(hypotenuse, 2) - Math.Pow(sideAB, 2) - Math.Pow(sideAC, 2)) <= delta)
            {
                Console.WriteLine($"Triangle IS 'Right'");
            }
            else
            {
                Console.WriteLine($"Triangle IS NOT 'Right'");
            }

            Console.WriteLine($"Perimeter '{perimeter}'");

            Console.WriteLine($"Parity numbers in range from 0 to triangle perimeter:");
            for (int i = 0; i <= perimeter; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }

            Console.ReadKey();
        }
    }
}
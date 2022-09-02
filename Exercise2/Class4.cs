using System;

namespace Exercise2
{
    internal class Class4
    {
        public static void Main2()
        {
            Console.Write("Input the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
                Console.WriteLine($"{year} is a leap year.");
            else if(year % 100 == 0)
                Console.WriteLine($"{year} is not a leap year.");
            else if(year % 4 == 0)
                Console.WriteLine($"{year} is a leap year.");
            else
                Console.WriteLine($"{year} is not a leap year.");

            Console.ReadKey();
        }
    }
}

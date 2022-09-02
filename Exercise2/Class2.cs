using System;

namespace Exercise2
{
    internal class Class2
    {
        public static void Main2()
        {
            Console.Write("Input the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"{num} is an even integer.");
            else
                Console.WriteLine($"{num} is an odd integer.");

            Console.ReadKey();
        }
    }
}

using System;

namespace Exercise2
{
    internal class Class3
    {
        public static void Main2()
        {
            Console.Write("Input the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
                Console.WriteLine($"{num} is a positive integer.");
            else
                Console.WriteLine($"{num} is a negative integer.");
            Console.ReadKey();
        }
    }
}

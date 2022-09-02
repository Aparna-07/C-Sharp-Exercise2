using System;

namespace Exercise2
{
    internal class Class6
    {
        public static void Main2()
        {
            int n;
            Console.Write("Enter the value of m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m > 0)
                n = 1;
            else if (m < 0)
                n = -1;
            else
                n = 0;
            Console.WriteLine($"The value of n = {n}");
            Console.ReadKey();
        }
    }
}

using System;

namespace Exercise2
{
    internal class Class20
    {
        public static void Main2()
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int k = n - i; k >= 1; k--)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

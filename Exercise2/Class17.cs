using System;

namespace Exercise2
{
    internal class Class17
    {
        public static void Main2()
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(i);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

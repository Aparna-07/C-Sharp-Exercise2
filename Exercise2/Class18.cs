using System;

namespace Exercise2
{
    internal class Class18
    {
        public static void Main2()
        {
            int count = 1, n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

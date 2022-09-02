using System;

namespace Exercise2
{
    internal class Class12
    {
        public static void Main2()
        {
            Console.Write("Input the number (Table to be calculated) : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i =1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num*i}");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Class13
    {
        public static void Main2()
        {
            Console.Write("Input upto the table number starting from 1 : ");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication table from 1 to 8");

            for (int i = 1; i <= 10; i++)
            {
                for(int j = 1; j < count; j++)
                    Console.Write($"{j} x {i} = {i * j}, ");
                Console.WriteLine($"{count} x {i} = {i * count}");
            }

            Console.ReadKey();
        }
    }
}

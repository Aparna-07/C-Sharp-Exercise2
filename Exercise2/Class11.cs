using System;

namespace Exercise2
{
    internal class Class11
    {
        public static void Main2()
        {
            Console.Write("Input the number of terms : ");
            int count = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Number is : {i} and the cube of {i} is : {i * i * i}");
            }
            Console.ReadKey();
        }
    }
}

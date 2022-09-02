using System;

namespace Exercise2
{
    internal class Class14
    {
        public static void Main2()
        {
            int sum = 0;
            Console.Write("Input the number of terms : ");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.Write("The odd numbers are :");
            for(int i = 1; i < 2 * count; i += 2)
            {
                Console.Write(" " + i);
                sum += i;
            }
            Console.WriteLine($"\nThe sum of odd natural numbers upto {count} terms : {sum}");
            Console.ReadKey();
        }
    }
}

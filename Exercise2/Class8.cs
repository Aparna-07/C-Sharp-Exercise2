using System;

namespace Exercise2
{
    internal class Class8
    {
        public static void Main2()
        {
            Console.Write("Input the 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 2nd number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
                Console.WriteLine("The numbers are equal.");
            else if (num1 > num2 && num1 > num3)
                Console.WriteLine("The 1st number is the greatest among the three.");
            else if (num2 > num3)
                Console.WriteLine("The 2nd number is the greatest among the three.");
            else
                Console.WriteLine("The 3rd number is the greatest among the three.");

            Console.ReadKey();
        }
    }
}

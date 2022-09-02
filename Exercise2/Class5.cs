using System;

namespace Exercise2
{
    internal class Class5
    {
        public static void Main2()
        {
            Console.Write("Input your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
                Console.WriteLine("Congratulations! You are eligible for casting your vote");
            else
                Console.WriteLine("Sorry, you are not eligible for voting");
            Console.ReadKey();
        }
    }
}

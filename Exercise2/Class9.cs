using System;

namespace Exercise2
{
    internal class Class9
    {
        public static void Main2()
        {
            Console.Write("Input the value for X coordinate : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for Y coordinate : ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            else if (x < 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            else if (x < 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            if (x > 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");

            Console.ReadKey();
        }
    }
}

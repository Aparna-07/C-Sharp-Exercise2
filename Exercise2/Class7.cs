using System;

namespace Exercise2
{
    internal class Class7
    {
        public static void Main2()
        {
            Console.Write("Input the height of the person: ");
            int height = Convert.ToInt32(Console.ReadLine());
            if (height <= 145)
                Console.WriteLine("The person is Dwarf");
            else if(height >145 && height <= 165)
                Console.WriteLine("The person is Medium Height");
            else if(height>165)
                Console.WriteLine("The person is Tall");

            Console.ReadKey();
        }
    }
}

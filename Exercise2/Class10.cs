using System;

namespace Exercise2
{
    internal class Class10
    {
        public static void Main2()
        {
            Console.Write("Input the marks obtained in Physics : ");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry : ");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics : ");
            int maths = Convert.ToInt32(Console.ReadLine());

            int totalAll = maths + physics + chemistry;
            int totalMathChem = maths + chemistry;
            int totalMathPhy = maths + physics;

            if ((maths >= 65 && physics >= 55 && chemistry >= 50) || totalAll >= 180 || totalMathChem >= 140 || totalMathPhy >= 140)
                Console.WriteLine("The candidate is eligible for admission.");
            else
                Console.WriteLine("The candidate is not eligible for admission.");

            Console.ReadKey();
        }
    }
}

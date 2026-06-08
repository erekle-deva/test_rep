using System;

namespace Item_10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("program hypotenuse of triangle");
            Console.WriteLine("//////////////////////////");
            Console.WriteLine("__________________________");

            Console.WriteLine("Enter side A: ");
            double side_a = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter side B: ");
            double side_b = Convert.ToDouble(Console.ReadLine());


            double hypotenuse_num;
            hypotenuse_num = Math.Sqrt(Math.Pow(side_a, 2) + Math.Pow(side_b, 2));


            Console.WriteLine($"the hypotenuse is: {hypotenuse_num}");











        }
    }
}
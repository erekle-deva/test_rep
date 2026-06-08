using System;


namespace Item_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey");

            double x = 3;
            double x2 = -4;
            double x3 = 3.14;

            double y = 3.99;
            double z = 5;

            double num_1 = Math.Pow(x, 2);

            Console.WriteLine(num_1);

            double num_2 = Math.Sqrt(x);
            Console.WriteLine(num_2);

            double num_3 = Math.Abs(x2);
            Console.WriteLine(num_3);

            double num_4 = Math.Round(x3);
            Console.WriteLine(num_4);

            double num_5 = Math.Ceiling(x3);
            Console.WriteLine(num_5);

            double num_6 = Math.Floor(x3);
            Console.WriteLine(num_6);

            Console.WriteLine("max function //");

            double num_7 = Math.Max(y, z);
            Console.WriteLine(num_7);


            Console.WriteLine("min function//");

            double num_8 = Math.Min(y, z);
            Console.WriteLine(num_8);















        }
    }
}
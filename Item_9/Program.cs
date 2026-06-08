using System;

namespace Item_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey");


            Random rand_1 = new Random();
            Random rand_2 = new Random();


            int num_1 = rand_1.Next(1, 21);
            Console.WriteLine(num_1);


            double num_2 = rand_2.NextDouble();
            Console.WriteLine(num_2);




            Console.WriteLine("make 3 rand nums//");

            Random rand_3 = new Random();

            int num1 = rand_3.Next(1, 25);
            int num2 = rand_3.Next(1, 25);
            int num3 = rand_3.Next(1, 25);

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);















        }
    }
}
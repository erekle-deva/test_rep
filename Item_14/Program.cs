using System;


namespace Item_14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hey");


            Console.WriteLine("what is temperature outside: (c)");
            double temp = Convert.ToDouble(Console.ReadLine());



            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("its warm outside!!");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("dont go outside!!!!!!");

            }




        }
    }
}
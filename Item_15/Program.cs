using System;


namespace Item_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey");


            String name = "";


            while (name == "")
            {

                Console.WriteLine("noo enter your name: ");
                name = Console.ReadLine();


            }

            Console.WriteLine($"hello {name}");




        }
    }
}
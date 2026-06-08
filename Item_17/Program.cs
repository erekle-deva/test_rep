using System;

namespace Item_17
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hey");

            Console.WriteLine("HOW many rows?:");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("how many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("what symbol: ");
            string symbol = Console.ReadLine();



            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {

                    Console.Write(symbol);

                }

                Console.WriteLine();

            }







        }
    }
}
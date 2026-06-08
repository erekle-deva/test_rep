using System;
using System.Diagnostics.SymbolStore;



namespace Item_5
{

    class Program
    {
        static void Main(string[] args)
        {


                // variables


            Console.WriteLine("hey hey hey");



            /*            int x;

                        x = 123;

                        int y = 321;

                        int z = x + y;

                        Console.WriteLine(x);
                        Console.WriteLine(y);
                        Console.WriteLine(z);

                        Console.WriteLine($"{x}, {y}, {z}");

                        Console.WriteLine(x + y + z);


                        double height;

                        height = 192.78;

                        Console.WriteLine("height is " + height + "cm");*/


            string name;
            int age;
            double height;
            bool alive;
            char symbol;

            name = "erekle";
            age = 23;
            height = 182.999;
            alive = true;
            symbol = '%';


            Console.WriteLine($"your name is {name}");
            Console.WriteLine("your age is " + age);
            Console.WriteLine("your heigh is " + height);
            Console.WriteLine("are you alive? " + alive);
            Console.WriteLine("your symbol is " + symbol);

            Console.WriteLine("username -- " + name + symbol);

















        }
    }

}
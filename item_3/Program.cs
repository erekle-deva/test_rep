using System;


namespace item_3
{
    class Program
    {
        static void Main(string[] args)
        {



            int x; // declaration
            x = 123; // initialization


            int y = 321;

            int z = x + y;


            int age = 23; // whole integer
            double height = 183.5; // decimal number
            bool alive = true; // true or false0
            char symbol = '@';
            string name = "erekle";




            Console.WriteLine("my age is " + age);
            Console.WriteLine("my height is " + height + "cm");
            Console.WriteLine("are you alive -- " + alive);
            Console.WriteLine("your symbol -- " + symbol);
            Console.WriteLine("hello " + name);


            string username = symbol + name;
            Console.WriteLine(username);


            const double pi = 3.14159;

            // pi = 420;


            Console.WriteLine(pi);



           

        }
    }
}
using System;


namespace Item_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("whats is your name ");

            string name;
            name = Console.ReadLine();

            Console.WriteLine("what is your age ");
            int age;
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hello " + name);

            Console.WriteLine("ypur age is " + age);





        }
    }
}
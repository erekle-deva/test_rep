using System;

namespace Item_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey");

            Console.WriteLine("Please enter your age: ");
            int age;
            age = Convert.ToInt32(Console.ReadLine());

            if (age > 100)
            {
                Console.WriteLine("you are too old!!!!!! go to your fucking way to dig a grave");
            }
            else if (age >=18)
            {
                Console.WriteLine("you are allowed");

            }
            else if (age < 0)
            {
                Console.WriteLine("you arenot born yet!!!!! go back your mothers ass");
            }
            else
            {
                Console.WriteLine("you are not allowed, you must be 18 old");
            }



            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();


            if (name != "")
            {

                Console.WriteLine($"hello my {name}");
            }
            else
            {
                Console.WriteLine("you did not enter your name");

            }





        }

    }
}
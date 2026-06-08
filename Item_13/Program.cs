using System;


namespace Item_13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hey");


            Console.WriteLine("what day is it today?: ");
            string day = Console.ReadLine();


            switch (day)
            {
                case "monday":
                    Console.WriteLine("its monday");
                    break;

                case "thuesday":
                    Console.WriteLine("its thuesday");
                    break;

                case "wednesday":
                    Console.WriteLine("its wednesday");
                    break;

                case "thursday":
                    Console.WriteLine("its thursday");
                    break;

                case "friday":
                    Console.WriteLine("its friday");
                    break;

                case "saturday":
                    Console.WriteLine("its saturday");
                    break;

                case "sunday":
                    Console.WriteLine("its sunday");
                    break;

                default:
                    Console.WriteLine($"{day} is not a day you fucking idiot");
                    break;




            }



        }
    }
}
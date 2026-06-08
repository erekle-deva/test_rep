using System;


namespace Numberguess
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Number guessing game, wish you well");

            Console.WriteLine("Please enter range start point to number scale: ");
            int startNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter range end point to number scale: ");
            int endNum = Convert.ToInt32(Console.ReadLine());



            Random rand_1 = new Random();

            int guessNum = rand_1.Next(startNum, endNum);


            Console.WriteLine("okay, range taken, guess number now exist");
            Console.WriteLine("now please enter your guess: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int counter = 1;


            while (userNum != guessNum)
            {

                Console.WriteLine("guess incorect:((, try again");
                Console.WriteLine("enter guess: ");
                userNum = Convert.ToInt32(Console.ReadLine());
                counter += 1;
            }


            Console.WriteLine("G R E A T,      C O N G R A T, guess is correct!!!!!");
            Console.WriteLine($"you need {counter} try");


        }


    }
}
using System;


namespace numberGuess_2
{
    class Program
    {

        static void Main(string[] args)
        {

            Random rand_1 = new Random();

            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;


            while (playAgain)
            {

                guess = 0;
                guesses = 0;
                response = "";
                number = rand_1.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine($"guess a number {min} - {max} :");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Guess: {guess}");

                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is too high");

                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"{guess} is too low");
                    }
                    guesses++;
                }

                Console.WriteLine($"number: {number}");
                Console.WriteLine("you win !!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine($"guesses: {guesses}");

                Console.WriteLine("would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();


                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }


            }

            Console.WriteLine("thanks for playing ");


        }

    }
}
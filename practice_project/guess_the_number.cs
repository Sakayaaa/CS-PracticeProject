using System;

namespace practice_project
{
    class guess_the_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess The Number!");

            Random random = new Random();

            bool playAgain = true;
            int min = 1;
            int max = 10;
            int guess;
            int number;
            int guesses;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.Write("Guess a Number between " + min + " and " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guessed Number: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine("Guess a lower number!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Guess a higher number!");
                    }
                    guesses++;
                    Console.WriteLine("--------------------------");

                }
                Console.WriteLine("Correct! The number was: " + number);
                Console.WriteLine("Your had " + guesses + " guesses!");
                guesses = 0;


                bool gave_answer = false;
                while (gave_answer == false)
                {
                    Console.Write("Would you like to play again?");
                    Console.WriteLine();
                    String answer;
                    answer = Console.ReadLine().ToUpper();

                    if (answer == "YES")
                    {
                        playAgain = true;
                        gave_answer = true;
                    }
                    else if (answer == "NO")
                    {
                        playAgain = false;
                        gave_answer = true;
                    }
                    else
                    {
                        Console.WriteLine("Please type Yes OR No: ");
                    }
                }
            }
        }
    }
}
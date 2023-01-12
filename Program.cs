namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            int guess;
            int guesses;
            int min = 1;
            int max = 15;
            bool playAgain = true;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max);

                while (guess != number)
                {
                    Console.Write("Please enter a number between {0} - {1}: ", min, max);
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess < number)
                    {
                        Console.WriteLine("Your number is too low!");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("You number is too high!");
                    }
                    else
                    {
                        Console.WriteLine("You won! Good job!");
                    }
                    guesses++;
                }
                Console.WriteLine("Your number of guesses was: {0}", guesses);
                Console.WriteLine("Do you want to play again? (Y/N)");
                String response = Console.ReadLine();
                response = response.ToUpper();
              
                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    playAgain = false;
                }
            }
        }
    }

 }
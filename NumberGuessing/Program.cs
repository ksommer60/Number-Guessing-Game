using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Wait for the prompt to enter in a number!");
            NumberGenerator();
        }

        static void NumberGenerator()
        {
            Random randomNumber = new Random();
            int winningNumber = randomNumber.Next(0, 100);
            bool win = false;

            do
            {
                Console.WriteLine("Guess a number inbetween 0 and 100");
                string userInput = Console.ReadLine();

                int number = int.Parse(userInput);
                int numberDifference = winningNumber - number; //display what the difference in the numbers is 

                if (number > winningNumber)
                {
                    Console.WriteLine("Your guess was off by " + numberDifference);
                }
                else if (number < winningNumber)
                {
                    Console.WriteLine("Your guess was off by " + numberDifference);
                }
                else
                {
                    Console.WriteLine("You win!!");
                    win = true;
                }

            } while (win == false);
        }
    }
}

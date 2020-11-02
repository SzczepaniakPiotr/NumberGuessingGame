using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guesss the number between 0 and 100");
            int lives = 10;
            int guess;
            Random rnd = new Random();
            int number = rnd.Next(0, 100);
            do
            {
                if (lives<=0)
                {
                    Console.WriteLine("Out of lives");
                    break;
                }
                Console.WriteLine("You have "+lives+" lives left");
                Console.Write("Guess the number: ");
                guess=int.Parse(Console.ReadLine());
                if (guess==number)
                {
                    Console.WriteLine("Congratulations! You guessed the number");
                    break;
                }
                else if (guess>number)
                {
                    lives--;
                    Console.WriteLine("The number is smaller than your guess");
                }
                else if (guess<number)
                {
                    lives--;
                    Console.WriteLine("The number is higher than your guess");
                }
                
            } while (true);
            Console.ReadLine();
        }
    }
}

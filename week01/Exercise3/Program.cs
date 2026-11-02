using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("Guess the magic number between 1 and 100:");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You've guessed the magic number!");
            }
        }

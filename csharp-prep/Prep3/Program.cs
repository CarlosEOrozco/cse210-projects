using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string gameStart = "yes"; 
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int counter = 0;

        while (gameStart == "yes")
        {

            Console.WriteLine("What is the magic number? ");
            //Console.WriteLine($"{number} ");

            Console.Write("What is your guess?: ");
            string input = Console.ReadLine();
            int guess = int.Parse(input);

            if (guess < number)
            {
                Console.WriteLine("Higher");
                counter++;
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
                counter++;
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"Total tries: {counter}");
                Console.Write("Continue?(yes/no): ");
                gameStart = Console.ReadLine();
            }



        }










    }
}
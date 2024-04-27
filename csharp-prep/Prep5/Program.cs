using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program! ");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string input = Console.ReadLine();

            return input;
        }

        static int PromptUserNumber()
        {
            int number;

            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            return number;
        }

        static int SquareNumber(int number)
        {
            int sqNumber;

            sqNumber = number*number;

            return sqNumber;
        }        

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {number}");
        }


        //program start
        DisplayWelcome();
        string user = PromptUserName();
        int number = PromptUserNumber();
        int sqNumber = SquareNumber(number);
        DisplayResult(user,sqNumber);

    }
}
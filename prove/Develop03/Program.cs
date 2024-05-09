// Exceeding requirements: Guessing feature. This feature would allow the user to guess the hidden words in the scripture. 
// If the user guesses correctly, the word is revealed.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        var scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to hide words, type 'quit' to exit, or guess a word.");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (input == "")
            {
                scripture.HideRandomWords(2);
            }
            else
            {
                scripture.GuessWord(input);
            }
        }

    }
}
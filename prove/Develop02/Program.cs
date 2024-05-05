using System;
using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();
        var promptGenerator = new Prompter();

        while (true)
        {
            Console.WriteLine("1. Write a new entry\n2. Display the journal\n3. Save the journal to a file\n4. Load the journal from a file\n5. Exit");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine(promptGenerator.GetRandomPrompt());
                    string response = Console.ReadLine();
                    journal.AddEntry(new Entry { _date = DateTime.Now, _promptText = promptGenerator.GetRandomPrompt(), _entryText = response });
                    break;
                case "2":
                    journal.Display();
                    break;
                case "3":
                    Console.WriteLine("Enter filename:");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    break;
                case "4":
                    Console.WriteLine("Enter filename:");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
        
        
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Hello please type your grade porcentage: ");
        string input = Console.ReadLine();
        int porcentage = int.Parse(input);
        int lastDigit = porcentage % 10;
        string letter;
        string sign = ""; 

        if (porcentage < 93 && porcentage >= 60)  
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }

        if (porcentage >= 90)
        {
            Console.WriteLine("Congratulations! You passed the class!");
            letter = "A";
        }
        else if (porcentage < 90 && porcentage >= 80)
        {
            Console.WriteLine("Congratulations! You passed the class!");
            
            letter = "B";
        
        }
        else if (porcentage < 80 && porcentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
    
            letter = "C";
            
        }
        else if (porcentage < 70 && porcentage >= 60)
        {
            
            letter = "D";
            
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your final Grade is: {letter}{sign}");

    }

}
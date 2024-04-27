using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int number = -1;
        int totalsum = 0, numMax = 0;
        float average = 0;




        while (number != 0){

            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }

        }

        int numMin = numbers[0];


        foreach (int pnumber in numbers)
        {
            totalsum += pnumber;

            if (pnumber > numMax)
            {
                numMax = pnumber;
            }

            if (pnumber < numMin  && pnumber > 0)
            {
                numMin = pnumber;
            }
        }

        average = (float)totalsum/ numbers.Count;

        Console.WriteLine($"The sum is: {totalsum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is:  {numMax}");
        Console.WriteLine($"The smallest positive number is: {numMin}");
             
        Console.WriteLine("The sorted list is: ");

        foreach (int pnumber in numbers.OrderBy(n => n))
        {
            Console.WriteLine(pnumber);
        }




    }
}
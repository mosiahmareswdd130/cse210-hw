using System;

class Program
{
    static void Main(string[] args)
    {List<int> numbers = new List<int>();
        
        
        int Number = -1;
        while (Number != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string answer = Console.ReadLine();
            Number = int.Parse(answer);
            
            
            if (Number != 0)
            {
                numbers.Add(Number);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
        
    }
}
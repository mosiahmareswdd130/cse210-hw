using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = UserName();
        int userNumber = UserNumber();

        int squaredNumber = SqNumber(userNumber);

        Result(userName, squaredNumber);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int UserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SqNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void Result(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
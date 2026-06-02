using System;
using Homework;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Jonathan Rodriguez", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Maria Valverde", "Fractions", "17.04", "161-163");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Gilberto Jimenez", "Archeology", "The importance of discoveries throughout history");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}
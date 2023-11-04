using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mtc = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mtc.GetSummary());
        Console.WriteLine(mtc.GetHomeworkList());

        WritingAssignment eng = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(eng.GetSummary());
        Console.WriteLine(eng.GetWritingInformation());
    }
}
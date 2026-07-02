using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment= new Assignment("Gilmar", "Math");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment= new MathAssignment("Gilmar Salgado", "Capacitors", "10.5","50-100");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment= new WritingAssignment("Gilmar Salgado", "ECEN240", "Lab9 - ALU");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}
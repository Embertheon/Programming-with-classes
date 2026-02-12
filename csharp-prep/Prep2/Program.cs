using System;

class Program
{
    static int PlusOrMinus(int grade)
    {
        if 
    }
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Class score as a percentage? %");
        string Grade = Console.ReadLine();
        int GradeValue = int.Parse(Grade);
        if (GradeValue >= 90)
        {
            Console.Write("You have an A");
        }
        else if (GradeValue >= 80)
        {
            Console.WriteLine("You have a B");
        }
        else if (GradeValue >= 70)
        {
            Console.WriteLine("You have a C");
        }
        else if (GradeValue >= 60)
        {
            Console.WriteLine("You have a D");
        }
        else
        {
            Console.WriteLine("You have a F");
        }
        if (GradeValue >= 70)
        {
            Console.WriteLine("You passed the class congagulations!");
        }

    }
}
using System;
class Program
{
    static string PlusOrMinus(int grade)
    {
        if (grade < 93 || grade < 60)
        {
            if(grade % 10 >= 7){
                return "+";
            }
            else if(grade %10 < 3){
                return "-";
            }
        }
        return "";
    }
    static void Main(string[] args)
    {
        string GradeLetter = "";
        Console.WriteLine("What is your Class score as a percentage? %");
        string Grade = Console.ReadLine();
        int GradeValue = int.Parse(Grade);
        if (GradeValue >= 90)
        {
            GradeLetter = "A";
        }
        else if (GradeValue >= 80)
        {
            GradeLetter = "B";
        }
        else if (GradeValue >= 70)
        {
            GradeLetter = "C";
        }
        else if (GradeValue >= 60)
        {
           GradeLetter = "D";
        }
        else
        {
            GradeLetter = "F";
        }
        Console.WriteLine($"Your grade is {GradeLetter}{PlusOrMinus(GradeValue)}");

        if (GradeValue >= 70)
        {
            Console.WriteLine("You passed the class congagulations!");
        }

    }
    
}
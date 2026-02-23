using System;


class Program
{
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptUserName(){
        Console.WriteLine("Please enter your name:");
        return Console.ReadLine();
    }
    static int PromptUserNumber(){
        Console.WriteLine("Please enter your favorite number:");
        return int.Parse(Console.ReadLine());
    }
    static void PromtUserBirthYear(out int BirthYear){
        Console.WriteLine("Please enter the year you were born:");
        BirthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number){
        return number*number;
    }
    static void DisplayResult(string name, int square, int age){
        Console.WriteLine($"{name}, the square of your number is {square}\n{name} you will turn {2026-age} this year.");
    }
    static void Main(string[] args)
    {
        string name =  "";
        int square = 0;
        int age = 0;
        DisplayWelcome();
        name = PromptUserName();
        square = PromptUserNumber();
        PromtUserBirthYear(out age);
        square = SquareNumber(square);
        DisplayResult(name, square, age); 
    }

}
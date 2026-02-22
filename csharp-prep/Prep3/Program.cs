using System;

class Program
{
    static string yesNo;
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        yesNo = "";

        do{
            
            int attempts =+ 0;
            Console.WriteLine("What is the magic number");
            string guess = Console.ReadLine();
            int guessValue = int.Parse(guess);
            if(guessValue < number)
            {
                Console.WriteLine("guess higher");
            }
            else if(guessValue < number)
            {
                Console.WriteLine("guess lower");
            }
            else
            {
                Console.WriteLine($"That's right it took you {attempts}attempts would you like to play again");
                attempts = 0;
                string yesNo = Console.ReadLine();
            }

        } while(yesNo != "yes");
    }

}
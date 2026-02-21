using System;

class Program
{
    private string _userinput;
    private int _Loop;

    Program(){
        _Loop = 0;
        _userinput = "";
    }
    static void Main()//loop until user types end
    {
        Program._Loop = false;
        while(Program._Loop =false)
        Console.Write(Scripture._GetScripture );
        string _userinput = Console.ReadLine();
        if _userinput == ("end")
        {
            _Loop = 1;
        }
        else
        {
            Word.selectRandomWords();
            Console.Clear();
        }
    }
}

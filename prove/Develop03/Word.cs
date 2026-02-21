using System

class Word
{
    private string _verse;
    private string _words;

    public string setScripure(){
    //gets the scripures from the program class and stores it in this class
    return _verse;
    }
    private void splitSriptureintoWords(){
    //splits the verse into words based on spaces
        _words = setScripure().parse[" "];
    }
    private void selectRandomWords(){
        //when called chooses random words to omit
    }
    private void hideWords(){
        //clears the console and prints scrpture where chosen words are hidden
    }
}
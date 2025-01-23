public class Reference { // Keeps track of the book, chapter, and verse information.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference (string book, int chapter, int verse) //single verse
    {  //Decide what to set _endVerse equal to
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }
    public Reference (string book, int chapter, int startVerse, int endVerse)  //more than one verse
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;

    }

    public string GetDisplayText()
    { //two ways to return the string;
    // 1 Nephi 3:7
    // 1 Nephi 3:7-9
        return  "";
    }



}   
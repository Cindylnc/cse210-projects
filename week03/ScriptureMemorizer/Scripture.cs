public class Scripture{  // Keeps track of both the reference and the text of the scripture. 
    private Reference _reference;
    private List<Word> _words;

    public Scripture (Reference reference, string text)
    {   
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add (new Word(word));
        }
    }
    public void HideRandomWords (int numberToHide)
    { 
        Random random = new Random();
        //Create list of
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        //Limit number of words to hide to number of visible words
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i=0; i <wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); //Removed from list so it's not picked twice*/
        }
    }
    public string GetDisplayText ()
    { //Display reference, all words
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText +=  word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }





}
public class Scripture{  // Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
    private Reference _reference;
    private List<Word> _words;

    public Scripture (Reference reference, string text)
    {   //split up the words in text and store each as a word object in the list _words
    //Split and loop through each word. And create word objext and put it into _words
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
        //List<Word> visibleWords = new List<Word>();
        for (int i=0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            while (_words[index].IsHidden())
            {
                index = random.Next(_words.Count);
            }
            _words[index].Hide();
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
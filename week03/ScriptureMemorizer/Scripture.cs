public class Scripture{  // Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
    private Reference _reference;
    private List<Word> _words;

    public Scripture (Reference reference, string text)
    {   //split up the words in text and store each as a word object in the list _words
    //Split and loop through each word. And create word objext and put it into _words

    }
    public void HideRandomWords (int numberToHide)
    { // Set the state of a randomly selected group of words to be hidden
    // Need to find a set of visible words
    //Randomly select "numberToHide" of those words (if visible function/ loops or if statements) 
    // Use the Hide function

    }
    public string GetDisplayText ()
    { //Display reference, all words
        return "";
    }
    public bool IsCompletelyHidden()
    {
        return false;
    }


    



}
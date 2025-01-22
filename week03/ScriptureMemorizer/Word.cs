public class Word // Keeps track of a single word and whether it is shown or hidden.
{
    private string _text;
    private bool _isHidden;

    public Word (string text)
    {
        _text = text;
        _isHidden = false;
    }
      
    public void Hide()
    {

    }
    public void Show()
    {

    }
    public bool IsHidden()
    {
        return false;
    }
    public string GetDisplayText()
    {  //Should return the word if visible or return underscores ____ if hidden
        return _text;
    }

}
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
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {  //Should return the word if visible or return underscores ____ if hidden
        return _text;
    }

}
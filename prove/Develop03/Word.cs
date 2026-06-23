using System;

public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string text){
        _text = text;
        _isHidden = false;
    }
    public void Hide(){
        char [] letters = _text.ToCharArray();
        for(int i = 0; i <_text.Length; i++)
        {
            letters[i] = '_';
        }
        _text = new string (letters);
        _isHidden = true;
    }
    public void Show(){
        _isHidden = false;
    }
    public bool isHidden(){
        if (_isHidden){
            return false;
        } else {
            return true; 
        }
    }
    public string GetDisplayText(){
        return _text;
    }
}
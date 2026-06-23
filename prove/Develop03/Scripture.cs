using System;

public class Scripture{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text){
        _reference = reference;
        string [] textArray = text.Split(" ");

        for (int i = 0; i < textArray.Length; i++){
            Word eachWord = new Word(textArray[i]);
            _words.Add(eachWord);
        } 
    }
    public void HideRandomWords(){
        Random random = new Random();
        int numberToHide = random.Next(2,4);
        int x = 0;
        int positionToHide;
        while (x < numberToHide){
            positionToHide = random.Next(0,_words.Count);
            if(_words[positionToHide].isHidden() == true){
                _words[positionToHide].Hide();
                x++;
            } 
        }
    }

    public string GetDisplayText(){
        string fullScripture = "";
        for (int i = 0; i < _words.Count;i++){
            fullScripture = fullScripture + " " + _words[i].GetDisplayText();
        }
        return _reference.GetDisplayText() + fullScripture;
        
    }
    public bool IsCompletelyHidden(){
        foreach (Word word in _words){
            if (word.isHidden() == true){
                return true;
            } 
            
        } return false;
    }




}
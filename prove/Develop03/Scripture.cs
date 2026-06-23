using System;
using System.Collections.Generic;

public class Scripture {
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
        if (IsCompletelyHidden()) return; // Stop if already hidden

        Random random = new Random();
        int numberToHide = random.Next(2, 4);
        int x = 0;
        
        // Safety Net: Count how many unhidden words are actually left
        int unhiddenCount = 0;
        foreach (Word w in _words) {
            if (!w.IsHidden()) unhiddenCount++;
        }
        
        // Don't try to hide 3 words if only 1 or 2 are left!
        if (numberToHide > unhiddenCount) {
            numberToHide = unhiddenCount;
        }

        while (x < numberToHide){
            int positionToHide = random.Next(0, _words.Count);
            if(_words[positionToHide].IsHidden() == false){
                _words[positionToHide].Hide();
                x++;
            } 
        }
    }

    public string GetDisplayText(){
        string fullScripture = "";
        for (int i = 0; i < _words.Count; i++){
            fullScripture += " " + _words[i].GetDisplayText();
        }
        return _reference.GetDisplayText() + fullScripture;
    }

    public bool IsCompletelyHidden(){
        foreach (Word word in _words){
            if (word.IsHidden() == false) return false; 
        } 
        return true; 
    }
}
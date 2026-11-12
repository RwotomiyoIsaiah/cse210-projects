using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] wordList = text.Split(' ');

        foreach (string word in wordList)
        {
            _words.Add(new Word(word));
        }
    }
    public bool IsCompletelyHidden()//determines if all the words of the scripture are hidden, then it returns true , otherwise false
    {
        foreach (Word word in _words)
        {
            if (!word._IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;
        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int index = _random.Next(_words.Count);
//prevents the same word from being hidden multiple times by checking if the word is already hidden before hiding it
            if (!_words[index]._IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }
}
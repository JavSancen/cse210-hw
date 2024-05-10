using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private int _hiddenWordsCount;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _hiddenWordsCount = 0;

        string[] words = text.Split(' ');
        foreach (var word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsToHide = Math.Min(numberToHide, _words.Count - _hiddenWordsCount);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                _hiddenWordsCount++;
            }
            else
            {
                i--; // Decrement i to try hiding another word
            }
        }

        if (wordsToHide != numberToHide)
        {
            Console.WriteLine("Enter a valid number of words to hide.");
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _hiddenWordsCount == _words.Count;
    }

    public int GetTotalWordsCount()
    {
        return _words.Count;
    }
}
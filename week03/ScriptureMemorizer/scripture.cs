using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public string ReferenceText
    {
        get { return _reference.GetDisplayText(); }
    }


    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split(' ');
        _words = new List<Word>();
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    // SMART HIDING: only hide words that are NOT hidden yet
    public void HideRandomWords(int count)
    {
        // Create a list of all words that are still visible
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        // If there's nothing left to hide, exit early
        if (visibleWords.Count == 0)
            return;

        // Hide up to "count" words, but not more than what's available
        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            // Pick a random visible word
            int index = _random.Next(visibleWords.Count);

            // Hide the selected word
            visibleWords[index].Hide();

            // Remove it from the visible list (to avoid hiding twice in same round)
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));

        return referenceText + " — " + text;
    }

    internal object GetReferenceOnly()
    {
        throw new NotImplementedException();
    }
}

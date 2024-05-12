using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _words = text.Split(" ").Select(wordText => new Word(wordText)).ToList();
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.ToString());
        foreach (Word word in _words)
        {
            if (word.GetIsHidden())
            {
                Console.Write("___ ");
            }
            else
            {
                Console.Write(word.GetText() + " ");
            }
        }
        Console.WriteLine();
        
    }

    public void HideWord()
    {
        List<Word> visibleWords = _words.Where(word => !word.GetIsHidden()).ToList();
        if (visibleWords.Count > 0)
        {
            Random rand = new Random();
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].SetIsHidden(true);
        }
    }        
    
    public bool AllWordsHidden()
    {
        return _words.All(word => word.GetIsHidden());
    }
}
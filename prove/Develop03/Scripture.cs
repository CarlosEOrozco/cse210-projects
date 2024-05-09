public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            var wordToHide = _words[random.Next(_words.Count)];
            wordToHide.Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
    
    public void GuessWord(string guess)
    {
        foreach (var word in _words)
        {
            if (word.GetText() == guess && word.IsHidden())
            {
                word.Show();
                Console.WriteLine($"Correct guess! '{guess}' was revealed.");
                return;
            }
        }
        Console.WriteLine($"Sorry, '{guess}' is not a hidden word.");
    }
}
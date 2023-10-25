
    public class Scripture
    {
        public string Reference { get; }
        private string _Text;
        private List<Word> _words;

        public Scripture(string reference, string text)
        {
            Reference = reference;
            _Text = text;
            _words = _Text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public int HideRandomWord(Random random)
        {
            List<Word> visibleWords = _words.Where(word => !word.GetIsHidden()).ToList();
            if (visibleWords.Count == 0)
                return -1;

            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            return randomIndex;
        }

        public string GetVisibleText()
        {
            return string.Join(" ", _words.Select(word => word.GetIsHidden() ? "_".PadRight(word.GetText().Length) : word.GetText()));
        }

        public bool HasVisibleWords()
        {
            return _words.Any(word => !word.GetIsHidden());
        }
    }

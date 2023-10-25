    public class Word
    {
        private string _Text;
        private bool _IsHidden;

        public Word(string text)
        {
            _Text = text;
            _IsHidden = false;
        }

        public void Hide()
        {
            _IsHidden = true;
        }

        public string GetText()
        {
            return _Text;
        }

        public bool GetIsHidden()
        {
            return _IsHidden;
        }
    }


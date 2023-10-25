    public class Reference
    {
        private string _Text;

        public Reference(string text)
        {
            _Text = text;
        }

        public void SetText(string text)
        {
            _Text = text;
        }

        public string GetText()
        {
            return _Text;
        }
    }
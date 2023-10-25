    public class ScriptureLibrary
    {
        private List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture("Philippians 4:13", "I can do all things through Christ which strengtheneth me."),
            new Scripture("Psalm 23:1", "The Lord is my shepherd; I shall not want."),
            new Scripture("Isaiah 40:31", "But they that wait upon the Lord shall renew their strength; they shall mount up with wings as eagles; they shall run, and not be weary; and they shall walk, and not faint."),
            new Scripture("Romans 8:28", "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."),
            new Scripture("Matthew 28:19-20", "Go ye therefore, and teach all nations, baptizing them in the name of the Father, and of the Son, and of the Holy Ghost: Teaching them to observe all things whatsoever I have commanded you: and, lo, I am with you always, even unto the end of the world. Amen."),
            new Scripture("1 Corinthians 16:14", "Let all your things be done with charity."),
            new Scripture("Psalm 46:10", "Be still, and know that I am God: I will be exalted among the heathen, I will be exalted in the earth.")

        };

        public Scripture GetRandomScripture(Random random)
        {
            int index = random.Next(scriptures.Count);
            return scriptures[index];
        }
    }
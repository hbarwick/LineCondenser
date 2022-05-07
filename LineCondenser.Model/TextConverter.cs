namespace LineCondenser.Model
{
    public class TextConverter
    {
        public string LeftDelimiter { get; set; }
        public string RightDelimiter { get; set; }
        public string Separator { get; set; }
        public string LineStart { get; set; }
        public string LineEnd { get; set; }
        public string TextEntry { get; set; }
        public string OutputText { get; set; }

        public TextConverter()
        {
            LeftDelimiter = "'";
            RightDelimiter = "'";
            Separator = ",";
            LineStart = "(";
            LineEnd = ")";
            TextEntry = "Paste\nInput\nText\nHere!";
            OutputText = "";
        }


    }
}
using System.ComponentModel;

namespace LineCondenser.ViewModel
{
    public class TextConvertViewModel : INotifyPropertyChanged
    {
        private string? leftDelimiter;
        private string? RightDelimiter { get; set; }
        private string? Separator { get; set; }
        private string? LineStart { get; set; }
        private string? LineEnd { get; set; }
        private string? TextEntry { get; set; }

        public string LeftDelimiter
        {
            get { return leftDelimiter; }
            set { leftDelimiter = value ?? ""; }
        }
        

        public TextConvertViewModel(string left, string right, string sep, string start, string end, string text)
        {
            LeftDelimiter = left;
            RightDelimiter = right; 
            Separator = sep;
            LineStart = start;
            LineEnd = end;
            TextEntry = text;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public string ProcessText()
        {
            string[] lines = TextEntry.Split(new string[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None);
            var result = "";
            result += LineStart;
            foreach (string line in lines)
            {
                result += LeftDelimiter;
                result += line;
                result += RightDelimiter;
                result += Separator;
            }
            result = result.Remove(result.Length - 1, Separator.Length);
            result += LineEnd;
            return result;
        }
    }
}
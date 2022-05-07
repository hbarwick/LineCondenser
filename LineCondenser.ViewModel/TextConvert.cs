using System.ComponentModel;

namespace LineCondenser.ViewModel
{
    public class TextConvertViewModel : INotifyPropertyChanged
    {
        private string? LeftDelimiter { get; set; }
        private string? RightDelimiter { get; set; }
        private string? Separator { get; set; }
        private string? LineStart { get; set; }
        private string? LineEnd { get; set; }
        private string? TextEntry { get; set; }

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
            throw new NotImplementedException();
            //string[] lines = TextEntry.Split

            //string result;


            //return result;
        }
    }
}
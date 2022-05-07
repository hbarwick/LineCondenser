using System.ComponentModel;

namespace TextConverter.ViewModel
{
    public class TextConvertViewModel : INotifyPropertyChanged
    {
        private string? LeftDelimiter { get; set; }
        private string? RightDelimiter { get; set; }
        private string? Separator { get; set; }
        private string? LineStart { get; set; }
        private string? LineEnd { get; set; }
        private string? TextEntry { get; set; }



        public event PropertyChangedEventHandler? PropertyChanged;

        public string ProcessText()
        {
            string[] lines = TextEntry.Split

            string result;


            return result;
        }
    }
}
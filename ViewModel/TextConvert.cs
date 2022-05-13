using System;
using System.ComponentModel;
using LineCondenser.Model;

namespace LineCondenser.ViewModel
{
    public class TextConvertViewModel : INotifyPropertyChanged
    {
        private TextConverter converter = new TextConverter();

        public string LeftDelimiter
        {
            get { return converter.LeftDelimiter; }
            set
            {
                if (converter.LeftDelimiter != value)
                {
                    converter.LeftDelimiter = value;
                    OnPropertyChange(nameof(LeftDelimiter));
                }
            }
        }

        public string RightDelimiter
        {
            get { return converter.RightDelimiter; }
            set
            {
                if (converter.RightDelimiter != value)
                {
                    converter.RightDelimiter = value;
                    OnPropertyChange(nameof(RightDelimiter));
                }
            }
        }

        public string Separator
        {
            get { return converter.Separator; }
            set
            {
                if (converter.Separator != value)
                {
                    converter.Separator = value;
                    OnPropertyChange(nameof(Separator));
                }
            }
        }

        public string LineStart
        {
            get { return converter.LineStart; }
            set
            {
                if (converter.LineStart != value)
                {
                    converter.LineStart = value;
                    OnPropertyChange(nameof(LineStart));
                }
            }
        }

        public string LineEnd
        {
            get { return converter.LineEnd; }
            set
            {
                if (converter.LineEnd != value)
                {
                    converter.LineEnd = value;
                    OnPropertyChange(nameof(LineEnd));
                }
            }
        }

        public string TextEntry
        {
            get { return converter.TextEntry; }
            set
            {
                if (converter.TextEntry != value)
                {
                    converter.TextEntry = value;
                    OnPropertyChange(nameof(TextEntry));
                }
            }
        }

        public string OutputText
        {
            get { return ProcessText(); }
            set
            {
                if (converter.OutputText != value)
                {
                    converter.OutputText = value;
                    OnPropertyChange(nameof(OutputText));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                OutputText = ProcessText();
            }
        }

        public string ProcessText()
        {
            string[] lines = TextEntry.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            var result = "";
            result += LineStart;
            foreach (string line in lines)
            {
                result += LeftDelimiter;
                result += line;
                result += RightDelimiter;
                result += Separator;
            }
            result = result.Remove(result.Length - Separator.Length, Separator.Length);
            result += LineEnd;
            return result;
        }
    }
}
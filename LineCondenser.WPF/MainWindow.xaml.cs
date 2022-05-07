using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LineCondenser.ViewModel;

namespace LineCondenser.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextConvertViewModel Converter = new TextConvertViewModel(leftDelimiter.Text, rightDelimiter.Text, separator.Text, lineStart.Text, lineEnd.Text, textEntry.Text);
        }



        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            //Converter.ProcessText();
        }
    }
}

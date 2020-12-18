using MorseCodeLibrary;
using System.Linq;
using System.Windows;

namespace MorseCode
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var inputText = TextBox1.Text;

            if (inputText != default)
            {
                if (inputText.Any(t => t == '.' || t == '-'))
                {
                    TextBlock1.Text = MC.ConvertFromCM(true, inputText);
                }

                else
                {
                    TextBlock1.Text = MC.ConvertToCM(true, inputText);
                }
            }
        }
    }
}
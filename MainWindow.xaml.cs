using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace DonbassCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double a;
        double b;
        double c;
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(First.Text, out a) && double.TryParse(Second.Text, out b))
            {
                c = a + b;
                GiveText(c);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(First.Text, out a) && double.TryParse(Second.Text, out b))
            {
                if (b != 0)
                {
                    c = a / b;
                    GiveText(c);

                } GiveText("KYS");


            }

        }

        private void TextBlock_TextInput(object sender, TextCompositionEventArgs e)
        {
            number.Text = c.ToString();
        }


        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !double.TryParse(e.Text, out double result);

        }

        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !double.TryParse(e.Text, out double result);
            result = b;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(First.Text, out a) && double.TryParse(Second.Text, out b))
            {
                c = a - b;
                GiveText(c);
            }
        }
        private void GiveText(string a) 
        { 
            number.Text = a; 
        }
        private  void GiveText(double c) 
        {
            number.Text = c.ToString();
        }

        private void MultiPly_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(First.Text, out a) && double.TryParse(Second.Text, out b))
            {
                    c = a * b;
                    GiveText(c);
            }
        }

        
    }
}

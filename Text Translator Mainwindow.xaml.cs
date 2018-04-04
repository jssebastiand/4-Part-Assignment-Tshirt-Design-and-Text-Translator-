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

namespace u2TxtToEngApr4Fix
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {

            string input = txtInput.Text;// txtInput.Text;
            input = input.Replace("CU", "See You"); Console.WriteLine(input);
            input = input.Replace(":-)", "Happy♥"); Console.WriteLine(input);
            input = input.Replace(":-(", "I’m Unhappy"); Console.WriteLine(input);
            input = input.Replace(";-)", "Wink"); Console.WriteLine(input);
            input = input.Replace(":-P", "Stick Out My Tongue"); Console.WriteLine(input);
            input = input.Replace("(˜.˜)", "Sleepy"); Console.WriteLine(input);
            input = input.Replace("TA", "Totally Awesome"); Console.WriteLine(input);
            input = input.Replace("CCC", "Canadian Computing Competition"); Console.WriteLine(input);
            input = input.Replace("CUZ", "Because"); Console.WriteLine(input);
            input = input.Replace("YW", "You’re Welcome"); Console.WriteLine(input);
            input = input.Replace("TTYL", "Talk To You Later"); Console.WriteLine(input);
            input = input.Replace("TY", "Thank You☺"); Console.WriteLine(input);


            //Output full end string.
            string output = input;
            lblOutput.Content = output;
            ;
        }
    }
}

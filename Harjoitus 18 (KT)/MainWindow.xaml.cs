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

namespace Harjoitus_18__KT_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first;
        int second;

        char op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            output.Text += btn.Content.ToString();
            second = Int32.Parse(output.Text);
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(output.Text);
            op = '/';
            output.Clear();
        }

        private void Times_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(output.Text);
            op = '*';
            output.Clear();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(output.Text);
            op = '-';
            output.Clear();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(output.Text);
            op = '+';
            output.Clear();
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            second = Int32.Parse(output.Text);
            int result = 0;

            if (op == '+')
            {
                result = first + second;
            }
            else if (op ==  '-')
            {
               result = first - second;
            }
            else if (op == '*')
            {
                result = first * second;
            }
            else if (op == '/')
            {
                result = first / second;
            }
            if (output.Text == "0")
            {
                output.Clear();
            }
            output.Text = result.ToString();
        }
    }
}

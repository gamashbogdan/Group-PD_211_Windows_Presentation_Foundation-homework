using System;
using System.Collections.Generic;
using System.Data;
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

namespace _01_Intro_to_WPF_Сalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement elem in GroupButton.Children)
            {
                if (elem is Button)
                {
                    ((Button)elem).Click += ButtonClick;
                }
            }
        }
        private void ButtonClick(Object sender, RoutedEventArgs e)
        {
            try
            {
               string textButton = ((Button)e.OriginalSource).Content.ToString()!;
                if (textButton == "C")
                {
                    TextBox.Clear();
                }
                else if (textButton == "X")
                {
                    TextBox.Text = TextBox.Text.Substring(TextBox.Text.Length - 1);
                }
                else if (textButton == "=")
                {
                    TextBox.Text = new DataTable().Compute(TextBox.Text, null).ToString();
                }
                else
                {
                    TextBox.Text += textButton;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

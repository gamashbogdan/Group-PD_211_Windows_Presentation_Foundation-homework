using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _03_Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        private int pressedButtons = 1;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            timer.Tick += Timer_Tick;
            sliterСomplexity.ValueChanged += SliterСomplexity_ValueChanged;
            lamelTime.Content = $"Time for the game is";
            foreach (UIElement elem in gridButton.Children)
            {
                if (elem is Button)
                {
                    ((Button)elem).Click += button_Click;
                }
            }
        }

        private void SliterСomplexity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliterСomplexity.Value == 1)
            {
                progresBarTime.Maximum = 120;
                progresBarTime.Value = 120;
                lamelTime.Content = "Time for the game is : 2 min ";
            }
            else if (sliterСomplexity.Value == 2)
            {
                progresBarTime.Maximum = 90;
                progresBarTime.Value = 90;
                lamelTime.Content = "Time for the game is : 1 min 30 sec";
            }
            else if (sliterСomplexity.Value == 3)
            {
                progresBarTime.Maximum = 60;
                progresBarTime.Value = 60;
                lamelTime.Content = $"Time for the game is : 1 min";
            }
            else if (sliterСomplexity.Value == 4)
            {
                progresBarTime.Maximum = 30;
                progresBarTime.Value = 30;
                lamelTime.Content = $"Time for the game is : 30 sec";
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            lamelTimeNow.Content = $"           {progresBarTime.Value} sec";
            if (progresBarTime.Value != 0)
            {
                progresBarTime.Value--;
            }
            else
            {
                timer.Stop();
                ButtonStop_Click(sender!, null!);
                MessageBox.Show("Dead :)))", "Info");
            }
        }

        static int[] GenerateRandomArray(int count)
        {
            Random random = new Random();
            int[] result = new int[count];
            int i = 0;

            while (i < count)
            {
                int randomNumber = random.Next(1, count+1);
                if (Array.IndexOf(result, randomNumber) == -1)
                {
                    result[i] = randomNumber;
                    i++;
                }
            }
            return result;
        }
        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            pressedButtons = 1;
            timer.Start();
            sliterСomplexity.IsEnabled = false;
            SliterСomplexity_ValueChanged(sender, null!);
            int[] arr = GenerateRandomArray(9);
            int i = 0;
            foreach (Button btn in gridButton.Children.OfType<Button>())
            {
                btn.Content = arr[i];
                i++;
            }
        }
        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            foreach (UIElement elem in gridButton.Children)
            {
                if (elem is Button)
                {
                    ((Button)elem).IsEnabled = true;
                }
            }
            sliterСomplexity.IsEnabled = true;
            timer.Stop();
            foreach (Button btn in gridButton.Children.OfType<Button>())
            {
                btn.Content = "";
            }
            lamelTime.Content = $"Time for the game is";
            lamelTimeNow.Content = "";
            progresBarTime.Value = 0;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string textButton = ((Button)e.OriginalSource).Content.ToString()!;
            if (pressedButtons != 10 && int.Parse(textButton) == pressedButtons)
            {
                ((Button)e.OriginalSource).IsEnabled = false;
                if (pressedButtons == 9)
                {
                    double a = progresBarTime.Maximum - progresBarTime.Value;
                    ButtonStop_Click(sender, null!);
                    MessageBox.Show($"your winnnnnnnnnnnnn :D za :{a} sec", "Into");
                }
                pressedButtons++;
            }
        }

    }
}

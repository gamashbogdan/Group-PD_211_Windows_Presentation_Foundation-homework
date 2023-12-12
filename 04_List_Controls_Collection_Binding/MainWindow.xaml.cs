using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace _04_List_Controls_Collection_Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<PhoneBook>phoneBooks = null;
        private ObservableCollection<string> listCountry = null;
        public MainWindow()
        {
            InitializeComponent();
            phoneBooks = new ObservableCollection<PhoneBook>();
            listCountry = new ObservableCollection<string>()
            {
                "China",
                "India",
                "United States",
                "Indonesia",
                "Pakistan",
                "Brazil",
                "Nigeria",
                "Bangladesh",
                "Russia",
                "Mexico",
                "Japan",
                "Ethiopia",
                "Philippines",
                "Egypt",
                "Vietnam",
                "DR Congo",
                "Turkey",
                "Iran",
                "Germany",
                "Thailand",
                "United Kingdom",
                "France",
                "Italy",
                "South Africa",
                "Tanzania",
                "Argentina",
                "Myanmar",
                "South Korea",
                "Colombia",
                "Kenya",
                "Spain",
                "Algeria",
                "Sudan",
                "Ukraine",
                "Uganda",
                "Iraq",
                "Poland",
                "Canada",
                "Morocco",
                "Afghanistan",
                "Saudi Arabia",
                "Peru",
                "Malaysia",
                "Venezuela",
                "Netherlands",
                "Australia",
                "Chile"
            };
            listBox.ItemsSource = phoneBooks;
            listBox.DisplayMemberPath = nameof(PhoneBook.FullInfo);
            comboBoxCountry.ItemsSource = listCountry;
        }
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = "", surname = "", phone = "", country = "";
            int correctAnswerCounter = 0;
            if (textBoxName.Text.Length == 0){
                MessageBox.Show("Enter a name", "Eror 2", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else{
                correctAnswerCounter += 1;
                name = textBoxName.Text;
            }
            if (textBoxSurname.Text.Length == 0){
                MessageBox.Show("Enter a surna","Eror 3",MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else{
                correctAnswerCounter += 1;
                surname = textBoxSurname.Text;
            }
            if (textBoxPhone.Text.Length == 0){ 
                MessageBox.Show("Enter a phone","Eror 4",MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else{
                correctAnswerCounter += 1;
                phone = textBoxPhone.Text;
            }
            if (comboBoxCountry.SelectedItem == null){
                MessageBox.Show("Choose a country", "Eror 5", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else{
                correctAnswerCounter += 1;
                country = comboBoxCountry.SelectedItem.ToString()!;
            }    
            if(correctAnswerCounter == 4){
                phoneBooks.Add(new PhoneBook() { Name = name, Surname = surname, Phone = phone, Country = country});
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPhone.Text = "";
                comboBoxCountry.Text = "";
            }
        }
        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
                phoneBooks.RemoveAt(listBox.SelectedIndex);
            else
                MessageBox.Show("Selected item", "EROR 6", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

    }
}

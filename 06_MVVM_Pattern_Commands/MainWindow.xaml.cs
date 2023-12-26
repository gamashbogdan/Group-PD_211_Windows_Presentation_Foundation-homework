using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
using ValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace _06_MVVM_Pattern_Commands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            listBox.DisplayMemberPath = nameof(PhoneBook.FullInfo);
            this.DataContext = viewModel;
            foreach (UIElement elem in menuStyles.Items)
            {
                if (elem is Button)
                {
                    ((Button)elem).Click += MainWindow_Click;
                }
            }
        }
        private void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string textButton = ((Button)e.OriginalSource).Name.ToString();
                if (textButton == "Button1")
                {
                    #region Button 1
                    menuStyles.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));

                    gridMain.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#607D8B"));

                    listBox.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E0E0E0"));
                    listBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));

                    gridNested.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));

                    labelName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0277BD"));

                    textBoxName.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC107"));
                    textBoxName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));

                    labelSurname.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0277BD"));

                    textBoxSurname.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC107"));
                    textBoxSurname.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));

                    labelPhone.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0277BD"));

                    textBoxPhone.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC107"));
                    textBoxPhone.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));

                    labelCountry.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0277BD"));

                    comboBoxCountry.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    comboBoxCountry.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC107"));

                    buttonAdd.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFAEF0CD"));
                    buttonAdd.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonAdd.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF25C408"));

                    buttonCopyPhoneBook.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFAEF0CD"));
                    buttonCopyPhoneBook.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonCopyPhoneBook.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF25C408"));

                    buttonRemove.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF89797"));
                    buttonRemove.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonRemove.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC82F0D"));

                    buttonClear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF89797"));
                    buttonClear.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonClear.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC82F0D"));
                    #endregion
                }
                if (textButton == "Button2")
                {
                    #region Button 2
                    menuStyles.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#37474F"));
                    gridMain.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#394240"));
                    listBox.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#546E7A"));
                    listBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                    gridNested.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#37474F"));
                    labelName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#90A4AE"));
                    textBoxName.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B0BEC5"));
                    textBoxName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    labelSurname.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#90A4AE"));
                    textBoxSurname.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B0BEC5"));
                    textBoxSurname.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    labelPhone.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#90A4AE"));
                    textBoxPhone.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B0BEC5"));
                    textBoxPhone.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    labelCountry.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#90A4AE"));
                    comboBoxCountry.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B0BEC5"));
                    comboBoxCountry.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonAdd.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#90CAF9"));
                    buttonAdd.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonAdd.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1565C0"));
                    buttonCopyPhoneBook.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#90CAF9"));
                    buttonCopyPhoneBook.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonCopyPhoneBook.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1565C0"));
                    buttonRemove.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EF9A9A"));
                    buttonRemove.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonRemove.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C62828"));
                    buttonClear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EF9A9A"));
                    buttonClear.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonClear.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C62828"));
                    #endregion

                }
                if (textButton == "Button3")
                {
                    #region Button 3
                    menuStyles.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CFD8DC"));
                    gridMain.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ECEFF1"));
                    listBox.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CFD8DC"));
                    listBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#37474F"));
                    gridNested.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E0E0E0"));
                    labelName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#546E7A"));
                    textBoxName.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B0BEC5"));
                    textBoxName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    labelSurname.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#546E7A"));
                    textBoxSurname.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B0BEC5"));
                    textBoxSurname.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    labelPhone.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#546E7A"));
                    textBoxPhone.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B0BEC5"));
                    textBoxPhone.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    labelCountry.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#546E7A"));
                    comboBoxCountry.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#B0BEC5"));
                    comboBoxCountry.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonAdd.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#90CAF9"));
                    buttonAdd.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonAdd.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1565C0"));
                    buttonCopyPhoneBook.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#90CAF9"));
                    buttonCopyPhoneBook.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonCopyPhoneBook.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1565C0"));
                    buttonRemove.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EF9A9A"));
                    buttonRemove.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonRemove.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C62828"));
                    buttonClear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EF9A9A"));
                    buttonClear.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonClear.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#C62828"));
                    #endregion
                }
                if (textButton == "Button4")
                {
                    #region Button 4
                    menuStyles.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0288D1"));
                    gridMain.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F5F5F5"));
                    listBox.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9C27B0"));
                    listBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                    gridNested.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0288D1"));
                    labelName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9C27B0"));
                    textBoxName.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E1BEE7"));
                    textBoxName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    labelSurname.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9C27B0"));
                    textBoxSurname.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E1BEE7"));
                    textBoxSurname.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    labelPhone.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9C27B0"));
                    textBoxPhone.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E1BEE7"));
                    textBoxPhone.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    labelCountry.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9C27B0"));
                    comboBoxCountry.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E1BEE7"));
                    comboBoxCountry.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonAdd.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#03A9F4"));
                    buttonAdd.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                    buttonAdd.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0288D1"));
                    buttonCopyPhoneBook.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#03A9F4"));
                    buttonCopyPhoneBook.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                    buttonCopyPhoneBook.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0288D1"));
                    buttonRemove.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9C27B0"));
                    buttonRemove.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                    buttonRemove.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B1FA2"));
                    buttonClear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9C27B0"));
                    buttonClear.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                    buttonClear.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7B1FA2"));
                    #endregion
                }
                if (textButton == "Button5")
                {
                    #region Button 5
                    menuStyles.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFEB3B"));
                    gridMain.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F5F5F5"));
                    listBox.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8BC34A"));
                    listBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                    gridNested.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFEB3B"));
                    labelName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9800"));
                    textBoxName.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF9C4"));
                    textBoxName.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    labelSurname.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9800"));
                    textBoxSurname.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF9C4"));
                    textBoxSurname.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    labelPhone.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9800"));
                    textBoxPhone.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF9C4"));
                    textBoxPhone.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    labelCountry.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9800"));
                    comboBoxCountry.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF9C4"));
                    comboBoxCountry.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                    buttonAdd.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4CAF50"));
                    buttonAdd.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                    buttonAdd.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#388E3C"));
                    buttonCopyPhoneBook.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4CAF50"));
                    buttonCopyPhoneBook.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                    buttonCopyPhoneBook.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#388E3C"));
                    buttonRemove.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5722"));
                    buttonRemove.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                    buttonRemove.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D84315"));
                    buttonClear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5722"));
                    buttonClear.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                    buttonClear.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D84315"));
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void buttonAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    string name = "", surname = "", phone = "", country = "";
        //    int correctAnswerCounter = 0;
        //    if (textBoxName.Text.Length == 0)
        //    {
        //        MessageBox.Show("Enter a name", "Eror 2", MessageBoxButton.OK, MessageBoxImage.Warning);
        //    }
        //    else
        //    {
        //        correctAnswerCounter += 1;
        //        name = textBoxName.Text;
        //    }
        //    if (textBoxSurname.Text.Length == 0)
        //    {
        //        MessageBox.Show("Enter a surna", "Eror 3", MessageBoxButton.OK, MessageBoxImage.Warning);
        //    }
        //    else
        //    {
        //        correctAnswerCounter += 1;
        //        surname = textBoxSurname.Text;
        //    }
        //    if (textBoxPhone.Text.Length == 0)
        //    {
        //        MessageBox.Show("Enter a phone", "Eror 4", MessageBoxButton.OK, MessageBoxImage.Warning);
        //    }
        //    else
        //    {
        //        correctAnswerCounter += 1;
        //        phone = textBoxPhone.Text;
        //    }
        //    if (comboBoxCountry.SelectedItem == null)
        //    {
        //        MessageBox.Show("Choose a country", "Eror 5", MessageBoxButton.OK, MessageBoxImage.Warning);
        //    }
        //    else
        //    {
        //        correctAnswerCounter += 1;
        //        country = comboBoxCountry.SelectedItem.ToString()!;
        //    }
        //    var PhoneBook = new PhoneBook() { Name = name, Surname = surname, Phone = phone, Country = country };
        //    var results = new List<ValidationResult>();
        //    var context = new ValidationContext(PhoneBook);
        //    bool isValid = Validator.TryValidateObject(PhoneBook, context, results, true);
        //    if (correctAnswerCounter == 4)
        //    {
        //        if (!isValid)
        //        {
        //            foreach (ValidationResult error in results)
        //            {
        //                MessageBox.Show(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage, "Eror 1", MessageBoxButton.OK, MessageBoxImage.Warning);
        //            }
        //        }
        //        else
        //        {
        //            PhoneBook newPhoneBook = new PhoneBook() { Name = name, Surname = surname, Phone = phone, Country = country };
        //            viewModel.AddPhoneBook(newPhoneBook);
        //            textBoxName.Text = "";
        //            textBoxSurname.Text = "";
        //            textBoxPhone.Text = "";
        //            comboBoxCountry.Text = "";
        //        }
        //    }
        //}
        


       
    }
}

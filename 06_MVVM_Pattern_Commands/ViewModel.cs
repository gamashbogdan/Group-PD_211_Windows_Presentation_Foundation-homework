using PropertyChanged;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using ValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace _06_MVVM_Pattern_Commands
{
    public partial class MainWindow
    {
        
        [AddINotifyPropertyChangedInterface]
        class ViewModel
        {
            
            private ObservableCollection<PhoneBook> phoneBooks = null;
            private ObservableCollection<string> listCountry = null;
            private RelayCommand copyPhoneBookComand;
            private RelayCommand removePhoneBookComand;
            private RelayCommand clearPhoneBookComand;
            private RelayCommand addPhoneBookComand;
            public ViewModel()
            {
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
                copyPhoneBookComand = new RelayCommand((o) => CopyPhoneBookPhoneBook(),(o)=> DataVerification());
                removePhoneBookComand = new RelayCommand((o) => RemovePhoneBook(), (o) => DataVerification());
                clearPhoneBookComand = new RelayCommand((o) => ClearPhoneBook(), (o) => phoneBooks.Any());
                addPhoneBookComand = new RelayCommand((o) => AddPhoneBook());
                SelectedPhoneBook = new PhoneBook();
            }
            public bool DataVerification()
            {
                if (SelectedPhoneBook.Name == null || SelectedPhoneBook.Surname == null || SelectedPhoneBook.Phone == null || SelectedPhoneBook.Country == null)return false;
                return true;
            }
            public bool VerificationOfEnteredData()
            {
                string name = "", surname = "", phone = "", country = "";
                int correctAnswerCounter = 0;
                if (SelectedPhoneBook.Name == null || SelectedPhoneBook.Name.Length == 0)
                {
                    MessageBox.Show("Enter a name", "Eror 2", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    correctAnswerCounter += 1;
                    name = SelectedPhoneBook.Name;
                }
                if (SelectedPhoneBook.Surname == null || SelectedPhoneBook.Surname.Length == 0)
                {
                    MessageBox.Show("Enter a surna", "Eror 3", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    correctAnswerCounter += 1;
                    surname = SelectedPhoneBook.Surname;
                }
                if (SelectedPhoneBook.Phone == null || SelectedPhoneBook.Phone.Length == 0)
                {
                    MessageBox.Show("Enter a phone", "Eror 4", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    correctAnswerCounter += 1;
                    phone = SelectedPhoneBook.Phone;
                }
                if (SelectedPhoneBook.Country == null)
                {
                    MessageBox.Show("Choose a country", "Eror 5", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    correctAnswerCounter += 1;
                    country = SelectedPhoneBook.Country.ToString()!;
                }
                var PhoneBook = new PhoneBook() { Name = name, Surname = surname, Phone = phone, Country = country };
                var results = new List<ValidationResult>();
                var context = new ValidationContext(PhoneBook);
                bool isValid = Validator.TryValidateObject(PhoneBook, context, results, true);
                if (correctAnswerCounter == 4)
                {
                    if (!isValid)
                    {
                        foreach (ValidationResult error in results)
                        {
                            MessageBox.Show(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage, "Eror 1", MessageBoxButton.OK, MessageBoxImage.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;
            }
            public void AddPhoneBook()
            {
                if(VerificationOfEnteredData())
                    phoneBooks.Add(SelectedPhoneBook.Clone());
            }
            public void RemovePhoneBook()
            {
                phoneBooks.Remove(SelectedPhoneBook);
            }
            public void ClearPhoneBook()
            {
                phoneBooks.Clear();
            }
            public void CopyPhoneBookPhoneBook()
            {
                if (VerificationOfEnteredData())
                    phoneBooks.Add(SelectedPhoneBook.Clone());
            }
            public IEnumerable<string> ListCountry => listCountry;
            public IEnumerable<PhoneBook> PhoneBooks => phoneBooks;
            private PhoneBook selectedPhoneBook;
            public PhoneBook SelectedPhoneBook
            {
                get { return selectedPhoneBook; }
                set { selectedPhoneBook = value ?? new PhoneBook(); }
            }

            public ICommand CopyPhoneBookComand => copyPhoneBookComand;
            public ICommand RemovePhoneBookComand => removePhoneBookComand;
            public ICommand ClearPhoneBookComand => clearPhoneBookComand;
            public ICommand AddPhoneBookComand => addPhoneBookComand;

        }
    }
}

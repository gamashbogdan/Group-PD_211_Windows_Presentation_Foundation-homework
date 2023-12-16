using PropertyChanged;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

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
                copyPhoneBookComand = new RelayCommand((o) => CopyPhoneBookPhoneBook(),(o)=>SelectedPhoneBook!=null);
                removePhoneBookComand = new RelayCommand((o) => RemovePhoneBook(), (o) => SelectedPhoneBook != null);
                clearPhoneBookComand = new RelayCommand((o) => ClearPhoneBook(), (o) => phoneBooks.Any());
                //addPhoneBookComand = new RelayCommand((o) => AddPhoneBook());
            }
            public void AddPhoneBook(PhoneBook phoneBook)
            {

                phoneBooks.Add(phoneBook);
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
                phoneBooks.Add(SelectedPhoneBook.Clone());
            }
            public IEnumerable<PhoneBook> PhoneBooks => phoneBooks;
            public IEnumerable<string> ListCountry => listCountry;
            public PhoneBook SelectedPhoneBook { get; set; }
            public ICommand CopyPhoneBookComand => copyPhoneBookComand;
            public ICommand RemovePhoneBookComand => removePhoneBookComand;
            public ICommand ClearPhoneBookComand => clearPhoneBookComand;

        }
    }
}

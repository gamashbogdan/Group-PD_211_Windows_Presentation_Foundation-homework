using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MVVM_Pattern_Commands
{
    [AddINotifyPropertyChangedInterface]
    internal class PhoneBook
    {
        public string Name {  get; set; }
        public string Surname {  get; set; }
        [RegularExpression(@"^\+38-0\d{2}-\d{3}-\d{2}-\d{2}$|^\+380\d{9}$", ErrorMessage = "Incorrect phone number input format!\nTry this format (+38-011-222-33-44-) or this one (+380123456789)")]
        public string Phone {  get; set; }
        public string Country {  get; set; }
        public PhoneBook Clone()
        {
            PhoneBook copyPhoneBook = (this.MemberwiseClone() as PhoneBook)!;
            copyPhoneBook.Name = (string)this.Name.Clone();
            copyPhoneBook.Surname = (string)this.Surname.Clone();
            copyPhoneBook.Phone = (string)this.Phone.Clone();
            copyPhoneBook.Country = (string)this.Country.Clone();
            return copyPhoneBook;
        }
        public string FullInfo => Name + ", " + Surname + ", " + Phone;
    }
}

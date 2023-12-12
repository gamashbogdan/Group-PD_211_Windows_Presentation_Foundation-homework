using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _04_List_Controls_Collection_Binding
{
    class PhoneBook
    {
        private string name;
        public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string surname;
		public string Surname
		{
			get { return surname; }
			set { surname = value; }
		}
        [RegularExpression(@"^\+38-0\d{2}-\d{3}-\d{2}-\d{2}$|^\+380\d{9}$", ErrorMessage = "EROR 1\nIncorrect phone number input format!\nTry this format (+38-011-222-33-44-) or this one (+380123456789)")]
		private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                var validationContext = new ValidationContext(this) { MemberName = nameof(Phone) };
                var validationResults = new List<ValidationResult>();

                if (!Validator.TryValidateProperty(value, validationContext, validationResults))
                {
                    foreach (var validationResult in validationResults)
                    {
                        MessageBox.Show(validationResult.ErrorMessage);
                    }
                }
                else
                {
                    phone = value;
                }
            }
        }
        private string country;
        public string Country
        {
			get { return country; }
			set { country = value; }
		}
		public string FullInfo =>Name + ", " + Surname + ", " + Phone;
    }
}

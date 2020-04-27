using System;
using System.Collections.Generic;

namespace DynamicTabView.Model
{
    public class Contact : ModelBase
    {
        private string _name;
        private string _surname;
        private DateTime? _birthdate;
        private string _remarks;

        public Contact()
        {
            Addresses = new List<ContactAddress>();
            Communications = new List<ContactCommunication>();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                if (_surname != value)
                {
                    _surname = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime? Birthdate
        {
            get { return _birthdate; }
            set
            {
                if (_birthdate != value)
                {
                    _birthdate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Remarks
        {
            get { return _remarks; }
            set
            {
                if (_remarks != value)
                {
                    _remarks = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ICollection<ContactAddress> Addresses { get; }
        public ICollection<ContactCommunication> Communications { get; }
    }
}

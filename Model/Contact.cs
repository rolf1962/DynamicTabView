using System;
using System.Collections.Generic;

namespace DynamicTabView.Model
{
    public class Contact
    {
        public Contact()
        {
            Addresses = new List<ContactAddress>();
            ContactCommunications = new List<ContactCommunication>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Remarks { get; set; }

        public ICollection<ContactAddress> Addresses { get; }
        public ICollection<ContactCommunication> ContactCommunications { get; }
    }
}

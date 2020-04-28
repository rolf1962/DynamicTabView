using DynamicTabView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace DynamicTabView.DataAccess
{
    public class ContactsContext
    {
        private static ContactsContext _instance = null;
        
        public static ContactsContext Instance
        {
            get
            {
                if (null == _instance)
                {
                    _instance = new ContactsContext();
                }
                return _instance;
            }
        }

        private ContactsContext()
        {
            Contacts = new List<Contact>();
            SettingsPaths = new SettingsPaths();

            CreateData();
        }

        private void CreateData()
        {
            Contacts.Add(new Contact() { Name = "Doe", Surname = "Jane", Birthdate = new DateTime(1999, 2, 24) });
            Contacts.Add(new Contact() { Name = "Doe", Surname = "John", Birthdate = new DateTime(1998, 1, 23) });
            Contacts.Add(new Contact() { Name = "Acme", Surname = "Marvin", Birthdate = new DateTime(1947, 6, 5) });


            Contact janeDoe = Contacts.First(c => c.Name == "Doe" && c.Surname == "Jane");
            Contact johnDoe = Contacts.First(c => c.Name == "Doe" && c.Surname == "John");
            Contact marvinAcme = Contacts.First(c => c.Name == "Acme" && c.Surname == "Marvin");

            janeDoe.Addresses.Add(new ContactAddress()
            {
                ZipCode= "SE8 4NS",
                City = "London",
                Street = "Deptford High Street",
                HouseNo = "112/114"
            });

            johnDoe.Addresses.Add(Contacts.FirstOrDefault(c => c.Name == "Doe" && c.Surname == "Jane").Addresses.First());

            marvinAcme.Addresses.Add(new ContactAddress()
            {
                ZipCode = "SW16 6EN",
                City = "London",
                Street = "Streatham High Road",
                HouseNo = "243A"
            });

            janeDoe.Communications.Add(new ContactCommunication()
            {
                CommunicationType= CommunicationType.FonBusiness,
                Access= "+44 7961 823272"
            });

            janeDoe.Communications.Add(new ContactCommunication()
            {
                CommunicationType = CommunicationType.Email,
                Access = "jane.doe@somewhere.org"
            });

            johnDoe.Communications.Add(janeDoe.Communications.First(c => c.CommunicationType == CommunicationType.FonBusiness));

            johnDoe.Communications.Add(new ContactCommunication()
            {
                CommunicationType = CommunicationType.Email,
                Access = "john.doe@somewhere.org"
            });

            marvinAcme.Communications.Add(new ContactCommunication()
            {
                CommunicationType = CommunicationType.Email,
                Access = "marvin.acme@somewhere.org"
            });

            SettingsPaths.ImageLibraryPath = @".\ImageLibrary";
            SettingsPaths.StoragePath = @".\Data";
            SettingsPaths.TempPath = Environment.GetEnvironmentVariable("TEMP");
        }

        public ICollection<Contact> Contacts { get; }
        public SettingsPaths SettingsPaths { get; }
    }
}

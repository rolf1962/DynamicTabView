using DynamicTabView.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DynamicTabView.DataAccess
{
    public class ContactsContext
    {
        public ContactsContext()
        {
            Contacts = new List<Contact>();
            SettingsColors = new SettingsColors();
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

            janeDoe.ContactCommunications.Add(new ContactCommunication()
            {
                CommunicationType= CommunicationType.FonBusiness,
                Access= "+44 7961 823272"
            });

            janeDoe.ContactCommunications.Add(new ContactCommunication()
            {
                CommunicationType = CommunicationType.Email,
                Access = "jane.doe@somewhere.org"
            });

            johnDoe.ContactCommunications.Add(janeDoe.ContactCommunications.First(c => c.CommunicationType == CommunicationType.FonBusiness));

            johnDoe.ContactCommunications.Add(new ContactCommunication()
            {
                CommunicationType = CommunicationType.Email,
                Access = "john.doe@somewhere.org"
            });

            marvinAcme.ContactCommunications.Add(new ContactCommunication()
            {
                CommunicationType = CommunicationType.Email,
                Access = "marvin.acme@somewhere.org"
            });

            SettingsColors.BackgroundColor = Colors.Blue;
            SettingsColors.BorderColor = Colors.Yellow;
            SettingsColors.TextColor = Colors.Red;

            SettingsPaths.ImageLibraryPath = @".\ImageLibrary";
            SettingsPaths.StoragePath = @".\Data";
            SettingsPaths.TempPath = Environment.GetEnvironmentVariable("TEMP");
        }

        public ICollection<Contact> Contacts { get; }
        public SettingsColors SettingsColors { get; }
        public SettingsPaths SettingsPaths { get; }
    }
}

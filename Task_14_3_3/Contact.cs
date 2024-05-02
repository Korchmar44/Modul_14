using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_3_3
{
    public class Contact
    {
        public string Name { get; }
        public string LastName { get; }
        public string PhoneNumber { get; }
        public string Email { get; }

        public List<Contact> Contacts { get; private set; }

        public Contact() { }

        public Contact(string name, string lastName, string phoneNumber, string email)
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Contacts = new List<Contact>();
        }
        public override string ToString()
        {
            return $"Name: {Name}, Last Name: {LastName}, Phone Number: {PhoneNumber}, Email: {Email}";
        }

        public List<Contact> AddContact(Contact newContact)
        {
            if (Contacts == null)
            {
                Contacts = new List<Contact>();
            }

            if (!Contacts.Any() || !Contacts.Any(c => c.Name == newContact.Name && c.PhoneNumber == newContact.PhoneNumber))
            {
                Contacts.Add(newContact);
            }

            return Contacts;
        }

        public List <Contact> GetContactsByName() 
        {
            Contacts = (from c in Contacts orderby c.Name select c).ToList();
            return Contacts;
        }

        public List<Contact> GetContactsByLastName()
        {
            Contacts = (from c in Contacts orderby c.LastName select c).ToList();
            return Contacts;
        }
    }
}

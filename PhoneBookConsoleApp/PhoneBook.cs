using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsoleApp
{
    public class PhoneBook
    {
        private List<Contact> _contact { get; set; } = new List<Contact>();
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }
        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach(var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void AddContact(Contact contact)
        {
            _contact.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = _contact.Where(c => c.Number.Contains(number)).ToList();
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactsDetails(contact);
            }
        }

        public void DisplayAllContacts()
        {
            foreach(var contact in _contact)
            {
                DisplayContactsDetails(_contact);
            }
        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = _contact.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
    }
}

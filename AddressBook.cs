using System;
using System.Collections.Generic;

namespace addressBook
{
    public class AddressBook
    {
        public AddressBook()
        {
            ContactList = new Dictionary<string, Contact>();
        }
        public Dictionary<string, Contact> ContactList { get; set; }

        public void AddContact(string Email, Contact NewContact)
        {
            ContactList.Add(Email, NewContact);
        }

        public void GetByEmail(string Email)

        {
            ContactList.TryGetValue(Email, out Contact contact);
            return contact;

        }

    }

}


using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManager.Entities
{
    public class Contacts
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<ContactEmails> EmailAddresses { get; set; }
        public IEnumerable<ContactPhones> PhoneNumbers { get; set; }
        
    }
}

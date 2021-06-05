using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using ContactManager.Entities;
using ContactManager.Providers.DataContext;

namespace ContactManager.Providers.Repository
{
    public class ContactsRepository : IContactsRepository
    {
        private readonly ContactsDbContext _contactsDbContext;
        private static List<Contacts> contactsList = new List<Contacts>();
        public ContactsRepository(ContactsDbContext contactsDbContext)
        {
            _contactsDbContext = contactsDbContext;
        }
        public Contacts Add(Contacts item)
        {
            _contactsDbContext.Contacts.Add(item);
            _contactsDbContext.SaveChanges();
            return item;
        }
        
        public Contacts Find(int Id)
        {
            var contactItem = contactsList.Find(e => e.Id == Id);
            return contactItem;
        }

        public IEnumerable<Contacts> GetAll()
        {
            contactsList = _contactsDbContext.Contacts.ToList<Contacts>();
            return contactsList;
        }

        public void Remove(int Id)
        {
            var itemToRemove = contactsList.SingleOrDefault(r => r.Id == Id);
            if (itemToRemove != null)
                contactsList.Remove(itemToRemove);
        }

        public Contacts Update(Contacts item)
        {
            var itemToUpdate = contactsList.SingleOrDefault(r => r.Id == item.Id);
            if (itemToUpdate != null)
            {
                itemToUpdate.FirstName = item.FirstName;
                itemToUpdate.LastName = item.LastName;
               
            }
            return itemToUpdate;
        }

       
    }
}

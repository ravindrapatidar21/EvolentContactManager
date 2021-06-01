using ContactManager.Entities;
using System;
using System.Collections.Generic;

namespace ContactManager.Providers
{
    public interface IContactsRepository
    {
        Contacts Add(Contacts item);
        IEnumerable<Contacts> GetAll();
        Contacts Find(int id);
        void Remove(int Id);
        Contacts Update(Contacts item);
    }
}

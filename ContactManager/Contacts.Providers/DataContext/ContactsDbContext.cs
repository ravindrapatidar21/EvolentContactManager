using ContactManager.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManager.Providers.DataContext
{
    public class ContactsDbContext : DbContext
    {
        public ContactsDbContext(DbContextOptions<ContactsDbContext> options)
            : base(options) { }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<ContactEmails> ContactEmails { get; set; }
        public DbSet<ContactPhones> ContactPhones { get; set; }
    }
}

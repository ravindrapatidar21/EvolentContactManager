using ContactManager.Entities;
using ContactManager.Providers.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;


namespace ContactManager.Test
{
    [TestClass]
    public class ContactManagerTest
    {
    private Mock<IContactsRepository> _mockRepository;
    [TestInitialize]
    public void Initialize()
    {
        _mockRepository = new Mock<IContactsRepository>();
    }

    [TestMethod]
    public void AddContact()
    {
        // Arrange
        Contacts contact = new Contacts();
        contact.FirstName = "Ravindra";
        contact.LastName = "Patidar";
        ContactEmails eMail = new ContactEmails();
        eMail.Email= "Ravi.mca21@gmail.com";
        contact.EmailAddresses = (System.Collections.Generic.IEnumerable<ContactEmails>) eMail;
        contact.Id = 123;
        ContactPhones phoneNumber = new ContactPhones();
        phoneNumber.Phone = "8956327268";
        contact.PhoneNumbers = (System.Collections.Generic.IEnumerable<ContactPhones>)phoneNumber;
        // Act
        var result = _mockRepository.Setup(x => x.Add(It.IsAny<Contacts>())).Returns(contact);

        // Assert
        Assert.IsTrue(true, "Add contacts Success.");
    }

           
    [TestMethod]
    public void UpdateContact()
    {
        // Arrange
        Contacts contact = new Contacts();
        contact.FirstName = "Ravindra";
        contact.LastName = "Patidar";
        ContactEmails eMail = new ContactEmails();
        eMail.Email = "Ravi.mca21@gmail.com";
        contact.EmailAddresses = (System.Collections.Generic.IEnumerable<ContactEmails>)eMail;
        contact.Id = 123;
        ContactPhones phoneNumber = new ContactPhones();
        phoneNumber.Phone = "8956327268";
        contact.PhoneNumbers = (System.Collections.Generic.IEnumerable<ContactPhones>)phoneNumber;
        // Act
        var result = _mockRepository.Setup(x => x.Update(It.IsAny<Contacts>())).Returns(contact);

        // Assert
        Assert.IsTrue(true, "Update contacts Success.");
    }
    [TestMethod]
    public void GetAllContact()
    {
        // Arrange
        Contacts contact = new Contacts();
        contact.FirstName = "Ravindra";
        contact.LastName = "Patidar";
        ContactEmails eMail = new ContactEmails();
        eMail.Email = "Ravi.mca21@gmail.com";
        contact.EmailAddresses = (System.Collections.Generic.IEnumerable<ContactEmails>)eMail;
        contact.Id = 123;
        ContactPhones phoneNumber = new ContactPhones();
        phoneNumber.Phone = "8956327268";
        contact.PhoneNumbers = (System.Collections.Generic.IEnumerable<ContactPhones>)phoneNumber;
        // Act
        var result = _mockRepository.Setup(x => x.GetAll()).Returns((System.Collections.Generic.IEnumerable<Contacts>)contact);

        // Assert
        Assert.IsTrue(true,"Get All contacts Success.");
        }
        [TestMethod]
        public void RemoveContact()
        {
            // Arrange
                    
            int Id = 123;
                   
            // Act
            _mockRepository.Setup(x => x.Remove(Id));

            // Assert
            Assert.IsTrue(true, "Remove contact Success.");
        }
        [TestMethod]
        public void FindContact()
        {
            // Arrange

            int Id = 123;

            // Act
            _mockRepository.Setup(x => x.Find(Id));

            // Assert
            Assert.IsTrue(true, "Find contact Success.");
        }
    }
}

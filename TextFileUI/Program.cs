﻿using DataAccessTextLibrary;
using DataAccessTextLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
namespace TextFileUI
{
    class Program
    {
        private static IConfiguration _config;
        private static string textFile;
        private static TextFileDataAccess db = new TextFileDataAccess();

        static void Main(string[] args)
        {
            InitializeConfiguration();
            
            textFile = "D:\\Demos\\Contacts.txt";
            // textFile = _config.GetSection("TextFile");
            // textFile = _config.GetValue<string>("TextFile");

            ContactModel user1 = new ContactModel();
            user1.FirstName = "John";
            user1.LastName = "Snow";
            user1.EmailAddresses.Add("John@gmail.com");
            user1.EmailAddresses.Add("me@gmail.com");
            user1.PhoneNumbers.Add("555-1212");
            user1.PhoneNumbers.Add("555-1234");

            ContactModel user2 = new ContactModel();
            user2.FirstName = "susan";
            user2.LastName = "Snow";
            user2.EmailAddresses.Add("nope@aol.com");
            user2.EmailAddresses.Add("me@gmail.com");
            user2.PhoneNumbers.Add("555-1212");
            user2.PhoneNumbers.Add("555-9876");

            //CreateContact(user1);
            //CreateContact(user2);
            //GetAllContacts();

            //UpdateContactsFirstName("John");
            //GetAllContacts();

            //Console.WriteLine();

            //RemovePhoneNumberFromUser("555-1212");
            //GetAllContacts();

            RemoveUser();
            GetAllContacts();

            Console.WriteLine("Done processing text file");

            Console.ReadLine();
        }

        public static void RemoveUser()
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts.RemoveAt(0);
            db.WriteAllRecords(contacts, textFile);
        }

        public static void RemovePhoneNumberFromUser(string phoneNumber)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts[0].PhoneNumbers.Remove(phoneNumber);
            db.WriteAllRecords(contacts, textFile);
        }

        private static void UpdateContactsFirstName(string firstName)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts[0].FirstName = firstName;
            db.WriteAllRecords(contacts, textFile);
        }

        private static void GetAllContacts()
        {
            var contacts = db.ReadAllRecords(textFile);

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{ contact.FirstName } { contact.LastName }");
            }
        }

        private static void CreateContact(ContactModel contact)
        {
            var contacts = db.ReadAllRecords(textFile);

            contacts.Add(contact);

            db.WriteAllRecords(contacts, textFile);
        }

        private static void InitializeConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            _config = builder.Build();
        }
    }
}
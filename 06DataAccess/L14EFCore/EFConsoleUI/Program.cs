using System;
using System.Linq;
using EFConsoleUI.DataAccess;
using EFConsoleUI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateTim();
            //ReadAll();
            //ReadById(1);
            //CreateCharity();
            //UpdateFirstName(1, "John");
            //ReadAll();

            //RemovePhoneNumber(1, "555-1212");

            //RemoveUser(3);
            //ReadAll();

            Console.WriteLine("Done Processing");
            Console.ReadLine();
        }

        public static void RemoveUser(int id)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts
                    .Include(e => e.EmailAddresses)
                    .Include(p => p.PhoneNumbers)
                    .Where(c => c.Id == id).First();
                db.Contacts.Remove(user);
                db.SaveChanges();
            }
        }

        public static void RemovePhoneNumber(int id, string phoneNumber)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts
                    .Include(p => p.PhoneNumbers)
                    .Where(c => c.Id == id).First();

                user.PhoneNumbers.RemoveAll(p => p.PhoneNumber == phoneNumber);

                db.SaveChanges();
            }
        }

        private static void UpdateFirstName(int id, string firstName)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts.Where(c => c.Id == id).First();

                user.FirstName = firstName;

                db.SaveChanges();
            }
        }

        private static void CreateTim()
        {
            var c = new Contact
            {
                FirstName = "John",
                LastName = "Snow"
            };
            c.EmailAddresses.Add(new Email { EmailAddress = "John@gmail.com" });
            c.EmailAddresses.Add(new Email { EmailAddress = "me@gmail.com" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1212" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1234" });

            using (var db = new ContactContext())
            {
                db.Contacts.Add(c);
                db.SaveChanges();
            }
        }

        private static void CreateCharity()
        {
            var c = new Contact
            {
                FirstName = "susan",
                LastName = "Snow"
            };
            c.EmailAddresses.Add(new Email { EmailAddress = "nope@aol.com" });
            c.EmailAddresses.Add(new Email { EmailAddress = "me@gmail.com" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1212" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-9876" });

            using (var db = new ContactContext())
            {
                db.Contacts.Add(c);
                db.SaveChanges();
            }
        }

        private static void ReadAll()
        {
            using (var db = new ContactContext())
            {
                var records = db.Contacts
                    //.Include(e => e.EmailAddresses)
                    //.Include(p => p.PhoneNumbers)
                    .ToList();

                foreach (var c in records)
                {
                    Console.WriteLine($"{c.FirstName} {c.LastName}");
                }
            }
        }

        private static void ReadById(int id)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts.Where(c => c.Id == id).First();

                Console.WriteLine($"{user.FirstName} {user.LastName}");
            }
        }
    }
}
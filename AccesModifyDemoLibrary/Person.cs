﻿using System;

namespace AccesModifyDemoLibrary
{
    public class Person
    {
        private protected string formerLastName = "";

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private string _ssn;

        public string SSN
        {
            get
            {
                return $"***-**-{ _ssn.Substring(_ssn.Length - 4) }";
            }
            set
            {
                _ssn = value;
            }
        }

        public void ChangeLastName(string newLastName)
        {
            formerLastName = LastName;
            LastName = newLastName;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello { FirstName }");
        }

        public void SavePerson()
        {
            DataAccess data = new DataAccess();
            string conn = data.GetConnectionString();
            // saves the person
        }
    }
}
using System;
using System.Collections.Generic;

namespace CommonSyntaxL13
{
    class Program
    {
        private static List<string> parties = new List<string>();
        private static int totalGuests = 0;
        static void Main(string[] args)
        {
            LoadGuests();

            DisplayGuests();

            DisplayGuestCount();

            Console.ReadLine();
        }
        private static void DisplayGuestCount()
        {
            Console.WriteLine();

            Console.WriteLine($"Total Guests: { totalGuests }");
        }

        private static void DisplayGuests()
        {
            Console.WriteLine();
            Console.WriteLine("Guest Parties at Event:");

            foreach (string name in parties)
            {
                Console.WriteLine(name);
            }
        }

        private static void LoadGuests()
        {
            string moreGuestsComing = "";

            do
            {
                string partyName = GetInfoFromConsole("What is your party/group name: ");

                parties.Add(partyName);

                totalGuests += GetPartySize();

                DisplayGuestCount();

                moreGuestsComing = GetInfoFromConsole("Do you want to add another guest (yes/no): ");
            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static int GetPartySize()
        {
            bool isValidNumber = false;
            int output = 0;

            do
            {
                string partySizeText = GetInfoFromConsole("How many people are in your party: ");

                isValidNumber = int.TryParse(partySizeText, out output);
            } while (isValidNumber == false);

            return output;
        }

        private static string GetInfoFromConsole(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }
    }
}
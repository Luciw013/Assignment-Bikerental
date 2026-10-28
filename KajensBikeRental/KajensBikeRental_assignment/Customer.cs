using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Xml.Linq;

namespace KajensBikeRental_assignment
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMember { get; set; }
        public static List<Customer> ListOfCustomers { get;} = new List<Customer>();

        public Customer(string name, int age, bool isMember)
        {
            Name = name;
            Age = age;
            IsMember = isMember;
        }

        public static Customer RegisterNewCustomer()
        {
            Console.WriteLine("Ange kunduppgifter: ");
            Console.Write($"Namn: ");
            string newName = Console.ReadLine(); //lagrar + läser in inmatning som string
            Console.Write("Ålder: ");
            int newAge = int.Parse(Console.ReadLine());  //konverterar inläst värde från string till int.
            Console.Write("Är kunden medlem? (ja/nej): ");
            string newIsMember = Console.ReadLine().ToLower();
            while (newIsMember != "ja" && newIsMember != "nej") //hindrar fel inmatning + risk att boolean sätts i fel läge.
            {
                Console.Write("Ogiltigt svar, ange ja eller nej:");
                newIsMember = Console.ReadLine().ToLower();
            }

            bool isMember = newIsMember == "ja";

            Console.WriteLine("Kunden är registrerad.");

            Customer newCustomer = new Customer(newName, newAge, isMember); //gör användar-inmatad info till objekt + variabel som kan skickas vidare.

            return newCustomer; //


        }

           

    }
}

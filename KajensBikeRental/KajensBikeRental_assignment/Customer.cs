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

        public static Customer RegisterCustomer() // skapar kond-objekt från användar-input
        {
            
            Console.WriteLine("Ange kunduppgifter: ");
            Console.Write($"Namn: ");
            string newName = Console.ReadLine(); 
            Console.Write("Ålder: ");
            int newAge = int.Parse(Console.ReadLine());  //konverterar användar-input från string till int.
            Console.Write("Är kunden medlem? (ja/nej): ");
            string newIsMember = Console.ReadLine().ToLower();
            while (newIsMember != "ja" && newIsMember != "nej") //begränsar giltiga svarsalternativ (så bool inte tolkas fel}
            {
                Console.Write("Ogiltigt svar, ange ja eller nej:");
                newIsMember = Console.ReadLine().ToLower();
            }

            bool isMember = newIsMember == "ja";

            Console.WriteLine("Kunden är registrerad.");

            Customer newCustomer = new Customer(newName, newAge, isMember); //gör kundobjekt

            //ListOfCustomers.Add(newCustomer);
            RentVehicle rentVehicle = new RentVehicle();    //koppling till RentVehicle-class, så den når newCustomer-variabel

            return newCustomer;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace KajensBikeRental_assignment
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool Rentable { get; set; }
        public decimal PricePerHour { get; protected set; }

        public Vehicle(int id, string type, bool rentable)
        {
            Id = id;
            Type = type;
            Rentable = rentable;
        }
        
        public virtual void ShowAllBikes()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Typ: {Type}");
            Console.WriteLine($"Status: {Rentable}");
        }

        

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace KajensBikeRental_assignment
{
    public class Bike : Vehicle
    {
        public decimal PricePerHour = 40.00m;
        public Bike(int id, string type, decimal priceperhour, bool rentable) : base(id, type, rentable)
        {
            Id = id;
            Type = type;
            PricePerHour = priceperhour;
            Rentable = rentable;
        }

        public override void ShowAllBikes()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Typ: {Type}");
            Console.WriteLine($"Status: {Rentable}");
        }







    }
}

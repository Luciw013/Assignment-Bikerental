using System;
using System.Collections.Generic;
using System.Text;

namespace KajensBikeRental_assignment
{
    public class Bike : Vehicle
    {
        public Bike(int id, string type, decimal baseprice, bool status) : base(id, type, baseprice, status)
        {
            Id = id;
            Type = type;
            Baseprice = baseprice;
            Status = status;
        }

        public override void ShowAllBikes()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Typ: {Type}");
            Console.WriteLine($"Baspris: {Baseprice}");
            Console.WriteLine($"Är tillgänglig: {Status}");
        }







        }
}

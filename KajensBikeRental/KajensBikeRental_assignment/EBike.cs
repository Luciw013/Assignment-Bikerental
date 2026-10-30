using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace KajensBikeRental_assignment
{
    public class EBike : Vehicle
    {
        public int BatteryLevel { get; set; }
        public decimal PricePerHour = 70.00m;

        public EBike(int id, string type, decimal priceperhour, bool rentable, int batterylevel) : base(id, type, rentable)
        {
            BatteryLevel = batterylevel;
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
            Console.WriteLine($"Batteri: {BatteryLevel}%");
        }

        //public void ChargeBattery(bike)
        //{
        // EBike   
        //    if ( >= 100)
        //    {
        //        bike = 100;
        //    }
                    
                    
        //}
                                               
                                               
                                               
                                               
                                               
                                               
    }
    
















    
}

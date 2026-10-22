using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace KajensBikeRental_assignment
{
    public class EBike : Vehicle
    {
        public int BatteryLevel { get; set; }

        public EBike(int id, string type, decimal baseprice, bool status, int batterylevel) : base(id, type, baseprice, status)
        {
            BatteryLevel = batterylevel;
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
            Console.WriteLine($"Batteri: {BatteryLevel}%");
        }
    }











    
}

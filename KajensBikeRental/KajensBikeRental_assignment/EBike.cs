using System;
using System.Collections.Generic;
using System.Text;

namespace KajensBikeRental_assignment
{
    public class EBike : Vehicle
    {
        public int BatteryLevel { get; set; }

        public EBike(string id, decimal baseprice, bool status)
        {
            Id = id;
            Baseprice = baseprice;
            Status = status;
        }

        public override void ShowAllBikes()
        { }








        //metod som kollar kundens ålder



    }
}

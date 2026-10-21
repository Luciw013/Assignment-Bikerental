using System;
using System.Collections.Generic;
using System.Text;

namespace KajensBikeRental_assignment
{
    public class Bike : Vehicle
    {
        public Bike(string id, decimal baseprice, bool status)
        {
            Id = id;
            Baseprice = baseprice;
            Status = status;
        }

        public override void ShowAllBikes()
        { }



        

    }
}

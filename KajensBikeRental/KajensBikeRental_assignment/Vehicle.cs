using System;
using System.Collections.Generic;
using System.Text;

namespace KajensBikeRental_assignment
{
    public class Vehicle
    {
        public string Id { get; set; }
        public decimal Baseprice { get; set; } 
        public bool Status { get; set; }


        public virtual void ShowAllBikes()
        { }



    }
}

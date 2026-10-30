using System;
using System.Collections.Generic;
using System.Text;

namespace KajensBikeRental_assignment
{
    public class RentVehicle
    {
        public void StartRental(Customer newCustomer, Vehicle bike)
        {
            if (bike.Rentable == true)
            {
                bike.Rentable = false;

                Console.WriteLine($"Fordon {bike.Id} är uthyrd till {newCustomer}");
            }
            else
            {
                Console.WriteLine("Fordonet är redan uthyrt.");
            }
        }













    }












}
}

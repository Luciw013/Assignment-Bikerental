using System;
using System.Collections.Generic;
using System.Text;

namespace KajensBikeRental_assignment
{
    public class RentVehicle
    {
      
        public void StartRental(Customer customer, List<Vehicle> vehicles)
        {
            Console.WriteLine("Ange fordons-id för att välja cykel:");
            int chosenbike = int.Parse(Console.ReadLine());
            Vehicle bikechoice = vehicles.Find(bike => bike.Id == chosenbike);
            if (bikechoice.Rentable == true)
            {
                bikechoice.Rentable = false;
                Console.WriteLine($"Fordon {bikechoice.Id} är uthyrd till {customer.Name}");
            }
            else
            {
                Console.WriteLine("Fordonet kan inte hyras ut.");
            }
        }

    }
}

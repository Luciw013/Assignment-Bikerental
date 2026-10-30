using System;
using System.Collections.Generic;
using System.Text;

namespace KajensBikeRental_assignment
{
    public class RentalManager
    {

        public void StartRental(Customer customer, List<Vehicle> vehicles)
        {
            foreach (Vehicle bike in vehicles)
            {
                if (bike is EBike ebike && ebike.BatteryLevel < 30)
                {
                    bike.Rentable = false;
                }

                if (bike is EBike && customer.Age <= 17)
                {
                    bike.Rentable = false;
                }
            }

            Console.WriteLine("Ange fordons-id för att välja cykel:");
            int chosenbike = int.Parse(Console.ReadLine());
            Vehicle bikechoice = vehicles.Find(bike => bike.Id == chosenbike);
            if (bikechoice == null)
            {
                Console.WriteLine("Fordonet finns ej.");
                return;
            }

            else if (bikechoice.Rentable == true && (customer.Age >= 15)) //kollar fordons-tillgänglighet + kund åldersgräns
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
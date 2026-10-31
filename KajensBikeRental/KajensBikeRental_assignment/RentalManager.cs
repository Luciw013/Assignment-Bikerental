using System;
using System.Collections.Generic;
using System.Text;

namespace KajensBikeRental_assignment
{
    public class RentalManager
    {

        public void StartRental(Customer customer, List<Vehicle> vehicles)
        {
            

            Console.WriteLine("Ange fordons-id för att välja cykel:");
            int chosenbike = int.Parse(Console.ReadLine());
            Vehicle bikechoice = vehicles.Find(bike => bike.Id == chosenbike);
            if (bikechoice == null)
            {
                Console.WriteLine("Fordonet finns ej.");
                return;
            }

            if (!bikechoice.Rentable) //kollar fordons-tillgänglighet
            {
                Console.WriteLine("Fordonet är inte tillgängligt.");
                return;
            }

            if  (customer.Age < 15)  //kollar kund minimum-åldersgräns
            {
                Console.WriteLine("Uthyrning till kund under 15 år ej tillåtet.");
                return;
            }

            if (bikechoice is EBike ebike)
            {
                if (customer.Age <= 17)             //åldersgräns för uthyrning av elcykel
                {
                    Console.WriteLine("Kund under 18 år får ej hyra elcykel.");
                    return;
                }

                if (ebike.BatteryLevel < 30)
                {
                    Console.WriteLine("Lågt batteri. Ladda innan uthyrning.");
                    return;
                }

            }
            
            bikechoice.Rentable = false;
            Console.WriteLine($"Fordon {bikechoice.Id} är uthyrd till {customer.Name}");
        }

        public void ReturnVehicle(Customer customer, List<Vehicle> vehicles)
        {






        }

        public void ChargeBattery(List<Vehicle> vehicles)
        {
            foreach (Vehicle bike in vehicles)
            {
                if (bike is EBike ebike && ebike.BatteryLevel < 30)
                {
                    ebike.BatteryLevel = 100;
                }
            }
        }










    } 


          
            
}   
using KajensBikeRental_assignment;
using System.Xml.Linq;

//Fordons-objekt i lista
List<Vehicle> vehicles = new List<Vehicle>();
Vehicle bike1 = new Bike(1, "Cykel", 40.00m, true);
Vehicle bike2 = new Bike(2, "Cykel", 40.00m, true);
Vehicle bike3 = new EBike(3, "Elcykel", 70.00m, true, 80);
Vehicle bike4 = new EBike(4, "Elcykel", 70.00m, true, 25);
vehicles.AddRange(bike1, bike2, bike3, bike4);

//kundobjekt i lista
List<Customer> customers = new List<Customer>();



//Menu
Console.WriteLine("---Kajens Cykeluthyrning---");
Console.WriteLine("Gör ett av följande val");
Console.WriteLine("1. Visa alla fordon");
Console.WriteLine("2. Registrera kund");
Console.WriteLine("3. Hyr ut fordon");
Console.WriteLine("4: Lämna tillbaka fordon");
Console.WriteLine("5. Ladda");
Console.WriteLine("6: Avsluta");

while (true)
{
    int choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        foreach (Vehicle bike in vehicles)
        {
            bike.ShowAllBikes();
        }
    }

    else if (choice == 2)
    {
      //lägg till kund
    }




    else if (choice == 3)
    {
        //  hyr ut
    }

    else if (choice == 4)
    {
        //lämna tbx
    }

    else if (choice == 5)
    {
        //Ladda
    }

    else if (choice == 6)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt val");
    }
}

using KajensBikeRental_assignment;
using System.Reflection;
using System.Xml.Linq;

//Fordons-objekt i lista
List<Vehicle> vehicles = new List<Vehicle>();
Vehicle bike1 = new Bike(1, "Cykel", 40.00m, true);
Vehicle bike2 = new Bike(2, "Cykel", 40.00m, true);
Vehicle bike3 = new EBike(3, "Elcykel", 70.00m, true, 80);
Vehicle bike4 = new EBike(4, "Elcykel", 70.00m, true, 25);
vehicles.AddRange(bike1, bike2, bike3, bike4);

List<Customer> listOfCustomers = new List<Customer>();


//Meny
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
        
        Console.WriteLine("Ange kunduppgifter: ");
        Console.Write($"Namn: ");
        string newName = Console.ReadLine(); //lagrar + läser in inmatning som string
        Console.Write("Ålder: ");
        int newAge = int.Parse(Console.ReadLine());  //konverterar inläst värde från string till int.
        Console.Write("Är kunden medlem? (ja/nej): ");
        string newIsMember = Console.ReadLine().ToLower();

        bool isMember = newIsMember == "ja";

        Customer newCustomer = new Customer(newName, newAge, newIsMember);
        listOfCustomers.Add(newCustomer);



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

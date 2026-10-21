using KajensBikeRental_assignment;
using System.Xml.Linq;

//Lists
List<Vehicle> vehicles = new List<Vehicle>();
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
        Console.Write("Ange kundinformation: ");
        //string customer = Console.ReadLine();
        //customers.Add(new Customer
        //{
        //    Name = name;
        //    Age = age;
        //    Membership = membership;
        //});
       

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

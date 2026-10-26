using System;
using System.Collections.Generic;
using System.Text;

namespace KajensBikeRental_assignment
{
    public class Vehicle 
    {
        public int Id { get; set; }
        public string Type {  get; set; }
        public decimal Baseprice { get; set; } 
        public bool Status = false;
        public Vehicle(int id, string type, decimal baseprice, bool status)
        {
            Id = id;
            Type = type;
            Baseprice = baseprice;
            Status = status;
        }

        public virtual void ShowAllBikes()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Typ: {Type}");
            Console.WriteLine($"Är tillgänglig: {Status}");
        }

        
        
        
        
       
        //metod som kollar kundens ålder

    }
}

using System;
namespace AdventureWorkds.Models
{
    public class Adress
    {
        public string Id { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }
        public virtual List<Customer> Customers { get; set; }


        public Adress()
        {
            
        }
    }
}


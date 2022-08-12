using System;
namespace AdventureWorkds.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public virtual List<Adress> Adress { get; set; }

        public Customer()
        {

        }
    }
}


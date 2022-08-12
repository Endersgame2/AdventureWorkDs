using System;
using AdventureWorkds.Models;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorkds
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Customer> Customers;
        public DbSet<Adress> Adress;



    }
}


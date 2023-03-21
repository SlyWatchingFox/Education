using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForCodeFirst
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("CarDealership_CodeFirst")
        {

        }
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceMechanic> ServiceMechanics { get; set; }
        public DbSet<PartsUsed> PartsUseds { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<ServiceTicket> ServiceTickets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<SalesInvoice> SalesInvoices { get; set; }
        public DbSet<SalesPerson> SalesPersons { get; set; }
    }
}

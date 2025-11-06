using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // FONTOS: Ez most NEM Microsoft.EntityFrameworkCore

namespace UMFST.MIP.CarService
{
    public class AppContext : DbContext
    {

        public AppContext() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AppContext>());
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Diagnostic> Diagnostics { get; set; }
        public DbSet<Test> Tests { get; set; }
    }
}
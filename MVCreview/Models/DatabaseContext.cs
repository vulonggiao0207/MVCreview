using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() : base()
        {
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Dish>Dishes { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<OrderDetail>OrderDetails { get; set; }
}
}
using DeliveryApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Contexts
{
    //Контекст таблиць бази даних
    public class DeliveriesContext : DbContext
    {
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<DeliveryType> DeliveryTypes { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPS_Backend.DataModels
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Item> Items { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = mssqlstud.fhict.local; Database = dbi459818_ips3db; User Id = dbi459818_ips3db; Password = Phf0bJTiwt;");
            //"Server = database,1433; Database = dbi459818_ips3db; User Id = sa; Password = Phf0bJTiwt;" voor docker
            //"Server = mssqlstud.fhict.local; Database = dbi459818_ips3db; User Id = dbi459818_ips3db; Password = Phf0bJTiwt;" voor normaal
        }
    }
}

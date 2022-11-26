using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Models;

namespace Lab3
{
    class AppDBContext : DbContext
    {
        public AppDBContext():base("name=Model1")
        {

        }
        
        public DbSet<Hotel> Questions { get; set; } 
        //public DbSet<Order> Answers { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}

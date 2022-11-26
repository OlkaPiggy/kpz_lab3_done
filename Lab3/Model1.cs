using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Lab3.Models;

namespace Lab3
{
    public class Model1 : DbContext
    {
        public Model1(): base("name=Model1")
        {

        }
        public virtual DbSet<Hotel> Hotels { get; set; }
    }
}

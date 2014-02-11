using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalProject.Models
{
    public class HouseContext : DbContext
    {
        public HouseContext()
            : base("HouseSite")
        {
        }

        public DbSet<House> House { get; set; }
    }
}
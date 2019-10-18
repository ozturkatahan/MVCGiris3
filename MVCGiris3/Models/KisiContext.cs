using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCGiris3.Models
{
    public class KisiContext : DbContext
    {
        public KisiContext() : base("name=BaglantiCumlem")
        {
                
        }

        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
    }
}
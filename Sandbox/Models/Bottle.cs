using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Sandbox.Models
{
    public class Bottle
    {
        public int ID { get; set; }
        public string BottleName { get; set; }
        public decimal Price { get; set; }
        public int Volume { get; set; }
        public int ParLevel { get; set; }
        public int OnHand { get; set; }
        public string Notes { get; set; }
    }

        public class BottleDBContext : DbContext
    {
        public DbSet<Bottle> Bottles { get; set; }
    }
}


using NHL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NHL.Data
{
    public class NhlContext : DbContext
    {
        public NhlContext() : base("DefaultConnection") { }

        public DbSet<Player> Players { get; set; }
    }
}
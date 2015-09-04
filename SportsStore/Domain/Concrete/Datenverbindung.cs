using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SportsStore.Domain.Entities;
using SportsStore.Domain.Abstract;


namespace SportsStore.Domain.Concrete
{
    public class Datenverbindung2 : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
   
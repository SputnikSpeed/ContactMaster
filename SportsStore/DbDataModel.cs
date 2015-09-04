namespace SportsStore
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SportsStore.Domain.Entities;

    public partial class DbDataModel : DbContext
    {
        public DbDataModel()
            : base("name=Datenverbindung2")
        {
        }

        public virtual DbSet<account> account { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Product>()
                .Property(e => e.ImageMimeType)
                .IsUnicode(false);
        }
    }
}

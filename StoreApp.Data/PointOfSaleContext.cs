using Microsoft.EntityFrameworkCore;
using StoreApp.Models.Model;

namespace StoreApp.Data
{
    public class PointOfSaleContext : DbContext
    {
        public PointOfSaleContext(DbContextOptions<PointOfSaleContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
           // modelBuilder.Ignore<Sproc_FetchCountry>();
        }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductRates> ProductRates { get; set; }
        public DbSet<ProductTaxes> ProductTaxes { get; set; }
        public DbSet<ProductUnit> ProductUnits { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Sproc_FetchCountry> SprocFetchCountry { get; set; }

    }
}
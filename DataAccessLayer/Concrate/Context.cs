using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=104.247.162.242\\MSSQLSERVER2019;database=hizliana_core;user=hizliana_core;password=%cXv6l222");
        }

        public DbSet<Alerts> Alerts { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Markets> Markets { get; set; }
        public DbSet<ProductPrices> ProductPrices { get; set; }
        public DbSet<ProductRanks> ProductRanks { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<UserAPIs> UserAPIs { get; set; }
        public DbSet<UserProductPrices> UserProductPrices { get; set; }
        public DbSet<UserProducts> UserProducts { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<BuyboxTrack> BuyboxTracks { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}

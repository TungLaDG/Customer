using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Customer.Models
{
    public class CarContext : DbContext
    {
        /*private string connectionString;

        public CarContext() : base()
        {
            var builder = new ConfigurationBuilder();

            builder.AddJsonFile("appsettings.json", optional: false);

            var configuration = builder.Build();

            connectionString = configuration.GetConnectionString("MyConnection").ToString();
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;user Id=sa;password=1;database=carmanag");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cate> Cates { get; set; }

        public DbSet<Cars> Cars { get; set; }
    }

}

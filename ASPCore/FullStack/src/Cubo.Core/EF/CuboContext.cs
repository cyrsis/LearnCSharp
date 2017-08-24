using System;
using Cubo.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Cubo.Core.EF
{
    public class CuboContext : DbContext
    {
        private readonly SqlSettings _settings;
        public DbSet<Bucket> Buckets { get; set; }
        public DbSet<Item> Items { get; set; }

        public CuboContext(DbContextOptions<CuboContext> options, IOptions<SqlSettings> settings) : base(options)
        {
            _settings = settings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_settings.InMemory)
            {
                optionsBuilder.UseInMemoryDatabase();

                return;    
            }
            optionsBuilder.UseSqlServer(_settings.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var bucketBuilder = modelBuilder.Entity<Bucket>();
            bucketBuilder.HasKey(x => x.Id);
            
            var itemBuilder = modelBuilder.Entity<Item>();
            itemBuilder.HasKey(x => x.Id); 
        }
    }
}
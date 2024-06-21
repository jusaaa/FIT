using FIT.Data;
using FIT.Data.IspitIB210156;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<ProstorijeIB210156> ProstorijeIB210156 { get; set; }
        public DbSet<NastavaIB210156> NastavaIB210156 { get; set; }
        public DbSet<PredmetiIB210156>Predmeti { get; set; }
        public DbSet<PrisustvoIB210156> PrisustvoIB210156 { get; set; }

    }
}
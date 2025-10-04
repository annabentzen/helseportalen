using Microsoft.EntityFrameworkCore;
using Helseportalen.Api.Models;

namespace Helseportalen.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<HealthRecord> HealthRecords { get; set; }
    }
}

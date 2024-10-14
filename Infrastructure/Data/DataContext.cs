using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : IdentityDbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<FuelLog>()
            .HasOne<IdentityUser>()
            .WithMany()
            .HasForeignKey(f => f.UserId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }

    public DbSet<FuelLog> FuelLogs { get; set; }
}
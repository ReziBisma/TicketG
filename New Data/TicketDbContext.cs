using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using TicketGo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TicketGo.Data
{
public class TicketDbContext : IdentityDbContext<Pengguna>
{
public TicketDbContext (DbContextOptions<TicketDbContext> options) : base(options)
{ }
public DbSet<Ticket> Tickets { get; set; }
protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<IdentityRole>()
        .HasData(new [] {
                new IdentityRole("Admin"),
                new IdentityRole("Pengguna")
        });

        var hasher = new PasswordHasher<Pengguna>();
        var admin = new Pengguna
        {
                Id = Guid.NewGuid().ToString(),
                Email = "pengurus@admin.com",
                NormalizedEmail = "PENGURUS@ADMIN.COM",
                EmailConfirmed = true
        };
        admin.PasswordHash = hasher.HashPassword(admin, "Darahmerah!3");
        builder.Entity<Pengguna>()
        .HasData(admin);
        }
}
}
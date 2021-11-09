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
                    new IdentityRole 
                    {
                        Id = "2ec3739c-0f45-4357-b178-7f797858d10f",
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                        ConcurrencyStamp = "b67e4a95-7d86-4f21-a8a1-765027850a80"
                    },
                    new IdentityRole
                    {
                        Id = "153109d6-ef68-46c3-a8ef-491a85c55bfa",
                        Name = "User",
                        NormalizedName = "USER",
                        ConcurrencyStamp = "e4499df5-13db-4f01-a4b7-82ec2e32950f"
                    }
                });

            var hasher = new PasswordHasher<Pengguna>();
            var admin = new Pengguna
            {
                Id = "681d0641-bed3-452b-bdfe-cb65572a8e59",
                Name = "Ain",
                UserName = "pengurus@admin.com",
                NormalizedUserName = "PENGURUS@ADMIN.COM",
                Email = "pengurus@admin.com",
                NormalizedEmail = "PENGURUS@ADMIN.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEFc1qYDPzPcQyUCJAlgNm33VY1aOFCx9rKlWGt4kyGkJGhdIn+sJJFXHiZR4Vi+ZoQ==",
                SecurityStamp = "81a0eaf1-b7a1-41d0-8bb7-af103d441e82",
                ConcurrencyStamp = "bd0951e9-e6c7-4f08-b9e1-11dc519682f8"
            };

            builder.Entity<Pengguna>()
                .HasData(admin);
            
            builder.Entity<IdentityUserRole<string>>()
                .HasData(new IdentityUserRole<string>
                {
                    RoleId = "2ec3739c-0f45-4357-b178-7f797858d10f",
                    UserId = "681d0641-bed3-452b-bdfe-cb65572a8e59"
                });
        }
}
}
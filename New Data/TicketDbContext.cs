using Microsoft.EntityFrameworkCore;
using TicketGo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TicketGo.Data
{
public class TicketDbContext : IdentityDbContext<Pengguna>
{
public TicketDbContext (DbContextOptions<TicketDbContext> options) : base(options)
{ }
public DbSet<Ticket> Tickets { get; set; }
}
}
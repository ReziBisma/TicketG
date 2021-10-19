using Microsoft.EntityFrameworkCore;
using TicketGo.Models;

namespace TicketGo.Data
{
public class TicketDbContext : DbContext
{
public TicketDbContext (DbContextOptions<TicketDbContext> options) : base(options)
{ }
public DbSet<Ticket> Tickets { get; set; }
}
}
using Microsoft.EntityFrameworkCore;
using TravellingSite.Models;

namespace TravellingSite.Contexts;

public class TravelDBContext : DbContext
{
    public TravelDBContext(DbContextOptions opt) : base(opt) { }
    public DbSet<Destionation> Destionation { get; set; }
}

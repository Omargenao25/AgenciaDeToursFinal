using AgenciaDeToursFinal.Models;
using Microsoft.EntityFrameworkCore;

public class AgenciaDeToursDbContext : DbContext
{
    public AgenciaDeToursDbContext(DbContextOptions<AgenciaDeToursDbContext> options)
        : base(options)
    {
    }

    public DbSet<Pais> Paises { get; set; }
    public DbSet<Destino> Destinos { get; set; }
    public DbSet<Tour> Tours { get; set; }
}

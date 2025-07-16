using GrupoVimar.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

    public class AppDbContext : IdentityDbContext<ApplicationUser>
//DbContext
{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Vehiculo> Vehiculos { get; set; }
    }

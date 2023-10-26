using Microsoft.EntityFrameworkCore;

public class GatoFractalDBConext:DbContext
{
    public virtual DbSet<Usuarios>? Usuarios {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ValoresEstaticos.ConexionDB);
            
        }

    }

}
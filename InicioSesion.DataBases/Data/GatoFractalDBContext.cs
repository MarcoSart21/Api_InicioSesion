using Microsoft.EntityFrameworkCore;

public partial class GatoFractalDBContext:DbContext
{
    public virtual DbSet<Usuarios>? Usuarios {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ValoresEstaticos.ConexionDB,builer=>{

                builer.EnableRetryOnFailure(5,TimeSpan.FromSeconds(10),null);
            });  
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Usuarios>()
        .HasKey(b=>b.IdUsuarios)
        .HasName("PrimaryKey_IdUsuario");
        
        base.OnModelCreating(modelBuilder);
    }

}
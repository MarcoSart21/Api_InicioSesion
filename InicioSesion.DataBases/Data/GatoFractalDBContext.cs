using Microsoft.EntityFrameworkCore;

public partial class GatoFractalDBContext:DbContext
{
    public virtual DbSet<Usuarios> Usuarios {get;set;}

    public virtual DbSet<TipoUsuario> TipoUsuario {get; set;}

    public virtual DbSet<Rango> Rango {get; set;}

    public virtual DbSet<HistorialPartidas> HistorialPartidas {get; set;}


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
        .HasName("PrimaryKey_IdUsuarios");
        
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<TipoUsuario>()
        .HasKey(b=>b.IdTipoUsuario)
        .HasName("PrimaryKey_IdTitpoUsuario");
        
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Rango>()
        .HasKey(b=>b.IdRango)
        .HasName("PrimaryKey_IdRango");

        base.OnModelCreating(modelBuilder);

        
        modelBuilder.Entity<HistorialPartidas>()
        .HasKey(b=>b.IdHistorial)
        .HasName("PrimaryKey_IdHistorial");
        
        base.OnModelCreating(modelBuilder);

    }

}
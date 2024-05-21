using Microsoft.EntityFrameworkCore;
using practica_tutoria.Entidades;


public class MyDbContext : DbContext
{
    public  MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    public DbSet<Clinica> Clinicas { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<ExpedienteMedico> ExpedientesMedicos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>()
            .HasOne(u => u.ExpedienteMedico)
            .WithOne(em => em.Usuario)
            .HasForeignKey<ExpedienteMedico>(em => em.UsuarioId);

        modelBuilder.Entity<Clinica>()
            .HasMany(c => c.Usuarios)
            .WithOne(u => u.Clinica)
            .HasForeignKey(u => u.Clinica);

        base.OnModelCreating(modelBuilder);
    }
}

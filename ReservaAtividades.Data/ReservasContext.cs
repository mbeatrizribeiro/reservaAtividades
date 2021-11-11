using Microsoft.EntityFrameworkCore;
using ReservaAtividades.Domain.Entidades;

namespace ReservaAtividades.Data
{
    public class ReservasContext : DbContext
    {
        public ReservasContext(DbContextOptions<ReservasContext> options)
            : base(options) { }

        public DbSet<Reservas> Reservas { get; set; }

        public DbSet<Clientes> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Reservas>().ToTable("TBReservas");
            modelBuilder.Entity<Reservas>()
            .Property(p => p.DataPasseio)
            .IsRequired();
            modelBuilder.Entity<Reservas>()
            .Property(p => p.Descricao)
            .IsRequired()
            .HasMaxLength(50);
            modelBuilder.Entity<Reservas>()
            .Property(p => p.HoraPasseio)
            .IsRequired()
            .HasMaxLength(50);
            modelBuilder.Entity<Reservas>()
            .Property(p => p.ValorPasseio)
            .IsRequired();
        }
    }
}
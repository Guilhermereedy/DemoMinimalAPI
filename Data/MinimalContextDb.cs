using DemoMinimalAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMinimalAPI.Data
{
    public class MinimalContextDb : DbContext
    {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public MinimalContextDb(DbContextOptions<MinimalContextDb> options) : base(options) { }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public DbSet<Fornecedor> Fornecedores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Fornecedor>()
                .Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            modelBuilder.Entity<Fornecedor>()
                .Property(p => p.Documento)
                .IsRequired()
                .HasColumnType("varchar(14");

            modelBuilder.Entity<Fornecedor>()
                .ToTable("Fornecedores");

            base.OnModelCreating(modelBuilder);
        }
    }
}

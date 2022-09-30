using Fiap.Aula05.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Aula05.Web.Persistencia
{
    public class DimDimContext : DbContext
    {
        public DbSet<Investimento> Investimentos { get; set; }
        public DbSet<StatusInvestimento> Status { get; set; }
        public DbSet<Corretora> Corretoras { get; set; }
        public DbSet<Objetivo> Objetivos { get; set; }
        public DbSet<InvestimentoObjetivo> InvestimentosObjetivos { get; set; }

        public DimDimContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurar a chave composta da tabela associativa
            modelBuilder.Entity<InvestimentoObjetivo>()
                .HasKey(i => new { i.ObjetivoId, i.InvestimentoId });
            
            //Configurar a relação da associativa com o Investimento
            modelBuilder.Entity<InvestimentoObjetivo>()
                .HasOne(i => i.Investimento)
                .WithMany(i => i.InvestimentosObjetivos)
                .HasForeignKey(i => i.InvestimentoId);
            
            //Configurar a relação da associativa com o Objetivo
            modelBuilder.Entity<InvestimentoObjetivo>()
                .HasOne(i => i.Objetivo)
                .WithMany(i => i.InvestimentosObjetivos)
                .HasForeignKey(i => i.ObjetivoId);

            base.OnModelCreating(modelBuilder);
        }
    }
}

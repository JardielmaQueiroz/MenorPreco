using Microsoft.EntityFrameworkCore;
using MenorPreco.API.Models;

namespace MenorPreco.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
        
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<NotaFiscal> NotasFiscais { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<NotaFiscal>().HasKey(nota => new {nota.cod_NCM, nota.id_produto});
        }
    }
}
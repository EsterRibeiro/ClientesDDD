using FornecedoresDDD.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fornecedores.Infra.Dados.Config
{
    /// <summary>
    ///  Mapeia com objetos do tipo DbSet, as classess que serão manipuladas no banco. Herda de DbContext
    /// </summary>

    public class FornecedoresDbContext: DbContext
    {
        public FornecedoresDbContext()
        {
           
        }

        public FornecedoresDbContext(DbContextOptions <FornecedoresDbContext> options) : base(options)
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetConnectionString());

            base.OnConfiguring(optionsBuilder);
        }

        private string GetConnectionString()
        {
            return myaddress
        }
    }
}

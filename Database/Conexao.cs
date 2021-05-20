using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteASPNET.Models;

namespace TesteASPNET.Database
{
    public class Conexao : DbContext
    {
        public Conexao(DbContextOptions<Conexao> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasKey(p => p.CLI_ID);

            modelBuilder.Entity<Cliente>()
                .Property(p => p.CLI_NOME)
                .IsRequired();

            modelBuilder.Entity<Cliente>()
                .Property(p => p.CLI_DATANASCIMENTO)
                .IsRequired();

            modelBuilder.Entity<Cliente>()
                .Property(p => p.CLI_ATIVO)
                .IsRequired();


        }
    }
} 

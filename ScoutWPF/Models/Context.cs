using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoutWPF.Models
{
    class Context : DbContext
    {
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Posicao> Posicoes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;Database=ScoutParanaense;Trusted_Connection=true");
        }
    }
}

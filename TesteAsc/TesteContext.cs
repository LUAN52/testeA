using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteAsc.Models;

namespace TesteAsc
{
   public class TesteContext : DbContext
    {

        public TesteContext()
        {

        }

        public TesteContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Turmas> Turmas { get; set; }

        public DbSet<BoletimAluno> Boletim { get; set; }

        public DbSet<Provas>  Provas { get; set; }

        public DbSet<Competicao> Competicao { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TesteAsc3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alunos>().HasKey(k => k.IdAluno);
            modelBuilder.Entity<Alunos>().HasMany(p => p.Prova).WithOne(p=>p.Aluno);
            modelBuilder.Entity<Turmas>().HasKey(k => k.Id);
            modelBuilder.Entity<Turmas>().HasMany(m => m.alunos);
            modelBuilder.Entity<Provas>().HasKey(p => p.Id);
            modelBuilder.Entity<BoletimAluno>().HasOne(a => a.Aluno);
            modelBuilder.Entity<Competicao>().HasMany(a => a.Aluno);

        }


    }
}

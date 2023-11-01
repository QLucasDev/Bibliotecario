using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecarIO.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecarIO.DataBase
{
    public class BibliotecarioContext : DbContext
    {
        public BibliotecarioContext(DbContextOptions options) : base(options)
        {

        } 
        public DbSet<Book> Books{get; set;}
        public DbSet<Author> Authors{get; set;}
        public DbSet<Publisher> Publishers{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
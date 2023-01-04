using Microsoft.EntityFrameworkCore;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Data.Configurations;

namespace Data
{
    public class ExamenContext : DbContext
    {
        public DbSet<Jeux> Jeux { get; set; }
        public DbSet<Commentaire> Commentaire { get; set; }
        public DbSet<Article> Articles { get; set; }

        public ExamenContext()
        {
                // Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-UT09DF0;Initial Catalog=Web; MultipleActiveResultSets=true; Integrated Security=True; ");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            new ArticleConfiguration().Configure(modelbuilder.Entity<Article>());
        }



    }

   
}

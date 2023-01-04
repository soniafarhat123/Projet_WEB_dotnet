using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    internal class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasOne(a => a.Jeux).WithMany(j => j.ListArticle).HasForeignKey(a => a.JeuxFK).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

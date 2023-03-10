// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(ExamenContext))]
    [Migration("20230104191223_second migration")]
    partial class secondmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contenu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdJeux")
                        .HasColumnType("int");

                    b.Property<int?>("JeuxFK")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JeuxFK");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Domain.Commentaire", b =>
                {
                    b.Property<int>("IdCommentaire")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbreNote")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCommentaire");

                    b.HasIndex("ArticleId");

                    b.ToTable("Commentaire");
                });

            modelBuilder.Entity("Domain.Jeux", b =>
                {
                    b.Property<int>("IdJeux")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Note")
                        .HasColumnType("int");

                    b.HasKey("IdJeux");

                    b.ToTable("Jeux");
                });

            modelBuilder.Entity("Domain.Article", b =>
                {
                    b.HasOne("Domain.Jeux", "Jeux")
                        .WithMany("ListArticle")
                        .HasForeignKey("JeuxFK")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Jeux");
                });

            modelBuilder.Entity("Domain.Commentaire", b =>
                {
                    b.HasOne("Domain.Article", "Article")
                        .WithMany("ListCommentaires")
                        .HasForeignKey("ArticleId");

                    b.Navigation("Article");
                });

            modelBuilder.Entity("Domain.Article", b =>
                {
                    b.Navigation("ListCommentaires");
                });

            modelBuilder.Entity("Domain.Jeux", b =>
                {
                    b.Navigation("ListArticle");
                });
#pragma warning restore 612, 618
        }
    }
}

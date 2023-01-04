using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Jeux_JeuxFK",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Commentaire_Article_ArticleId",
                table: "Commentaire");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Article",
                table: "Article");

            migrationBuilder.RenameTable(
                name: "Article",
                newName: "Articles");

            migrationBuilder.RenameIndex(
                name: "IX_Article_JeuxFK",
                table: "Articles",
                newName: "IX_Articles_JeuxFK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articles",
                table: "Articles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Jeux_JeuxFK",
                table: "Articles",
                column: "JeuxFK",
                principalTable: "Jeux",
                principalColumn: "IdJeux",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commentaire_Articles_ArticleId",
                table: "Commentaire",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Jeux_JeuxFK",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Commentaire_Articles_ArticleId",
                table: "Commentaire");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
                table: "Articles");

            migrationBuilder.RenameTable(
                name: "Articles",
                newName: "Article");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_JeuxFK",
                table: "Article",
                newName: "IX_Article_JeuxFK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Article",
                table: "Article",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Jeux_JeuxFK",
                table: "Article",
                column: "JeuxFK",
                principalTable: "Jeux",
                principalColumn: "IdJeux",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commentaire_Article_ArticleId",
                table: "Commentaire",
                column: "ArticleId",
                principalTable: "Article",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

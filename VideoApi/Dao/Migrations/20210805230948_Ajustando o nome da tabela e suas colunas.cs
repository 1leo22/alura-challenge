using Microsoft.EntityFrameworkCore.Migrations;

namespace Dao.Migrations
{
    public partial class Ajustandoonomedatabelaesuascolunas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Videos",
                table: "Videos");

            migrationBuilder.RenameTable(
                name: "Videos",
                newName: "video");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "video",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "video",
                newName: "titulo");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "video",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "video",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_video",
                table: "video",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_video",
                table: "video");

            migrationBuilder.RenameTable(
                name: "video",
                newName: "Videos");

            migrationBuilder.RenameColumn(
                name: "url",
                table: "Videos",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "titulo",
                table: "Videos",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Videos",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Videos",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Videos",
                table: "Videos",
                column: "Id");
        }
    }
}

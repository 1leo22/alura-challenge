using Microsoft.EntityFrameworkCore.Migrations;

namespace Dao.Migrations
{
    public partial class Adicionandodadoinicialnatabelacategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categoria",
                columns: new[] { "id", "cor", "titulo" },
                values: new object[] { 1, "Verde", "Livre" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}

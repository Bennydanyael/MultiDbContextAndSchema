using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace multischema_test.domainA.MigrationsA
{
    /// <inheritdoc />
    public partial class DbContextA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "DomainA");

            migrationBuilder.CreateTable(
                name: "PersonA",
                schema: "DomainA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FName2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonA", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonA",
                schema: "DomainA");
        }
    }
}

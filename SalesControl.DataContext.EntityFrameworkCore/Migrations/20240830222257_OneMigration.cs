using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesControl.DataContext.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class OneMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    IdClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DniClient = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    NameClient = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SurnameClient = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PhoneClient = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmailClient = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "pocoAddresses",
                columns: table => new
                {
                    IdAddress = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departament = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Delete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pocoAddresses", x => x.IdAddress);
                    table.ForeignKey(
                        name: "FK_pocoAddresses_clients_IdClient",
                        column: x => x.IdClient,
                        principalTable: "clients",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pocoAddresses_IdClient",
                table: "pocoAddresses",
                column: "IdClient",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pocoAddresses");

            migrationBuilder.DropTable(
                name: "clients");
        }
    }
}

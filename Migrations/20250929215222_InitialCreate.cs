using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MockWebStoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    ProductType = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    ArmourRating = table.Column<int>(type: "INTEGER", nullable: true),
                    ArmourWeight = table.Column<int>(type: "INTEGER", nullable: true),
                    Material = table.Column<int>(type: "INTEGER", nullable: true),
                    Slot = table.Column<int>(type: "INTEGER", nullable: true),
                    Range = table.Column<int>(type: "INTEGER", nullable: true),
                    MinDamage = table.Column<int>(type: "INTEGER", nullable: true),
                    MaxDamage = table.Column<int>(type: "INTEGER", nullable: true),
                    CriticalHitChance = table.Column<double>(type: "REAL", nullable: true),
                    Type = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

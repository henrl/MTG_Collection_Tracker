using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Glee_Max.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OracleId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Uri = table.Column<string>(nullable: true),
                    ScryfallUri = table.Column<string>(nullable: true),
                    ManaCost = table.Column<string>(nullable: true),
                    Cmc = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    TypeLine = table.Column<string>(nullable: true),
                    OracleText = table.Column<string>(nullable: true),
                    Colors = table.Column<string>(nullable: true),
                    ColorIdentity = table.Column<string>(nullable: true),
                    SetName = table.Column<string>(nullable: true),
                    Power = table.Column<string>(nullable: true),
                    Toughness = table.Column<string>(nullable: true),
                    FlavorText = table.Column<string>(nullable: true),
                    CommanderLegal = table.Column<bool>(nullable: false),
                    Quantity = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}

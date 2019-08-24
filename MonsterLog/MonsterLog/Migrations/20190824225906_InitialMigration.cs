using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonsterLog.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    MonsterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: true),
                    Lore = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    LifeSpan = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Diet = table.Column<string>(nullable: true),
                    Habitat = table.Column<string>(nullable: true),
                    NaturalStrengths = table.Column<string>(nullable: true),
                    NaturalWeakness = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.MonsterID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monsters");
        }
    }
}

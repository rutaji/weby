using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace weby2019.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Slova",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    skore = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slova", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Slova",
                columns: new[] { "Id", "Name", "skore" },
                values: new object[,]
                {
                    { 1, "šiška", 6 },
                    { 27, "skočit", 6 },
                    { 28, "houkat", 6 },
                    { 29, "růst", 6 },
                    { 30, "strop", 6 },
                    { 31, "vařit", 6 },
                    { 32, "ponožka", 6 },
                    { 33, "smrdí", 6 },
                    { 34, "házet", 6 },
                    { 35, "kopat", 6 },
                    { 26, "papoušek", 6 },
                    { 36, "hotel", 6 },
                    { 38, "užovka", 6 },
                    { 39, "hora", 6 },
                    { 40, "led", 6 },
                    { 41, "len", 6 },
                    { 42, "sen", 6 },
                    { 43, "ven", 6 },
                    { 44, "zem", 6 },
                    { 45, "hodiny", 6 },
                    { 46, "slimák", 6 },
                    { 37, "pole", 6 },
                    { 25, "platina", 6 },
                    { 24, "kolo", 6 },
                    { 23, "železo", 6 },
                    { 2, "hřeben", 6 },
                    { 3, "sloupec", 6 },
                    { 4, "řádek", 6 },
                    { 5, "míč", 6 },
                    { 6, "pětka", 6 },
                    { 7, "okno", 6 },
                    { 8, "papír", 6 },
                    { 9, "stěna", 6 },
                    { 10, "kámen", 6 },
                    { 11, "nůž", 6 },
                    { 12, "houby", 6 },
                    { 13, "slovník", 6 },
                    { 14, "letadlo", 6 },
                    { 15, "světlo", 6 },
                    { 16, "housenka", 6 },
                    { 17, "koleno", 6 },
                    { 18, "slovo", 6 },
                    { 19, "požár", 6 },
                    { 20, "strom", 6 },
                    { 21, "voda", 6 },
                    { 22, "kočka", 6 },
                    { 47, "pes", 6 },
                    { 48, "hák", 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slova");
        }
    }
}

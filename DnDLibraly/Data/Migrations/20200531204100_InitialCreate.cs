using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDLibraly.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adventurers",
                columns: table => new
                {
                    AdventurerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    HealthPoints = table.Column<double>(nullable: false),
                    AttackPoints = table.Column<double>(nullable: false),
                    DefensePoints = table.Column<double>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    ManaPoints = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adventurers", x => x.AdventurerId);
                });

            migrationBuilder.CreateTable(
                name: "Fights",
                columns: table => new
                {
                    FightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Terrain = table.Column<string>(maxLength: 200, nullable: false),
                    PriceWon = table.Column<double>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fights", x => x.FightId);
                });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    MonsterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    HealthPoints = table.Column<double>(nullable: false),
                    AttackPoints = table.Column<double>(nullable: false),
                    DefensePoints = table.Column<double>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    ExPoints = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.MonsterId);
                });

            migrationBuilder.CreateTable(
                name: "AdventurerFights",
                columns: table => new
                {
                    AdventurerId = table.Column<int>(nullable: false),
                    FightId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdventurerFights", x => new { x.AdventurerId, x.FightId });
                    table.ForeignKey(
                        name: "FK_AdventurerFights_Adventurers_AdventurerId",
                        column: x => x.AdventurerId,
                        principalTable: "Adventurers",
                        principalColumn: "AdventurerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdventurerFights_Fights_FightId",
                        column: x => x.FightId,
                        principalTable: "Fights",
                        principalColumn: "FightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterFights",
                columns: table => new
                {
                    MonsterId = table.Column<int>(nullable: false),
                    FightId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterFights", x => new { x.MonsterId, x.FightId });
                    table.ForeignKey(
                        name: "FK_MonsterFights_Fights_FightId",
                        column: x => x.FightId,
                        principalTable: "Fights",
                        principalColumn: "FightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterFights_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "MonsterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adventurers",
                columns: new[] { "AdventurerId", "AttackPoints", "CreatedOn", "DefensePoints", "HealthPoints", "Level", "ManaPoints", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 20.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.1099999999999994, 50.0, 15, 0.0, "Gladitorian", null },
                    { 2, 8.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 13.369999999999999, 30.0, 10, 10.0, "Pheterion", null },
                    { 3, 3.2000000000000002, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.0, 42.0, 12, 6.9000000000000004, "Makintosh", null },
                    { 4, 16.600000000000001, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.9000000000000004, 32.200000000000003, 14, 20.0, "Gosho", null },
                    { 5, 18.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.0, 40.0, 16, 0.0, "Bark", null },
                    { 6, 12.199999999999999, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.199999999999999, 50.0, 15, 10.0, "Ultrapure", null },
                    { 7, 6.9000000000000004, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.0, 69.0, 19, 42.0, "TodiInc", null }
                });

            migrationBuilder.InsertData(
                table: "Fights",
                columns: new[] { "FightId", "CreatedOn", "PriceWon", "Terrain", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "Plain", null },
                    { 2, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 500.0, "Forest", null }
                });

            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "MonsterId", "AttackPoints", "CreatedOn", "DefensePoints", "ExPoints", "HealthPoints", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 22.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.0, 18000, 256.0, "Adult Red Dragon", null },
                    { 2, 24.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.0, 18000, 240.0, "Adult Black Dragon", null },
                    { 3, 11.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 10, 10.0, "Goblin", null },
                    { 4, 20.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, 15000, 240.0, "Dark Monarch", null },
                    { 5, 30.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, 20000, 300.0, "Blue-Eyes White Dragon", null },
                    { 6, 18.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.0, 7000, 150.0, "The Fallen", null },
                    { 7, 20.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, 15000, 240.0, "Dark Monarch", null }
                });

            migrationBuilder.InsertData(
                table: "AdventurerFights",
                columns: new[] { "AdventurerId", "FightId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "MonsterFights",
                columns: new[] { "MonsterId", "FightId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdventurerFights_FightId",
                table: "AdventurerFights",
                column: "FightId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterFights_FightId",
                table: "MonsterFights",
                column: "FightId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdventurerFights");

            migrationBuilder.DropTable(
                name: "MonsterFights");

            migrationBuilder.DropTable(
                name: "Adventurers");

            migrationBuilder.DropTable(
                name: "Fights");

            migrationBuilder.DropTable(
                name: "Monsters");
        }
    }
}

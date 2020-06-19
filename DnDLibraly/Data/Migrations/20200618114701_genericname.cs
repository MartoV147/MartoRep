using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDLibraly.Data.Migrations
{
    public partial class genericname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "FightId", "CreatedOn", "ExpPoints", "PriceWon", "Terrain", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0.0, "Plain", null },
                    { 2, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 500.0, "Forest", null }
                });

            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "MonsterId", "AttackPoints", "CreatedOn", "DefensePoints", "ExPoints", "HealthPoints", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 6, 18.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.0, 7000, 150.0, "The Fallen", null },
                    { 5, 30.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, 20000, 300.0, "Blue-Eyes White Dragon", null },
                    { 4, 20.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, 15000, 240.0, "Dark Monarch", null },
                    { 1, 22.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.0, 18000, 256.0, "Adult Red Dragon", null },
                    { 2, 24.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.0, 18000, 240.0, "Adult Black Dragon", null },
                    { 3, 11.0, new DateTime(2017, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 10, 10.0, "Goblin", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FName", "LName", "Password", "Username" },
                values: new object[,]
                {
                    { 3, 64, "ohhimark@abv.bg", "Tommy", "Wiseau", "apartlisa", "yourtearingme" },
                    { 1, 21, "martomail@abv.bg", "Martin", "Vasilev", "martopass", "martov" },
                    { 2, 25, "macintosh@abv.bg", "Richard", "Hristov", "arentgay", "traps" },
                    { 4, 17, "dva", "Hana", "Song", "dva", "dva" }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdventurerFights",
                keyColumns: new[] { "AdventurerId", "FightId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AdventurerFights",
                keyColumns: new[] { "AdventurerId", "FightId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Adventurers",
                keyColumn: "AdventurerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Adventurers",
                keyColumn: "AdventurerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Adventurers",
                keyColumn: "AdventurerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Adventurers",
                keyColumn: "AdventurerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Adventurers",
                keyColumn: "AdventurerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "FightId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MonsterFights",
                keyColumns: new[] { "MonsterId", "FightId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MonsterFights",
                keyColumns: new[] { "MonsterId", "FightId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Adventurers",
                keyColumn: "AdventurerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Adventurers",
                keyColumn: "AdventurerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fights",
                keyColumn: "FightId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 3);
        }
    }
}

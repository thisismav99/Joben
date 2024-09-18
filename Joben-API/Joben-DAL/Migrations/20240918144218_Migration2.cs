using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Joben_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CivilStatus",
                columns: new[] { "ID", "CivilStatus", "CreatedBy", "CreatedOn", "IsActive", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "SINGLE", "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1301), true, null, null },
                    { 2, "MARRIED", "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1305), true, null, null },
                    { 3, "ANNULLED", "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1307), true, null, null },
                    { 4, "DIVORCED", "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1308), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "ID", "CreatedBy", "CreatedOn", "Gender", "IsActive", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1468), "MALE", true, null, null },
                    { 2, "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1469), "FEMALE", true, null, null },
                    { 3, "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1471), "GAY", true, null, null },
                    { 4, "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1472), "LESBIAN", true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "ID", "CreatedBy", "CreatedOn", "IsActive", "Position", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1494), true, "RIDER", null, null },
                    { 2, "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1495), true, "DRIVER", null, null },
                    { 3, "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1497), true, "HOUSEKEEPER", null, null },
                    { 4, "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1498), true, "COOK", null, null },
                    { 5, "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1500), true, "GARDENER", null, null },
                    { 6, "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1501), true, "BABY SITTER", null, null },
                    { 7, "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1503), true, "DELIVERY MAN", null, null },
                    { 8, "SEEDER", new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1504), true, "LAUNDRY", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 8);
        }
    }
}

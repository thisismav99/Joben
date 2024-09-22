using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joben_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2882));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 18, 14, 42, 18, 288, DateTimeKind.Utc).AddTicks(1504));
        }
    }
}

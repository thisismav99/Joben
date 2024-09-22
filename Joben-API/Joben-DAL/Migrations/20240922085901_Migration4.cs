using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joben_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "CivilStatus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Position",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 9, 22, 8, 59, 0, 906, DateTimeKind.Utc).AddTicks(6056));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

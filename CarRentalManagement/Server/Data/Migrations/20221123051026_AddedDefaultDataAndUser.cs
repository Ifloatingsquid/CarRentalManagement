using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "50c28931-e685-410f-a652-bb8396d969cc", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "530297dd-f3ad-48d1-b1e0-3a0734250982", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "56682a0e-8ce3-4abb-96b0-93d59450f79d", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEBHaKJwqvepFuAe3J54hGyoZp8PJdXrLwSrQOnwkInd/8Xy9Lg85zAcWR1URTQ8IIQ==", null, false, "6755e3e0-4b37-4c4e-9e87-d422a9b1f134", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 23, 13, 10, 25, 838, DateTimeKind.Local).AddTicks(8373), new DateTime(2022, 11, 23, 13, 10, 25, 840, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 23, 13, 10, 25, 840, DateTimeKind.Local).AddTicks(7024), new DateTime(2022, 11, 23, 13, 10, 25, 840, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 23, 13, 10, 25, 842, DateTimeKind.Local).AddTicks(6256), new DateTime(2022, 11, 23, 13, 10, 25, 842, DateTimeKind.Local).AddTicks(6287), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 23, 13, 10, 25, 842, DateTimeKind.Local).AddTicks(6291), new DateTime(2022, 11, 23, 13, 10, 25, 842, DateTimeKind.Local).AddTicks(6293), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 23, 13, 10, 25, 843, DateTimeKind.Local).AddTicks(1996), new DateTime(2022, 11, 23, 13, 10, 25, 843, DateTimeKind.Local).AddTicks(2012), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 23, 13, 10, 25, 843, DateTimeKind.Local).AddTicks(2016), new DateTime(2022, 11, 23, 13, 10, 25, 843, DateTimeKind.Local).AddTicks(2017), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 23, 13, 10, 25, 843, DateTimeKind.Local).AddTicks(2019), new DateTime(2022, 11, 23, 13, 10, 25, 843, DateTimeKind.Local).AddTicks(2020), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 23, 13, 10, 25, 843, DateTimeKind.Local).AddTicks(2022), new DateTime(2022, 11, 23, 13, 10, 25, 843, DateTimeKind.Local).AddTicks(2023), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 47, 53, 557, DateTimeKind.Local).AddTicks(7111), new DateTime(2022, 11, 23, 12, 47, 53, 561, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 47, 53, 561, DateTimeKind.Local).AddTicks(6501), new DateTime(2022, 11, 23, 12, 47, 53, 561, DateTimeKind.Local).AddTicks(6523) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8442f4c8-bbea-4c69-a7f5-5e418e37ffd1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1", "6abf83f9-68ad-4cf4-a17d-e6bb3f61a4ff" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6abf83f9-68ad-4cf4-a17d-e6bb3f61a4ff");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7453f4c8-bbca-4c69-a7a5-6e418e37fcd1", "9f2b660e-89f5-4457-b799-87694cccbd69", "User", "USER" },
                    { "8432f4e8-ccba-4b69-a8f5-5e618e38cfa1", "9aee0678-5195-40f4-9a88-9ff41b42b42e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4708398e-57e3-4517-b9de-e50c5814508a", 0, "0fa7448c-4640-40f9-a331-f30f99336d94", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "System", "Admin", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEB0MfZkOqjy8cNM67z5bZRfU6fccNH8GEy/EILaHvMNWNocmOIqqBTh/nPF/Js6BqQ==", null, false, "2ce993ae-a8fa-44e5-b5bf-fdd3f30727be", null, false, null },
                    { "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1", 0, "93062ce0-1737-4b41-a3da-6cef90a4a777", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@yahoo.com", false, "System", "User", false, null, "USER@YAHOO.COM", null, "AQAAAAEAACcQAAAAEAkW/0djXXW8kiZOQDUduatftHmy5MZKeesnav2JbmNMkeBH+Em65mlS1E05UvL8sA==", null, false, "7478d96d-0772-4ac7-87e8-5551b3d76ed2", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8432f4e8-ccba-4b69-a8f5-5e618e38cfa1", "4708398e-57e3-4517-b9de-e50c5814508a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7453f4c8-bbca-4c69-a7a5-6e418e37fcd1", "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8432f4e8-ccba-4b69-a8f5-5e618e38cfa1", "4708398e-57e3-4517-b9de-e50c5814508a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7453f4c8-bbca-4c69-a7a5-6e418e37fcd1", "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7453f4c8-bbca-4c69-a7a5-6e418e37fcd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8432f4e8-ccba-4b69-a8f5-5e618e38cfa1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4708398e-57e3-4517-b9de-e50c5814508a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8442f4c8-bbea-4c69-a7f5-5e418e37ffd1", "3d66c3eb-461e-4b59-882a-5a7485a1628e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1", "801612d2-a2a5-4049-8130-3a071885e5b2", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6abf83f9-68ad-4cf4-a17d-e6bb3f61a4ff", 0, "0314d893-7d0b-4760-a255-521e0a3d459a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "System", "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEBUBRPuWN7OXJyth/1c9YzdbI2GMcSf4voT3ayNfJkGTfzriLTdFa4DeYbMsFpuZdg==", null, false, "0d03ed71-dea8-44e6-be57-04c5c5c52ec1", null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1", "6abf83f9-68ad-4cf4-a17d-e6bb3f61a4ff" });
        }
    }
}

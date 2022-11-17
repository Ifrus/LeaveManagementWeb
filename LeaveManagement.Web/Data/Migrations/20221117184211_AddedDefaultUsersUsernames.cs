using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7453f4c8-bbca-4c69-a7a5-6e418e37fcd1",
                column: "ConcurrencyStamp",
                value: "5ace5f1f-dc56-4614-9c34-80ca2b3b744f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8432f4e8-ccba-4b69-a8f5-5e618e38cfa1",
                column: "ConcurrencyStamp",
                value: "d6c973ff-f3c0-4f58-b082-af5d4eefe955");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4708398e-57e3-4517-b9de-e50c5814508a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e85917e3-e362-4fda-9ce4-613880f1f429", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEPielUR56zkgbLfgiE9SNxUkkYU64WB7lzYyfixZVlakgMpNelTf3NbXfRwRXfVd8Q==", "89461a3a-0b9a-4162-ad68-3bcf12c7b48e", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d00392dd-27c1-407f-a539-eabe84b08afa", true, "USER@YAHOO.COM", "AQAAAAEAACcQAAAAEIM5VDJV7YvX55t2IRC9XkFotxetSkdNt1HwTXt507nlyXDlp4KFLB19Chl5+SphWA==", "ba65d22a-ef8a-4416-aa59-9cae9eeeb0f7", "user@yahoo.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7453f4c8-bbca-4c69-a7a5-6e418e37fcd1",
                column: "ConcurrencyStamp",
                value: "9f2b660e-89f5-4457-b799-87694cccbd69");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8432f4e8-ccba-4b69-a8f5-5e618e38cfa1",
                column: "ConcurrencyStamp",
                value: "9aee0678-5195-40f4-9a88-9ff41b42b42e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4708398e-57e3-4517-b9de-e50c5814508a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0fa7448c-4640-40f9-a331-f30f99336d94", false, null, "AQAAAAEAACcQAAAAEB0MfZkOqjy8cNM67z5bZRfU6fccNH8GEy/EILaHvMNWNocmOIqqBTh/nPF/Js6BqQ==", "2ce993ae-a8fa-44e5-b5bf-fdd3f30727be", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "93062ce0-1737-4b41-a3da-6cef90a4a777", false, null, "AQAAAAEAACcQAAAAEAkW/0djXXW8kiZOQDUduatftHmy5MZKeesnav2JbmNMkeBH+Em65mlS1E05UvL8sA==", "7478d96d-0772-4ac7-87e8-5551b3d76ed2", null });
        }
    }
}

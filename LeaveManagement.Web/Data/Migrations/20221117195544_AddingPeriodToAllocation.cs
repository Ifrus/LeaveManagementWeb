using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7453f4c8-bbca-4c69-a7a5-6e418e37fcd1",
                column: "ConcurrencyStamp",
                value: "78d8b986-2279-4d7b-993e-bc18ae583046");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8432f4e8-ccba-4b69-a8f5-5e618e38cfa1",
                column: "ConcurrencyStamp",
                value: "52ea587e-604c-4344-91e1-34dac8d4b7d6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4708398e-57e3-4517-b9de-e50c5814508a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5866c23e-3d2f-4896-b947-1d651f787cdc", "AQAAAAEAACcQAAAAEBrboCoBRMRz0Q+NDkJQYrUlzpDZqJW9sydGx5Ndzb/jn7G6dE9pgwApR52eUJzhDw==", "d44673db-8f81-4a04-83ee-8576f53d7549" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fede451d-b6f2-4eef-968d-e2888c91dc12", "AQAAAAEAACcQAAAAEGujhCsB5V4JD9h7GktpiRgJ9+bqOqrGb4iSmrAzgAEcMLu8mt13bP24N/NaAWJeCA==", "b0c3e263-e22e-4f34-8807-7ab53d2dddcb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e85917e3-e362-4fda-9ce4-613880f1f429", "AQAAAAEAACcQAAAAEPielUR56zkgbLfgiE9SNxUkkYU64WB7lzYyfixZVlakgMpNelTf3NbXfRwRXfVd8Q==", "89461a3a-0b9a-4162-ad68-3bcf12c7b48e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d00392dd-27c1-407f-a539-eabe84b08afa", "AQAAAAEAACcQAAAAEIM5VDJV7YvX55t2IRC9XkFotxetSkdNt1HwTXt507nlyXDlp4KFLB19Chl5+SphWA==", "ba65d22a-ef8a-4416-aa59-9cae9eeeb0f7" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7453f4c8-bbca-4c69-a7a5-6e418e37fcd1",
                column: "ConcurrencyStamp",
                value: "2d94e748-24d7-4447-b038-f9a35372e6aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8432f4e8-ccba-4b69-a8f5-5e618e38cfa1",
                column: "ConcurrencyStamp",
                value: "5470f645-f7e9-454a-87b6-74b48d10b106");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4708398e-57e3-4517-b9de-e50c5814508a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16dc611e-eb9c-4a49-b648-69b6b711c429", "AQAAAAEAACcQAAAAEJJVy1u6DS3KURCXp0X+fjmQuW2R+E/rSK9/9cOdf553vDu/dLDliFNkyJsqbFWMNA==", "155558c8-e0de-48c9-a49f-5179aae144c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a12955b6-62dc-4e08-8180-b1241be6743b", "AQAAAAEAACcQAAAAEHYUfnuDiccKMxU0HmtjbdJTbpmIVJ0UIWkqlcLj3W6wF23aO3Jwd3945CJPdpCzSg==", "d56914df-273f-44c1-859c-19a0650f5129" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7453f4c8-bbca-4c69-a7a5-6e418e37fcd1",
                column: "ConcurrencyStamp",
                value: "590f887c-8847-42d6-89b1-a16df72451e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8432f4e8-ccba-4b69-a8f5-5e618e38cfa1",
                column: "ConcurrencyStamp",
                value: "b90326ba-1957-43c1-a8ab-5059bba57ec3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4708398e-57e3-4517-b9de-e50c5814508a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "043e2739-b26f-4871-b259-cfe7e6c0a4ce", "AQAAAAEAACcQAAAAEMlc8bfCq4cciFMtJdK+rkA7Am0yl18cPq4YivSFl3Oxgm5gzhD3hhxuIY9pMM5nGw==", "508facb6-d91d-4abc-af9b-289d581ace90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3241252d-af12-4dcc-840e-f051e0589ef9", "AQAAAAEAACcQAAAAEIqadhf7J/uI+TCyfaLRO/wtXkI+aGWUcaJl6DRTJo1uB1uVkfxWHogfLLW7+H6zSg==", "d6cada40-0dfe-42c1-b06c-1aa105d89c31" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}

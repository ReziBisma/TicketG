using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketGo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Jumlah",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ec3739c-0f45-4357-b178-7f797858d10f", "b67e4a95-7d86-4f21-a8a1-765027850a80", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "153109d6-ef68-46c3-a8ef-491a85c55bfa", "e4499df5-13db-4f01-a4b7-82ec2e32950f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "681d0641-bed3-452b-bdfe-cb65572a8e59", 0, null, "bd0951e9-e6c7-4f08-b9e1-11dc519682f8", "pengurus@admin.com", true, false, null, "Ain", "PENGURUS@ADMIN.COM", "PENGURUS@ADMIN.COM", "AQAAAAEAACcQAAAAEFc1qYDPzPcQyUCJAlgNm33VY1aOFCx9rKlWGt4kyGkJGhdIn+sJJFXHiZR4Vi+ZoQ==", null, false, "81a0eaf1-b7a1-41d0-8bb7-af103d441e82", false, "pengurus@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2ec3739c-0f45-4357-b178-7f797858d10f", "681d0641-bed3-452b-bdfe-cb65572a8e59" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "153109d6-ef68-46c3-a8ef-491a85c55bfa");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ec3739c-0f45-4357-b178-7f797858d10f", "681d0641-bed3-452b-bdfe-cb65572a8e59" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ec3739c-0f45-4357-b178-7f797858d10f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "681d0641-bed3-452b-bdfe-cb65572a8e59");

            migrationBuilder.DropColumn(
                name: "Jumlah",
                table: "Tickets");
        }
    }
}

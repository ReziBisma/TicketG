using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketGo.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a28f244-04f7-40fd-b39f-c9783bd34fd0", "46a1481b-7090-4e1e-9333-3d2f3183a034", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ed99fba-50dc-44c8-9f5c-c3a07fef4a4a", "54fad4fd-d906-4e06-8465-a839c350965f", "Pengguna", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d9586523-a097-4a32-bd80-af3509072ef1", 0, null, "568a9dab-e30d-4322-a1b4-60652540075b", "pengurus@admin.com", true, false, null, null, "PENGURUS@ADMIN.COM", null, "AQAAAAEAACcQAAAAELlHTtpjF4jOR5xCl12V2M4RaYBMIqlRChdshjw7B7lc9uk6FcJBL+e/FORIWkwW6g==", null, false, "fc7b09dd-3104-4d93-8a55-e0ff9ceba5ee", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a28f244-04f7-40fd-b39f-c9783bd34fd0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ed99fba-50dc-44c8-9f5c-c3a07fef4a4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9586523-a097-4a32-bd80-af3509072ef1");

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
    }
}

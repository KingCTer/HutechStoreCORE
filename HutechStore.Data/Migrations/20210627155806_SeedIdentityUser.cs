using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HutechStore.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 27, 22, 58, 5, 495, DateTimeKind.Local).AddTicks(33),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 27, 22, 43, 13, 708, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("b5b7bcf5-52f7-4e91-96c3-6f020bd84bc3"), "b4534b77-7b3b-4de4-9f06-9983a6412c21", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b5b7bcf5-52f7-4e91-96c3-6f020bd84bc3"), new Guid("6a924915-e5b4-4dd5-9d37-81d6ddfa5070") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("6a924915-e5b4-4dd5-9d37-81d6ddfa5070"), 0, "a22d7970-bdec-4e49-8c39-0267981cfff0", new DateTime(2000, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "kingcter@ptd.edu.vn", true, "Dung", "Nguyen", false, null, "kingcter@ptd.edu.vn", "admin", "AQAAAAEAACcQAAAAEOoHH1khkCS4rm6K2lp1rT0SXnrZ73IjpNdbJ6JLP+U5XZl95I0mm483AdEwkL1atA==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 22, 58, 5, 504, DateTimeKind.Local).AddTicks(5846));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("b5b7bcf5-52f7-4e91-96c3-6f020bd84bc3"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b5b7bcf5-52f7-4e91-96c3-6f020bd84bc3"), new Guid("6a924915-e5b4-4dd5-9d37-81d6ddfa5070") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6a924915-e5b4-4dd5-9d37-81d6ddfa5070"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 27, 22, 43, 13, 708, DateTimeKind.Local).AddTicks(8740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 27, 22, 58, 5, 495, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 22, 43, 13, 719, DateTimeKind.Local).AddTicks(6231));
        }
    }
}

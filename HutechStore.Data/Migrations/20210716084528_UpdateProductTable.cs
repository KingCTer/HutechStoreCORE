using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HutechStore.Data.Migrations
{
    public partial class UpdateProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("b5b7bcf5-52f7-4e91-96c3-6f020bd84bc3"),
                column: "ConcurrencyStamp",
                value: "b5010cb6-724e-4a4b-9e83-1f84ef6f6bce");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6a924915-e5b4-4dd5-9d37-81d6ddfa5070"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6afdc12-f16d-456c-af5e-3ca65b589cee", "AQAAAAEAACcQAAAAEFtpC+BCjRi6vk1C7fzn8YEkiM/jC/aHwp5L+VRiCL2XLI1Xy3ieZcbHxoSkFOlP9A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 16, 15, 45, 27, 649, DateTimeKind.Local).AddTicks(7868));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("b5b7bcf5-52f7-4e91-96c3-6f020bd84bc3"),
                column: "ConcurrencyStamp",
                value: "75fe2a76-7bdf-4965-9654-43aafb386f03");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6a924915-e5b4-4dd5-9d37-81d6ddfa5070"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44734995-3b32-492a-89a4-7e5dcc70d0ef", "AQAAAAEAACcQAAAAELJsCYfIqu81Lr3A3KXhwrQksqPVVEok0EYc6ahuL0R6mqMA5Q2u07lowLonoTY64Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 28, 1, 18, 43, 305, DateTimeKind.Local).AddTicks(3656));
        }
    }
}

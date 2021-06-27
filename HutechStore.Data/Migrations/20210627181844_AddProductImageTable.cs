using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HutechStore.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 27, 22, 58, 5, 495, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 27, 22, 58, 5, 495, DateTimeKind.Local).AddTicks(33),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("b5b7bcf5-52f7-4e91-96c3-6f020bd84bc3"),
                column: "ConcurrencyStamp",
                value: "b4534b77-7b3b-4de4-9f06-9983a6412c21");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6a924915-e5b4-4dd5-9d37-81d6ddfa5070"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a22d7970-bdec-4e49-8c39-0267981cfff0", "AQAAAAEAACcQAAAAEOoHH1khkCS4rm6K2lp1rT0SXnrZ73IjpNdbJ6JLP+U5XZl95I0mm483AdEwkL1atA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 22, 58, 5, 504, DateTimeKind.Local).AddTicks(5846));
        }
    }
}

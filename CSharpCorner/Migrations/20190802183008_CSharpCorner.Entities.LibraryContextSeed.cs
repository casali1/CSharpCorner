using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharpCorner.Migrations
{
    public partial class CSharpCornerEntitiesLibraryContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "Genre", "LastName" },
                values: new object[] { new Guid("b191f29f-e446-4178-b5ba-b4f3ab0b45a7"), "Bob", "Drama", "Ross" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "Genre", "LastName" },
                values: new object[] { new Guid("6e99d1d8-282c-4a65-b6de-df3470b0eb85"), "David", "Fantasy", "Miller" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("6e99d1d8-282c-4a65-b6de-df3470b0eb85"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("b191f29f-e446-4178-b5ba-b4f3ab0b45a7"));
        }
    }
}

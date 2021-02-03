using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApplication.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movie");
            migrationBuilder.InsertData(
                    "Movie",
                    "Title,Genre",
                    "Hello world,Action"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

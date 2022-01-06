using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PCO.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordReminder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "FullName", "Password", "PasswordReminder", "UpdateDate" },
                values: new object[] { 1, new DateTime(1999, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Matheus Lopes de Jesus", "12345678", "do um ao oito", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "FullName", "Password", "PasswordReminder", "UpdateDate" },
                values: new object[] { 2, new DateTime(2001, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rayane Lopes de Jesus", "87654312", "do oito ao um", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

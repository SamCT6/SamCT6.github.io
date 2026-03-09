using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesBaseball.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Opponent = table.Column<string>(type: "TEXT", nullable: true),
                    GameDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Result = table.Column<string>(type: "TEXT", nullable: true),
                    HomeScore = table.Column<string>(type: "TEXT", nullable: true),
                    OpponentScore = table.Column<string>(type: "TEXT", nullable: true),
                    TicketPrice = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}

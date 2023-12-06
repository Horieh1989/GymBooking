using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymBooking.Data.Migrations
{
    /// <inheritdoc />
    public partial class addgymclassesandconnectionbetweenuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GymClassId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Gymclasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gymclasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserGymsJoin",
                columns: table => new
                {
                    GymClassId = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserGymsJoin", x => new { x.GymClassId, x.ApplicationUserId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserGymsJoin_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserGymsJoin_Gymclasses_GymClassId",
                        column: x => x.GymClassId,
                        principalTable: "Gymclasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GymClassId",
                table: "AspNetUsers",
                column: "GymClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserGymsJoin_ApplicationUserId",
                table: "ApplicationUserGymsJoin",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Gymclasses_GymClassId",
                table: "AspNetUsers",
                column: "GymClassId",
                principalTable: "Gymclasses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Gymclasses_GymClassId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ApplicationUserGymsJoin");

            migrationBuilder.DropTable(
                name: "Gymclasses");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_GymClassId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GymClassId",
                table: "AspNetUsers");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym_Data.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "antrenorAdvisors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AntrenorID = table.Column<int>(type: "int", nullable: false),
                    AdvisorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_antrenorAdvisors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "messages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderID = table.Column<int>(type: "int", nullable: true),
                    ReceiverID = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendingDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "targets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_targets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "exercisesLists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Work1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Work2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Work3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Work4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Work5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProgramFinishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CaloriBurnedTarget = table.Column<double>(type: "float", nullable: true),
                    TargetID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercisesLists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_exercisesLists_targets_TargetID",
                        column: x => x.TargetID,
                        principalTable: "targets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nutritionsLists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MorningMeal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lunch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EveningMeal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProgramFinishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Calori = table.Column<double>(type: "float", nullable: true),
                    TargetID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nutritionsLists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_nutritionsLists_targets_TargetID",
                        column: x => x.TargetID,
                        principalTable: "targets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_exercisesLists_TargetID",
                table: "exercisesLists",
                column: "TargetID");

            migrationBuilder.CreateIndex(
                name: "IX_nutritionsLists_TargetID",
                table: "nutritionsLists",
                column: "TargetID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "antrenorAdvisors");

            migrationBuilder.DropTable(
                name: "exercisesLists");

            migrationBuilder.DropTable(
                name: "messages");

            migrationBuilder.DropTable(
                name: "nutritionsLists");

            migrationBuilder.DropTable(
                name: "targets");
        }
    }
}

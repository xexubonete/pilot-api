using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pilot.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LANGUAGE",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    varchar50 = table.Column<string>(name: "varchar(50)", type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LANGUAGE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PLAYER",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Position = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    YellowCard = table.Column<decimal>(type: "decimal(2,0)", nullable: false),
                    RedCard = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLAYER", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "REFEREE",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    varchar50 = table.Column<string>(name: "varchar(50)", type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REFEREE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TEAM",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    varchar50 = table.Column<string>(name: "varchar(50)", type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEAM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LanguageReferee",
                columns: table => new
                {
                    LanguagesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefereesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageReferee", x => new { x.LanguagesId, x.RefereesId });
                    table.ForeignKey(
                        name: "FK_LanguageReferee_LANGUAGE_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "LANGUAGE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageReferee_REFEREE_RefereesId",
                        column: x => x.RefereesId,
                        principalTable: "REFEREE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COMPETITION",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    varchar50 = table.Column<string>(name: "varchar(50)", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETITION", x => x.Id);
                    table.ForeignKey(
                        name: "FK_COMPETITION_TEAM_TeamId",
                        column: x => x.TeamId,
                        principalTable: "TEAM",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MATCH",
                columns: table => new
                {
                    RefereeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompetitionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocalTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MATCH", x => x.RefereeId);
                    table.ForeignKey(
                        name: "FK_MATCH_COMPETITION_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "COMPETITION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MATCH_TEAM_LocalTeamId",
                        column: x => x.LocalTeamId,
                        principalTable: "TEAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MATCH_TEAM_VisitorTeamId",
                        column: x => x.VisitorTeamId,
                        principalTable: "TEAM",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_COMPETITION_TeamId",
                table: "COMPETITION",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageReferee_RefereesId",
                table: "LanguageReferee",
                column: "RefereesId");

            migrationBuilder.CreateIndex(
                name: "IX_MATCH_CompetitionId",
                table: "MATCH",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_MATCH_LocalTeamId",
                table: "MATCH",
                column: "LocalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MATCH_VisitorTeamId",
                table: "MATCH",
                column: "VisitorTeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguageReferee");

            migrationBuilder.DropTable(
                name: "MATCH");

            migrationBuilder.DropTable(
                name: "PLAYER");

            migrationBuilder.DropTable(
                name: "LANGUAGE");

            migrationBuilder.DropTable(
                name: "REFEREE");

            migrationBuilder.DropTable(
                name: "COMPETITION");

            migrationBuilder.DropTable(
                name: "TEAM");
        }
    }
}

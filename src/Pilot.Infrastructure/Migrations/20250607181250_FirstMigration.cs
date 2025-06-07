using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pilot.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "Language",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Diaclect = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Position = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    YellowCard = table.Column<int>(type: "integer", nullable: false),
                    RedCard = table.Column<int>(type: "integer", nullable: false),
                    TeamId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Referee",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LanguageReferee",
                schema: "public",
                columns: table => new
                {
                    LanguagesId = table.Column<int>(type: "integer", nullable: false),
                    RefereesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageReferee", x => new { x.LanguagesId, x.RefereesId });
                    table.ForeignKey(
                        name: "FK_LanguageReferee_Language_LanguagesId",
                        column: x => x.LanguagesId,
                        principalSchema: "public",
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageReferee_Referee_RefereesId",
                        column: x => x.RefereesId,
                        principalSchema: "public",
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Competition",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TeamId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competition_Team_TeamId",
                        column: x => x.TeamId,
                        principalSchema: "public",
                        principalTable: "Team",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Match",
                schema: "public",
                columns: table => new
                {
                    RefereeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CompetitionId = table.Column<int>(type: "integer", nullable: false),
                    LocalTeamId = table.Column<Guid>(type: "uuid", nullable: false),
                    VisitorTeamId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.RefereeId);
                    table.ForeignKey(
                        name: "FK_Match_Competition_CompetitionId",
                        column: x => x.CompetitionId,
                        principalSchema: "public",
                        principalTable: "Competition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Match_Team_LocalTeamId",
                        column: x => x.LocalTeamId,
                        principalSchema: "public",
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Match_Team_VisitorTeamId",
                        column: x => x.VisitorTeamId,
                        principalSchema: "public",
                        principalTable: "Team",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competition_TeamId",
                schema: "public",
                table: "Competition",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageReferee_RefereesId",
                schema: "public",
                table: "LanguageReferee",
                column: "RefereesId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_CompetitionId",
                schema: "public",
                table: "Match",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_LocalTeamId",
                schema: "public",
                table: "Match",
                column: "LocalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_VisitorTeamId",
                schema: "public",
                table: "Match",
                column: "VisitorTeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguageReferee",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Match",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Player",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Language",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Referee",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Competition",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Team",
                schema: "public");
        }
    }
}

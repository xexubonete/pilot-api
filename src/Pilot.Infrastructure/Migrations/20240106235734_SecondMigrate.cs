using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pilot.Infrastructure.Migrations
{
    public partial class SecondMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MATCH_TEAM_LocalTeamId",
                table: "MATCH");

            migrationBuilder.DropForeignKey(
                name: "FK_MATCH_TEAM_VisitorTeamId",
                table: "MATCH");

            migrationBuilder.AlterColumn<Guid>(
                name: "VisitorTeamId",
                table: "MATCH",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "LocalTeamId",
                table: "MATCH",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MATCH_TEAM_LocalTeamId",
                table: "MATCH",
                column: "LocalTeamId",
                principalTable: "TEAM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MATCH_TEAM_VisitorTeamId",
                table: "MATCH",
                column: "VisitorTeamId",
                principalTable: "TEAM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MATCH_TEAM_LocalTeamId",
                table: "MATCH");

            migrationBuilder.DropForeignKey(
                name: "FK_MATCH_TEAM_VisitorTeamId",
                table: "MATCH");

            migrationBuilder.AlterColumn<Guid>(
                name: "VisitorTeamId",
                table: "MATCH",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "LocalTeamId",
                table: "MATCH",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_MATCH_TEAM_LocalTeamId",
                table: "MATCH",
                column: "LocalTeamId",
                principalTable: "TEAM",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MATCH_TEAM_VisitorTeamId",
                table: "MATCH",
                column: "VisitorTeamId",
                principalTable: "TEAM",
                principalColumn: "Id");
        }
    }
}

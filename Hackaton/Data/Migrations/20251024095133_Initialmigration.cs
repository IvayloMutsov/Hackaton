﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackaton.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProcedureType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfessorId1 = table.Column<int>(type: "int", nullable: true),
                    ProfessorId2 = table.Column<int>(type: "int", nullable: true),
                    ProfessorId3 = table.Column<int>(type: "int", nullable: true),
                    ProfessorId4 = table.Column<int>(type: "int", nullable: true),
                    ProfessorId5 = table.Column<int>(type: "int", nullable: true),
                    ProfessorId6 = table.Column<int>(type: "int", nullable: true),
                    ProfessorId7 = table.Column<int>(type: "int", nullable: true),
                    ReserveInternalId = table.Column<int>(type: "int", nullable: true),
                    ReserveExternalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proffessors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AcademicRank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScientificFiled = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    PrevParticipationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastParticipationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ParticipationCounter = table.Column<int>(type: "int", nullable: false),
                    UniIsLocal = table.Column<bool>(type: "bit", nullable: false),
                    IsReserve = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proffessors", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropTable(
                name: "Proffessors");
        }
    }
}

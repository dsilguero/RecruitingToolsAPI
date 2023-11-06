using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitingToolsAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LinkedInUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recruiters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruiters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SelectionProcessStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectionProcessStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SelectionProcess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectionProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectionProcess_SelectionProcessStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "SelectionProcessStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidateSelectionProcess",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    SelectionProcessId = table.Column<int>(type: "int", nullable: false),
                    CandidateStatusId = table.Column<int>(type: "int", nullable: false),
                    CandidateIntroductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateSelectionProcess", x => new { x.CandidateId, x.SelectionProcessId });
                    table.ForeignKey(
                        name: "FK_CandidateSelectionProcess_CandidateStatuses_CandidateStatusId",
                        column: x => x.CandidateStatusId,
                        principalTable: "CandidateStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateSelectionProcess_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateSelectionProcess_SelectionProcess_SelectionProcessId",
                        column: x => x.SelectionProcessId,
                        principalTable: "SelectionProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecruiterSelectionProcess",
                columns: table => new
                {
                    RecruiterId = table.Column<int>(type: "int", nullable: false),
                    SelectionProcessId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruiterSelectionProcess", x => new { x.RecruiterId, x.SelectionProcessId });
                    table.ForeignKey(
                        name: "FK_RecruiterSelectionProcess_Recruiters_RecruiterId",
                        column: x => x.RecruiterId,
                        principalTable: "Recruiters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecruiterSelectionProcess_SelectionProcess_SelectionProcessId",
                        column: x => x.SelectionProcessId,
                        principalTable: "SelectionProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    SelectionProcessId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CandidateSelectionProcessCandidateId = table.Column<int>(type: "int", nullable: true),
                    CandidateSelectionProcessSelectionProcessId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_Documents_CandidateSelectionProcess_CandidateSelectionProcessCandidateId_CandidateSelectionProcessSelectionProcessId",
                        columns: x => new { x.CandidateSelectionProcessCandidateId, x.CandidateSelectionProcessSelectionProcessId },
                        principalTable: "CandidateSelectionProcess",
                        principalColumns: new[] { "CandidateId", "SelectionProcessId" });
                    table.ForeignKey(
                        name: "FK_Documents_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_SelectionProcess_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "SelectionProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateSelectionProcess_CandidateStatusId",
                table: "CandidateSelectionProcess",
                column: "CandidateStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateSelectionProcess_SelectionProcessId",
                table: "CandidateSelectionProcess",
                column: "SelectionProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_CandidateId",
                table: "Documents",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_CandidateSelectionProcessCandidateId_CandidateSelectionProcessSelectionProcessId",
                table: "Documents",
                columns: new[] { "CandidateSelectionProcessCandidateId", "CandidateSelectionProcessSelectionProcessId" });

            migrationBuilder.CreateIndex(
                name: "IX_RecruiterSelectionProcess_SelectionProcessId",
                table: "RecruiterSelectionProcess",
                column: "SelectionProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectionProcess_StatusId",
                table: "SelectionProcess",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "RecruiterSelectionProcess");

            migrationBuilder.DropTable(
                name: "CandidateSelectionProcess");

            migrationBuilder.DropTable(
                name: "Recruiters");

            migrationBuilder.DropTable(
                name: "CandidateStatuses");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "SelectionProcess");

            migrationBuilder.DropTable(
                name: "SelectionProcessStatuses");
        }
    }
}

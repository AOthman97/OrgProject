using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADminLteTest.Migrations
{
    public partial class AddExpertQualificationsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpertQualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpertNo = table.Column<int>(type: "int", nullable: false),
                    QualificationsNo = table.Column<int>(type: "int", nullable: false),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Faculty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertQualifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpertQualifications_Expert_ExpertNo",
                        column: x => x.ExpertNo,
                        principalTable: "Expert",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpertQualifications_Qualifications_QualificationsNo",
                        column: x => x.QualificationsNo,
                        principalTable: "Qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpertQualifications_ExpertNo",
                table: "ExpertQualifications",
                column: "ExpertNo");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertQualifications_QualificationsNo",
                table: "ExpertQualifications",
                column: "QualificationsNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpertQualifications");
        }
    }
}

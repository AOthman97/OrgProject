using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADminLteTest.Migrations
{
    public partial class init123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgeAvarege = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrgTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgressTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkNatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkNatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrgDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaoundationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityNo = table.Column<int>(type: "int", nullable: false),
                    DistrictNo = table.Column<int>(type: "int", nullable: false),
                    OrgTypeNo = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    OrgTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrgDetails_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrgDetails_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrgDetails_OrgTypes_OrgTypeId",
                        column: x => x.OrgTypeId,
                        principalTable: "OrgTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrgnaizationsApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrgDetailsNo = table.Column<int>(type: "int", nullable: false),
                    OrgDetailsId = table.Column<int>(type: "int", nullable: false),
                    WorkNatureId = table.Column<int>(type: "int", nullable: false),
                    WorkNutureNo = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    StaffNo = table.Column<int>(type: "int", nullable: false),
                    IsApproched = table.Column<bool>(type: "bit", nullable: false),
                    ApprochNature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourcesRoom = table.Column<bool>(type: "bit", nullable: false),
                    QualificationPeriod = table.Column<int>(type: "int", nullable: false),
                    IsProgreessed = table.Column<bool>(type: "bit", nullable: false),
                    ProgressTypeId = table.Column<int>(type: "int", nullable: false),
                    ProgressTypeNo = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommunicationTypeId = table.Column<int>(type: "int", nullable: false),
                    CommunicationTypeNo = table.Column<int>(type: "int", nullable: false),
                    IdeasAndRecommondaions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgnaizationsApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrgnaizationsApplications_CommunicationType_CommunicationTypeId",
                        column: x => x.CommunicationTypeId,
                        principalTable: "CommunicationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrgnaizationsApplications_OrgDetails_OrgDetailsId",
                        column: x => x.OrgDetailsId,
                        principalTable: "OrgDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrgnaizationsApplications_ProgressTypes_ProgressTypeId",
                        column: x => x.ProgressTypeId,
                        principalTable: "ProgressTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrgnaizationsApplications_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrgnaizationsApplications_WorkNatures_WorkNatureId",
                        column: x => x.WorkNatureId,
                        principalTable: "WorkNatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HandicappedCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgnaizationsApplicationId = table.Column<int>(type: "int", nullable: false),
                    OrgnaizationsApplicationNo = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryNo = table.Column<int>(type: "int", nullable: false),
                    AgeId = table.Column<int>(type: "int", nullable: false),
                    AgeNo = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    GenderNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandicappedCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HandicappedCategory_Ages_AgeId",
                        column: x => x.AgeId,
                        principalTable: "Ages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HandicappedCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HandicappedCategory_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HandicappedCategory_OrgnaizationsApplications_OrgnaizationsApplicationId",
                        column: x => x.OrgnaizationsApplicationId,
                        principalTable: "OrgnaizationsApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedCategory_AgeId",
                table: "HandicappedCategory",
                column: "AgeId");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedCategory_CategoryId",
                table: "HandicappedCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedCategory_GenderId",
                table: "HandicappedCategory",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedCategory_OrgnaizationsApplicationId",
                table: "HandicappedCategory",
                column: "OrgnaizationsApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgDetails_CityId",
                table: "OrgDetails",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgDetails_DistrictId",
                table: "OrgDetails",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgDetails_OrgTypeId",
                table: "OrgDetails",
                column: "OrgTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgnaizationsApplications_CommunicationTypeId",
                table: "OrgnaizationsApplications",
                column: "CommunicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgnaizationsApplications_OrgDetailsId",
                table: "OrgnaizationsApplications",
                column: "OrgDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgnaizationsApplications_ProgressTypeId",
                table: "OrgnaizationsApplications",
                column: "ProgressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgnaizationsApplications_StaffId",
                table: "OrgnaizationsApplications",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgnaizationsApplications_WorkNatureId",
                table: "OrgnaizationsApplications",
                column: "WorkNatureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HandicappedCategory");

            migrationBuilder.DropTable(
                name: "Ages");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "OrgnaizationsApplications");

            migrationBuilder.DropTable(
                name: "CommunicationType");

            migrationBuilder.DropTable(
                name: "OrgDetails");

            migrationBuilder.DropTable(
                name: "ProgressTypes");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "WorkNatures");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "OrgTypes");
        }
    }
}

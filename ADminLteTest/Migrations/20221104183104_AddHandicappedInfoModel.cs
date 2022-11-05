using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADminLteTest.Migrations
{
    public partial class AddHandicappedInfoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationalStatuses",
                table: "EducationalStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EconomicLevels",
                table: "EconomicLevels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccommodationTypes",
                table: "AccommodationTypes");

            migrationBuilder.RenameTable(
                name: "EducationalStatuses",
                newName: "EducationalStatus");

            migrationBuilder.RenameTable(
                name: "EconomicLevels",
                newName: "EconomicLevel");

            migrationBuilder.RenameTable(
                name: "AccommodationTypes",
                newName: "AccommodationType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationalStatus",
                table: "EducationalStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EconomicLevel",
                table: "EconomicLevel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccommodationType",
                table: "AccommodationType",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "HandicappedInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weaknesses = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherMobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherMobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    GenderNo = table.Column<int>(type: "int", nullable: false),
                    OrgDetailsNo = table.Column<int>(type: "int", nullable: false),
                    CityNo = table.Column<int>(type: "int", nullable: false),
                    DistrictNo = table.Column<int>(type: "int", nullable: false),
                    CategoryNo = table.Column<int>(type: "int", nullable: false),
                    WorkNatureNo = table.Column<int>(type: "int", nullable: false),
                    EconomicLevelNo = table.Column<int>(type: "int", nullable: false),
                    AccommodationTypeNo = table.Column<int>(type: "int", nullable: false),
                    EducationalStatusNo = table.Column<int>(type: "int", nullable: false),
                    FatherEducationalStatusNo = table.Column<int>(type: "int", nullable: false),
                    MotherEducationalStatusNo = table.Column<int>(type: "int", nullable: false),
                    IsWorking = table.Column<bool>(type: "bit", nullable: false),
                    HafezCapability = table.Column<bool>(type: "bit", nullable: false),
                    SwimmingCapability = table.Column<bool>(type: "bit", nullable: false),
                    DrawAndColoringCapability = table.Column<bool>(type: "bit", nullable: false),
                    LiteratureCapability = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandicappedInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HandicappedInfo_AccommodationType_AccommodationTypeNo",
                        column: x => x.AccommodationTypeNo,
                        principalTable: "AccommodationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HandicappedInfo_Category_CategoryNo",
                        column: x => x.CategoryNo,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HandicappedInfo_Cities_CityNo",
                        column: x => x.CityNo,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HandicappedInfo_Districts_DistrictNo",
                        column: x => x.DistrictNo,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HandicappedInfo_EconomicLevel_EconomicLevelNo",
                        column: x => x.EconomicLevelNo,
                        principalTable: "EconomicLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HandicappedInfo_EducationalStatus_MotherEducationalStatusNo",
                        column: x => x.MotherEducationalStatusNo,
                        principalTable: "EducationalStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HandicappedInfo_Genders_GenderNo",
                        column: x => x.GenderNo,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HandicappedInfo_OrgDetails_OrgDetailsNo",
                        column: x => x.OrgDetailsNo,
                        principalTable: "OrgDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HandicappedInfo_WorkNatures_WorkNatureNo",
                        column: x => x.WorkNatureNo,
                        principalTable: "WorkNatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedInfo_AccommodationTypeNo",
                table: "HandicappedInfo",
                column: "AccommodationTypeNo");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedInfo_CategoryNo",
                table: "HandicappedInfo",
                column: "CategoryNo");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedInfo_CityNo",
                table: "HandicappedInfo",
                column: "CityNo");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedInfo_DistrictNo",
                table: "HandicappedInfo",
                column: "DistrictNo");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedInfo_EconomicLevelNo",
                table: "HandicappedInfo",
                column: "EconomicLevelNo");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedInfo_GenderNo",
                table: "HandicappedInfo",
                column: "GenderNo");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedInfo_MotherEducationalStatusNo",
                table: "HandicappedInfo",
                column: "MotherEducationalStatusNo");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedInfo_OrgDetailsNo",
                table: "HandicappedInfo",
                column: "OrgDetailsNo");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedInfo_WorkNatureNo",
                table: "HandicappedInfo",
                column: "WorkNatureNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HandicappedInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationalStatus",
                table: "EducationalStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EconomicLevel",
                table: "EconomicLevel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccommodationType",
                table: "AccommodationType");

            migrationBuilder.RenameTable(
                name: "EducationalStatus",
                newName: "EducationalStatuses");

            migrationBuilder.RenameTable(
                name: "EconomicLevel",
                newName: "EconomicLevels");

            migrationBuilder.RenameTable(
                name: "AccommodationType",
                newName: "AccommodationTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationalStatuses",
                table: "EducationalStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EconomicLevels",
                table: "EconomicLevels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccommodationTypes",
                table: "AccommodationTypes",
                column: "Id");
        }
    }
}

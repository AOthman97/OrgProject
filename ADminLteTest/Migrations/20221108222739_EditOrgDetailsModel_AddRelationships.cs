using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADminLteTest.Migrations
{
    public partial class EditOrgDetailsModel_AddRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_OrgDetails_CityNo",
                table: "OrgDetails",
                column: "CityNo");

            migrationBuilder.CreateIndex(
                name: "IX_OrgDetails_DistrictNo",
                table: "OrgDetails",
                column: "DistrictNo");

            migrationBuilder.CreateIndex(
                name: "IX_OrgDetails_OrgTypeNo",
                table: "OrgDetails",
                column: "OrgTypeNo");

            migrationBuilder.AddForeignKey(
                name: "FK_OrgDetails_Cities_CityNo",
                table: "OrgDetails",
                column: "CityNo",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgDetails_Districts_DistrictNo",
                table: "OrgDetails",
                column: "DistrictNo",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgDetails_OrgTypes_OrgTypeNo",
                table: "OrgDetails",
                column: "OrgTypeNo",
                principalTable: "OrgTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrgDetails_Cities_CityNo",
                table: "OrgDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgDetails_Districts_DistrictNo",
                table: "OrgDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgDetails_OrgTypes_OrgTypeNo",
                table: "OrgDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrgDetails_CityNo",
                table: "OrgDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrgDetails_DistrictNo",
                table: "OrgDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrgDetails_OrgTypeNo",
                table: "OrgDetails");
        }
    }
}

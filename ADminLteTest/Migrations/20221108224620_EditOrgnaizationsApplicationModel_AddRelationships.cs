using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADminLteTest.Migrations
{
    public partial class EditOrgnaizationsApplicationModel_AddRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_OrgnaizationsApplications_CommunicationTypeNo",
                table: "OrgnaizationsApplications",
                column: "CommunicationTypeNo");

            migrationBuilder.CreateIndex(
                name: "IX_OrgnaizationsApplications_OrgDetailsNo",
                table: "OrgnaizationsApplications",
                column: "OrgDetailsNo");

            migrationBuilder.CreateIndex(
                name: "IX_OrgnaizationsApplications_ProgressTypeNo",
                table: "OrgnaizationsApplications",
                column: "ProgressTypeNo");

            migrationBuilder.CreateIndex(
                name: "IX_OrgnaizationsApplications_StaffNo",
                table: "OrgnaizationsApplications",
                column: "StaffNo");

            migrationBuilder.CreateIndex(
                name: "IX_OrgnaizationsApplications_WorkNutureNo",
                table: "OrgnaizationsApplications",
                column: "WorkNutureNo");

            migrationBuilder.AddForeignKey(
                name: "FK_OrgnaizationsApplications_CommunicationType_CommunicationTypeNo",
                table: "OrgnaizationsApplications",
                column: "CommunicationTypeNo",
                principalTable: "CommunicationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgnaizationsApplications_OrgDetails_OrgDetailsNo",
                table: "OrgnaizationsApplications",
                column: "OrgDetailsNo",
                principalTable: "OrgDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgnaizationsApplications_ProgressTypes_ProgressTypeNo",
                table: "OrgnaizationsApplications",
                column: "ProgressTypeNo",
                principalTable: "ProgressTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgnaizationsApplications_Staffs_StaffNo",
                table: "OrgnaizationsApplications",
                column: "StaffNo",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgnaizationsApplications_WorkNatures_WorkNutureNo",
                table: "OrgnaizationsApplications",
                column: "WorkNutureNo",
                principalTable: "WorkNatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrgnaizationsApplications_CommunicationType_CommunicationTypeNo",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgnaizationsApplications_OrgDetails_OrgDetailsNo",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgnaizationsApplications_ProgressTypes_ProgressTypeNo",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgnaizationsApplications_Staffs_StaffNo",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgnaizationsApplications_WorkNatures_WorkNutureNo",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropIndex(
                name: "IX_OrgnaizationsApplications_CommunicationTypeNo",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropIndex(
                name: "IX_OrgnaizationsApplications_OrgDetailsNo",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropIndex(
                name: "IX_OrgnaizationsApplications_ProgressTypeNo",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropIndex(
                name: "IX_OrgnaizationsApplications_StaffNo",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropIndex(
                name: "IX_OrgnaizationsApplications_WorkNutureNo",
                table: "OrgnaizationsApplications");
        }
    }
}

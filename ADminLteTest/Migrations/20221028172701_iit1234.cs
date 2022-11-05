using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADminLteTest.Migrations
{
    public partial class iit1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedCategory_Ages_AgeId",
                table: "HandicappedCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedCategory_Category_CategoryId",
                table: "HandicappedCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedCategory_Genders_GenderId",
                table: "HandicappedCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgDetails_Cities_CityId",
                table: "OrgDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgDetails_Districts_DistrictId",
                table: "OrgDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgDetails_OrgTypes_OrgTypeId",
                table: "OrgDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgnaizationsApplications_CommunicationType_CommunicationTypeId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgnaizationsApplications_OrgDetails_OrgDetailsId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgnaizationsApplications_ProgressTypes_ProgressTypeId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgnaizationsApplications_Staffs_StaffId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgnaizationsApplications_WorkNatures_WorkNatureId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropIndex(
                name: "IX_OrgnaizationsApplications_CommunicationTypeId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropIndex(
                name: "IX_OrgnaizationsApplications_OrgDetailsId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropIndex(
                name: "IX_OrgnaizationsApplications_ProgressTypeId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropIndex(
                name: "IX_OrgnaizationsApplications_StaffId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropIndex(
                name: "IX_OrgnaizationsApplications_WorkNatureId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropIndex(
                name: "IX_OrgDetails_CityId",
                table: "OrgDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrgDetails_DistrictId",
                table: "OrgDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrgDetails_OrgTypeId",
                table: "OrgDetails");

            migrationBuilder.DropIndex(
                name: "IX_HandicappedCategory_AgeId",
                table: "HandicappedCategory");

            migrationBuilder.DropIndex(
                name: "IX_HandicappedCategory_CategoryId",
                table: "HandicappedCategory");

            migrationBuilder.DropIndex(
                name: "IX_HandicappedCategory_GenderId",
                table: "HandicappedCategory");

            migrationBuilder.DropColumn(
                name: "CommunicationTypeId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropColumn(
                name: "OrgDetailsId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropColumn(
                name: "ProgressTypeId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropColumn(
                name: "WorkNatureId",
                table: "OrgnaizationsApplications");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "OrgDetails");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "OrgDetails");

            migrationBuilder.DropColumn(
                name: "OrgTypeId",
                table: "OrgDetails");

            migrationBuilder.DropColumn(
                name: "AgeId",
                table: "HandicappedCategory");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "HandicappedCategory");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "HandicappedCategory");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommunicationTypeId",
                table: "OrgnaizationsApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrgDetailsId",
                table: "OrgnaizationsApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProgressTypeId",
                table: "OrgnaizationsApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "OrgnaizationsApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkNatureId",
                table: "OrgnaizationsApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "OrgDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "OrgDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrgTypeId",
                table: "OrgDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgeId",
                table: "HandicappedCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "HandicappedCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "HandicappedCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedCategory_Ages_AgeId",
                table: "HandicappedCategory",
                column: "AgeId",
                principalTable: "Ages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedCategory_Category_CategoryId",
                table: "HandicappedCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedCategory_Genders_GenderId",
                table: "HandicappedCategory",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgDetails_Cities_CityId",
                table: "OrgDetails",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgDetails_Districts_DistrictId",
                table: "OrgDetails",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgDetails_OrgTypes_OrgTypeId",
                table: "OrgDetails",
                column: "OrgTypeId",
                principalTable: "OrgTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgnaizationsApplications_CommunicationType_CommunicationTypeId",
                table: "OrgnaizationsApplications",
                column: "CommunicationTypeId",
                principalTable: "CommunicationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgnaizationsApplications_OrgDetails_OrgDetailsId",
                table: "OrgnaizationsApplications",
                column: "OrgDetailsId",
                principalTable: "OrgDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgnaizationsApplications_ProgressTypes_ProgressTypeId",
                table: "OrgnaizationsApplications",
                column: "ProgressTypeId",
                principalTable: "ProgressTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgnaizationsApplications_Staffs_StaffId",
                table: "OrgnaizationsApplications",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgnaizationsApplications_WorkNatures_WorkNatureId",
                table: "OrgnaizationsApplications",
                column: "WorkNatureId",
                principalTable: "WorkNatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

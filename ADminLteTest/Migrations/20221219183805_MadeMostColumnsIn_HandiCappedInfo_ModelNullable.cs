using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADminLteTest.Migrations
{
    public partial class MadeMostColumnsIn_HandiCappedInfo_ModelNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_AccommodationType_AccommodationTypeNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_Category_CategoryNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_Cities_CityNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_Districts_DistrictNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_EconomicLevel_EconomicLevelNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_EducationalStatusNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_FatherEducationalStatusNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_MotherEducationalStatusNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_OrgDetails_OrgDetailsNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_WorkNatures_WorkNatureNo",
                table: "HandicappedInfo");

            migrationBuilder.AlterColumn<int>(
                name: "WorkNatureNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Weaknesses",
                table: "HandicappedInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "OrgDetailsNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MotherMobile",
                table: "HandicappedInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MotherEducationalStatusNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FatherMobile",
                table: "HandicappedInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "FatherEducationalStatusNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EducationalStatusNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EconomicLevelNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DistrictNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CityNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "HandicappedInfo",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "HandicappedInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "HandicappedInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AccommodationTypeNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_AccommodationType_AccommodationTypeNo",
                table: "HandicappedInfo",
                column: "AccommodationTypeNo",
                principalTable: "AccommodationType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_Category_CategoryNo",
                table: "HandicappedInfo",
                column: "CategoryNo",
                principalTable: "Category",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_Cities_CityNo",
                table: "HandicappedInfo",
                column: "CityNo",
                principalTable: "Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_Districts_DistrictNo",
                table: "HandicappedInfo",
                column: "DistrictNo",
                principalTable: "Districts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_EconomicLevel_EconomicLevelNo",
                table: "HandicappedInfo",
                column: "EconomicLevelNo",
                principalTable: "EconomicLevel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_EducationalStatusNo",
                table: "HandicappedInfo",
                column: "EducationalStatusNo",
                principalTable: "EducationalStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_FatherEducationalStatusNo",
                table: "HandicappedInfo",
                column: "FatherEducationalStatusNo",
                principalTable: "EducationalStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_MotherEducationalStatusNo",
                table: "HandicappedInfo",
                column: "MotherEducationalStatusNo",
                principalTable: "EducationalStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_OrgDetails_OrgDetailsNo",
                table: "HandicappedInfo",
                column: "OrgDetailsNo",
                principalTable: "OrgDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_WorkNatures_WorkNatureNo",
                table: "HandicappedInfo",
                column: "WorkNatureNo",
                principalTable: "WorkNatures",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_AccommodationType_AccommodationTypeNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_Category_CategoryNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_Cities_CityNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_Districts_DistrictNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_EconomicLevel_EconomicLevelNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_EducationalStatusNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_FatherEducationalStatusNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_MotherEducationalStatusNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_OrgDetails_OrgDetailsNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_WorkNatures_WorkNatureNo",
                table: "HandicappedInfo");

            migrationBuilder.AlterColumn<int>(
                name: "WorkNatureNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Weaknesses",
                table: "HandicappedInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrgDetailsNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MotherMobile",
                table: "HandicappedInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MotherEducationalStatusNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FatherMobile",
                table: "HandicappedInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FatherEducationalStatusNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EducationalStatusNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EconomicLevelNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DistrictNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "HandicappedInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "HandicappedInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "HandicappedInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccommodationTypeNo",
                table: "HandicappedInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_AccommodationType_AccommodationTypeNo",
                table: "HandicappedInfo",
                column: "AccommodationTypeNo",
                principalTable: "AccommodationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_Category_CategoryNo",
                table: "HandicappedInfo",
                column: "CategoryNo",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_Cities_CityNo",
                table: "HandicappedInfo",
                column: "CityNo",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_Districts_DistrictNo",
                table: "HandicappedInfo",
                column: "DistrictNo",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_EconomicLevel_EconomicLevelNo",
                table: "HandicappedInfo",
                column: "EconomicLevelNo",
                principalTable: "EconomicLevel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_EducationalStatusNo",
                table: "HandicappedInfo",
                column: "EducationalStatusNo",
                principalTable: "EducationalStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_FatherEducationalStatusNo",
                table: "HandicappedInfo",
                column: "FatherEducationalStatusNo",
                principalTable: "EducationalStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_MotherEducationalStatusNo",
                table: "HandicappedInfo",
                column: "MotherEducationalStatusNo",
                principalTable: "EducationalStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_OrgDetails_OrgDetailsNo",
                table: "HandicappedInfo",
                column: "OrgDetailsNo",
                principalTable: "OrgDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_WorkNatures_WorkNatureNo",
                table: "HandicappedInfo",
                column: "WorkNatureNo",
                principalTable: "WorkNatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

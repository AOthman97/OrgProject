using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADminLteTest.Migrations
{
    public partial class AddAccommodationTypeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccommodationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccommodationTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedCategory_AgeNo",
                table: "HandicappedCategory",
                column: "AgeNo");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedCategory_CategoryNo",
                table: "HandicappedCategory",
                column: "CategoryNo");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedCategory_GenderNo",
                table: "HandicappedCategory",
                column: "GenderNo");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedCategory_OrgDetailsNo",
                table: "HandicappedCategory",
                column: "OrgDetailsNo");

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedCategory_Ages_AgeNo",
                table: "HandicappedCategory",
                column: "AgeNo",
                principalTable: "Ages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedCategory_Category_CategoryNo",
                table: "HandicappedCategory",
                column: "CategoryNo",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedCategory_Genders_GenderNo",
                table: "HandicappedCategory",
                column: "GenderNo",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedCategory_OrgDetails_OrgDetailsNo",
                table: "HandicappedCategory",
                column: "OrgDetailsNo",
                principalTable: "OrgDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedCategory_Ages_AgeNo",
                table: "HandicappedCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedCategory_Category_CategoryNo",
                table: "HandicappedCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedCategory_Genders_GenderNo",
                table: "HandicappedCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedCategory_OrgDetails_OrgDetailsNo",
                table: "HandicappedCategory");

            migrationBuilder.DropTable(
                name: "AccommodationTypes");

            migrationBuilder.DropIndex(
                name: "IX_HandicappedCategory_AgeNo",
                table: "HandicappedCategory");

            migrationBuilder.DropIndex(
                name: "IX_HandicappedCategory_CategoryNo",
                table: "HandicappedCategory");

            migrationBuilder.DropIndex(
                name: "IX_HandicappedCategory_GenderNo",
                table: "HandicappedCategory");

            migrationBuilder.DropIndex(
                name: "IX_HandicappedCategory_OrgDetailsNo",
                table: "HandicappedCategory");
        }
    }
}

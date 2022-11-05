using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADminLteTest.Migrations
{
    public partial class initialmigatins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedCategory_OrgnaizationsApplications_OrgnaizationsApplicationId",
                table: "HandicappedCategory");

            migrationBuilder.DropIndex(
                name: "IX_HandicappedCategory_OrgnaizationsApplicationId",
                table: "HandicappedCategory");

            migrationBuilder.RenameColumn(
                name: "OrgnaizationsApplicationId",
                table: "HandicappedCategory",
                newName: "Quantity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "HandicappedCategory",
                newName: "OrgnaizationsApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedCategory_OrgnaizationsApplicationId",
                table: "HandicappedCategory",
                column: "OrgnaizationsApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedCategory_OrgnaizationsApplications_OrgnaizationsApplicationId",
                table: "HandicappedCategory",
                column: "OrgnaizationsApplicationId",
                principalTable: "OrgnaizationsApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

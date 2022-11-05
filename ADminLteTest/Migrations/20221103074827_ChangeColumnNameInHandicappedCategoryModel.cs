using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADminLteTest.Migrations
{
    public partial class ChangeColumnNameInHandicappedCategoryModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrgnaizationsApplicationNo",
                table: "HandicappedCategory",
                newName: "OrgDetailsNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrgDetailsNo",
                table: "HandicappedCategory",
                newName: "OrgnaizationsApplicationNo");
        }
    }
}

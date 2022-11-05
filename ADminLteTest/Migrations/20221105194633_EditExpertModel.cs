using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADminLteTest.Migrations
{
    public partial class EditExpertModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Expert_WorkNatureNo",
                table: "Expert",
                column: "WorkNatureNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Expert_WorkNatures_WorkNatureNo",
                table: "Expert",
                column: "WorkNatureNo",
                principalTable: "WorkNatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expert_WorkNatures_WorkNatureNo",
                table: "Expert");

            migrationBuilder.DropIndex(
                name: "IX_Expert_WorkNatureNo",
                table: "Expert");
        }
    }
}

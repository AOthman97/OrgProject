using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADminLteTest.Migrations
{
    public partial class AddExpertModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expert",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalMobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkMobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegularMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkingFor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkNatureNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expert", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedInfo_EducationalStatusNo",
                table: "HandicappedInfo",
                column: "EducationalStatusNo");

            migrationBuilder.CreateIndex(
                name: "IX_HandicappedInfo_FatherEducationalStatusNo",
                table: "HandicappedInfo",
                column: "FatherEducationalStatusNo");

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_EducationalStatusNo",
                table: "HandicappedInfo",
                column: "EducationalStatusNo",
                principalTable: "EducationalStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_FatherEducationalStatusNo",
                table: "HandicappedInfo",
                column: "FatherEducationalStatusNo",
                principalTable: "EducationalStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_EducationalStatusNo",
                table: "HandicappedInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_HandicappedInfo_EducationalStatus_FatherEducationalStatusNo",
                table: "HandicappedInfo");

            migrationBuilder.DropTable(
                name: "Expert");

            migrationBuilder.DropIndex(
                name: "IX_HandicappedInfo_EducationalStatusNo",
                table: "HandicappedInfo");

            migrationBuilder.DropIndex(
                name: "IX_HandicappedInfo_FatherEducationalStatusNo",
                table: "HandicappedInfo");
        }
    }
}

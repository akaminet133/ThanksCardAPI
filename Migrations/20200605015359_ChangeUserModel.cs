using Microsoft.EntityFrameworkCore.Migrations;

namespace ThanksCardAPI.Migrations
{
    public partial class ChangeUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorys_ThanksCards_ThanksCardId",
                table: "Categorys");

            migrationBuilder.DropIndex(
                name: "IX_Categorys_ThanksCardId",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "ThanksCardId",
                table: "Categorys");

            migrationBuilder.AddColumn<long>(
                name: "Category_Id",
                table: "ThanksCards",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CategorysId",
                table: "ThanksCards",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThanksCards_CategorysId",
                table: "ThanksCards",
                column: "CategorysId");

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCards_Categorys_CategorysId",
                table: "ThanksCards",
                column: "CategorysId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Categorys_CategorysId",
                table: "ThanksCards");

            migrationBuilder.DropIndex(
                name: "IX_ThanksCards_CategorysId",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "CategorysId",
                table: "ThanksCards");

            migrationBuilder.AddColumn<long>(
                name: "ThanksCardId",
                table: "Categorys",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_ThanksCardId",
                table: "Categorys",
                column: "ThanksCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorys_ThanksCards_ThanksCardId",
                table: "Categorys",
                column: "ThanksCardId",
                principalTable: "ThanksCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

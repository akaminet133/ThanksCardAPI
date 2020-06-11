using Microsoft.EntityFrameworkCore.Migrations;

namespace ThanksCardAPI.Migrations
{
    public partial class ChangeRenkei : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_User_Dep_Kanris_FromId",
                table: "ThanksCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_User_Dep_Kanris_ToId",
                table: "ThanksCards");

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCards_Users_FromId",
                table: "ThanksCards",
                column: "FromId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCards_Users_ToId",
                table: "ThanksCards",
                column: "ToId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Users_FromId",
                table: "ThanksCards");

            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Users_ToId",
                table: "ThanksCards");

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCards_User_Dep_Kanris_FromId",
                table: "ThanksCards",
                column: "FromId",
                principalTable: "User_Dep_Kanris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCards_User_Dep_Kanris_ToId",
                table: "ThanksCards",
                column: "ToId",
                principalTable: "User_Dep_Kanris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

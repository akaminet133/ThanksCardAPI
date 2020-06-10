using Microsoft.EntityFrameworkCore.Migrations;

namespace ThanksCardAPI.Migrations
{
    public partial class ChangeModels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ThanksCards_ThanksCardId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment_Rirekis");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserId",
                table: "Comment_Rirekis",
                newName: "IX_Comment_Rirekis_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ThanksCardId",
                table: "Comment_Rirekis",
                newName: "IX_Comment_Rirekis_ThanksCardId");

            migrationBuilder.AlterColumn<long>(
                name: "User_Id",
                table: "User_Dep_Kanris",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Section_Id",
                table: "User_Dep_Kanris",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Category_Id",
                table: "ThanksCards",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Dep_Id",
                table: "Sections",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment_Rirekis",
                table: "Comment_Rirekis",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Rirekis_ThanksCards_ThanksCardId",
                table: "Comment_Rirekis",
                column: "ThanksCardId",
                principalTable: "ThanksCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Rirekis_Users_UserId",
                table: "Comment_Rirekis",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Rirekis_ThanksCards_ThanksCardId",
                table: "Comment_Rirekis");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Rirekis_Users_UserId",
                table: "Comment_Rirekis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment_Rirekis",
                table: "Comment_Rirekis");

            migrationBuilder.RenameTable(
                name: "Comment_Rirekis",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_Rirekis_UserId",
                table: "Comments",
                newName: "IX_Comments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_Rirekis_ThanksCardId",
                table: "Comments",
                newName: "IX_Comments_ThanksCardId");

            migrationBuilder.AlterColumn<long>(
                name: "User_Id",
                table: "User_Dep_Kanris",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "Section_Id",
                table: "User_Dep_Kanris",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "Category_Id",
                table: "ThanksCards",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "Dep_Id",
                table: "Sections",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ThanksCards_ThanksCardId",
                table: "Comments",
                column: "ThanksCardId",
                principalTable: "ThanksCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

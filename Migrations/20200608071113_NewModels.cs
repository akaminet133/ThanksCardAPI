using Microsoft.EntityFrameworkCore.Migrations;

namespace ThanksCardAPI.Migrations
{
    public partial class NewModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorys_Departments_DepartmentId",
                table: "Categorys");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Rirekis_Users_UserId",
                table: "Comment_Rirekis");

            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Categorys_CategorysId",
                table: "ThanksCards");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Dep_Kanris_Sections_SectionId",
                table: "User_Dep_Kanris");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Dep_Kanris_Users_UserId",
                table: "User_Dep_Kanris");

            migrationBuilder.DropIndex(
                name: "IX_ThanksCards_CategorysId",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "Section_Id",
                table: "User_Dep_Kanris");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "User_Dep_Kanris");

            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "CategorysId",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "Dep_Id",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "Com_UserId",
                table: "Comment_Rirekis");

            migrationBuilder.DropColumn(
                name: "Dep_Id",
                table: "Categorys");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "User_Dep_Kanris",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "SectionId",
                table: "User_Dep_Kanris",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CategoryId",
                table: "ThanksCards",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "DeppartmentId",
                table: "Sections",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Comment_Rirekis",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DepartmentId",
                table: "Categorys",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThanksCards_CategoryId",
                table: "ThanksCards",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorys_Departments_DepartmentId",
                table: "Categorys",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Rirekis_Users_UserId",
                table: "Comment_Rirekis",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCards_Categorys_CategoryId",
                table: "ThanksCards",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Dep_Kanris_Sections_SectionId",
                table: "User_Dep_Kanris",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Dep_Kanris_Users_UserId",
                table: "User_Dep_Kanris",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorys_Departments_DepartmentId",
                table: "Categorys");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Rirekis_Users_UserId",
                table: "Comment_Rirekis");

            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Categorys_CategoryId",
                table: "ThanksCards");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Dep_Kanris_Sections_SectionId",
                table: "User_Dep_Kanris");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Dep_Kanris_Users_UserId",
                table: "User_Dep_Kanris");

            migrationBuilder.DropIndex(
                name: "IX_ThanksCards_CategoryId",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ThanksCards");

            migrationBuilder.DropColumn(
                name: "DeppartmentId",
                table: "Sections");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "User_Dep_Kanris",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "SectionId",
                table: "User_Dep_Kanris",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "Section_Id",
                table: "User_Dep_Kanris",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "User_Id",
                table: "User_Dep_Kanris",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Category_Id",
                table: "ThanksCards",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CategorysId",
                table: "ThanksCards",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Dep_Id",
                table: "Sections",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Comment_Rirekis",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "Com_UserId",
                table: "Comment_Rirekis",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "DepartmentId",
                table: "Categorys",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "Dep_Id",
                table: "Categorys",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThanksCards_CategorysId",
                table: "ThanksCards",
                column: "CategorysId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorys_Departments_DepartmentId",
                table: "Categorys",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Rirekis_Users_UserId",
                table: "Comment_Rirekis",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCards_Categorys_CategorysId",
                table: "ThanksCards",
                column: "CategorysId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Dep_Kanris_Sections_SectionId",
                table: "User_Dep_Kanris",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Dep_Kanris_Users_UserId",
                table: "User_Dep_Kanris",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

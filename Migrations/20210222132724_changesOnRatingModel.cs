using Microsoft.EntityFrameworkCore.Migrations;

namespace CoolRatings.Migrations
{
    public partial class changesOnRatingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ratingsModels_showModels_ShowModelId",
                table: "ratingsModels");

            migrationBuilder.AlterColumn<int>(
                name: "ShowModelId",
                table: "ratingsModels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ratingsModels_showModels_ShowModelId",
                table: "ratingsModels",
                column: "ShowModelId",
                principalTable: "showModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ratingsModels_showModels_ShowModelId",
                table: "ratingsModels");

            migrationBuilder.AlterColumn<int>(
                name: "ShowModelId",
                table: "ratingsModels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ratingsModels_showModels_ShowModelId",
                table: "ratingsModels",
                column: "ShowModelId",
                principalTable: "showModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

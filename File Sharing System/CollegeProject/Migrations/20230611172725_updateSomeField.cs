using Microsoft.EntityFrameworkCore.Migrations;

namespace CollegeProject.Migrations
{
    public partial class updateSomeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Share_Data_DataId",
                table: "Share");

            migrationBuilder.DropIndex(
                name: "IX_Share_DataId",
                table: "Share");

            migrationBuilder.DropColumn(
                name: "DataId",
                table: "Share");

            migrationBuilder.CreateIndex(
                name: "IX_Share_Fileid",
                table: "Share",
                column: "Fileid");

            migrationBuilder.CreateIndex(
                name: "IX_Share_ReciverId",
                table: "Share",
                column: "ReciverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Share_Data_Fileid",
                table: "Share",
                column: "Fileid",
                principalTable: "Data",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Share_AspNetUsers_ReciverId",
                table: "Share",
                column: "ReciverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Share_Data_Fileid",
                table: "Share");

            migrationBuilder.DropForeignKey(
                name: "FK_Share_AspNetUsers_ReciverId",
                table: "Share");

            migrationBuilder.DropIndex(
                name: "IX_Share_Fileid",
                table: "Share");

            migrationBuilder.DropIndex(
                name: "IX_Share_ReciverId",
                table: "Share");

            migrationBuilder.AddColumn<int>(
                name: "DataId",
                table: "Share",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Share_DataId",
                table: "Share",
                column: "DataId");

            migrationBuilder.AddForeignKey(
                name: "FK_Share_Data_DataId",
                table: "Share",
                column: "DataId",
                principalTable: "Data",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

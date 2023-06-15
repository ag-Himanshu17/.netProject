using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CollegeProject.Migrations
{
    public partial class addingShare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Share",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    Fileid = table.Column<int>(nullable: false),
                    DataId = table.Column<int>(nullable: true),
                    ReciverId = table.Column<Guid>(nullable: false),
                    IsCompleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Share", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Share_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Share_Data_DataId",
                        column: x => x.DataId,
                        principalTable: "Data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Share_CreatedBy",
                table: "Share",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Share_DataId",
                table: "Share",
                column: "DataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Share");
        }
    }
}

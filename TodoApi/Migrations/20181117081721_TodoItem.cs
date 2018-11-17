using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations
{
    public partial class TodoItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoItems",
                columns: table => new
                {
                    Gid = table.Column<Guid>(nullable: false),
                    UploadFileName = table.Column<string>(nullable: true),
                    UploadFilePath = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DownloadFileName = table.Column<string>(nullable: true),
                    DownloadFilePath = table.Column<string>(nullable: true),
                    DownloadTime = table.Column<DateTime>(nullable: true),
                    DownLoadCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItems", x => x.Gid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItems");
        }
    }
}

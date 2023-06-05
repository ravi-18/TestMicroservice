using Microsoft.EntityFrameworkCore.Migrations;

namespace Book.Service.Migrations
{
    public partial class modifyAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AuthorViewModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AuthorViewModels");
        }
    }
}

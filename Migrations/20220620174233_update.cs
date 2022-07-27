using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Profile.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SkillSet",
                table: "Skills",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Experiences",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Education",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillSet",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Education");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialNetwork.Infraestructure.Migrations
{
    public partial class AddPhotoProfileToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "PhotoProfile",
                table: "Users",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoProfile",
                table: "Users");
        }
    }
}

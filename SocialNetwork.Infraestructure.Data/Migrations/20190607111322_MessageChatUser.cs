using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialNetwork.Infraestructure.Migrations
{
    public partial class MessageChatUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MessageChats_UserId",
                table: "MessageChats",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageChats_Users_UserId",
                table: "MessageChats",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageChats_Users_UserId",
                table: "MessageChats");

            migrationBuilder.DropIndex(
                name: "IX_MessageChats_UserId",
                table: "MessageChats");
        }
    }
}

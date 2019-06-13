using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialNetwork.Infraestructure.Migrations
{
    public partial class ChatMessageChat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MessageChats_ChatId",
                table: "MessageChats",
                column: "ChatId");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageChats_Chats_ChatId",
                table: "MessageChats",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageChats_Chats_ChatId",
                table: "MessageChats");

            migrationBuilder.DropIndex(
                name: "IX_MessageChats_ChatId",
                table: "MessageChats");
        }
    }
}

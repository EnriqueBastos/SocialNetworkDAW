using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialNetwork.Infraestructure.Migrations
{
    public partial class ChangeBytesToBytesArray : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BytesPhoto",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "PhotoRoute",
                table: "Photos");

            migrationBuilder.AlterColumn<byte[]>(
                name: "PhotoProfile",
                table: "Users",
                nullable: true,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageBytes",
                table: "Photos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageBytes",
                table: "Photos");

            migrationBuilder.AlterColumn<byte>(
                name: "PhotoProfile",
                table: "Users",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "BytesPhoto",
                table: "Photos",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "PhotoRoute",
                table: "Photos",
                nullable: true);
        }
    }
}

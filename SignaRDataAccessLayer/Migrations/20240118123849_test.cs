using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignaRDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TestiMonialsS",
                table: "TestiMonialsS");

            migrationBuilder.RenameTable(
                name: "TestiMonialsS",
                newName: "TestiMonials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestiMonials",
                table: "TestiMonials",
                column: "TestiMonialID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TestiMonials",
                table: "TestiMonials");

            migrationBuilder.RenameTable(
                name: "TestiMonials",
                newName: "TestiMonialsS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestiMonialsS",
                table: "TestiMonialsS",
                column: "TestiMonialID");
        }
    }
}

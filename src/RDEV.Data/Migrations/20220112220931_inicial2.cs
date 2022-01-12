using Microsoft.EntityFrameworkCore.Migrations;

namespace RDEV.Data.Migrations
{
    public partial class inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Enderecos",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "100");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Enderecos",
                type: "100",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");
        }
    }
}

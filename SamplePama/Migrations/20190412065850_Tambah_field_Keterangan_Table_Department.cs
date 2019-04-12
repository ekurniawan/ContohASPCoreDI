using Microsoft.EntityFrameworkCore.Migrations;

namespace SamplePama.Migrations
{
    public partial class Tambah_field_Keterangan_Table_Department : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Keterangan",
                table: "Department",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keterangan",
                table: "Department");
        }
    }
}

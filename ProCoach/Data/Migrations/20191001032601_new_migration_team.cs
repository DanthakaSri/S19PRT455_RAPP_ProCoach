using Microsoft.EntityFrameworkCore.Migrations;

namespace ProCoach.Data.Migrations
{
    public partial class new_migration_team : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "coaches",
                table: "Team",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "coaches",
                table: "Team",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 60);
        }
    }
}

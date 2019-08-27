using Microsoft.EntityFrameworkCore.Migrations;

namespace ProCoach.Data.Migrations
{
    public partial class Pro_Coach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "Player",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Mobileno",
                table: "Player",
                newName: "Mobile_Number");

            migrationBuilder.RenameColumn(
                name: "EmergencyContact",
                table: "Player",
                newName: "Emergency_Contact");

            migrationBuilder.RenameColumn(
                name: "Clubname",
                table: "Player",
                newName: "Club_Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Player",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Mobile_Number",
                table: "Player",
                newName: "Mobileno");

            migrationBuilder.RenameColumn(
                name: "Emergency_Contact",
                table: "Player",
                newName: "EmergencyContact");

            migrationBuilder.RenameColumn(
                name: "Club_Name",
                table: "Player",
                newName: "Clubname");
        }
    }
}

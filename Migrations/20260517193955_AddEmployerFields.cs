using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaziKagwilawo.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployerFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeAgeRange",
                table: "Employers",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkingExperience",
                table: "Employers",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeAgeRange",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "WorkingExperience",
                table: "Employers");
        }
    }
}

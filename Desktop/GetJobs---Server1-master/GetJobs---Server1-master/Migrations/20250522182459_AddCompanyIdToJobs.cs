using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetJobsBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyIdToJobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Companies_CompanyId",
                table: "Jobs");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Jobs",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Companies",
                type: "text",
                nullable: false,
                defaultValue: "");
                migrationBuilder.InsertData(
    table: "Companies",
    columns: new[] { "Id", "Name", "Industry", "Location", "Website" },
    values: new object[] { 0, "Unknown", "Unassigned", "N/A", "N/A" }
);


            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Companies_CompanyId",
                table: "Jobs",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Companies_CompanyId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Companies");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Jobs",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Companies_CompanyId",
                table: "Jobs",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }
    }
}

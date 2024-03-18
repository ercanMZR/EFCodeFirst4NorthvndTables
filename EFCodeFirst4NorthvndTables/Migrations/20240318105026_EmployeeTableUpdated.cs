using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFirst4NorthvndTables.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeTableUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ReportToId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ReportToID",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "ReportToId",
                table: "Employees",
                newName: "ReportToID");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_ReportToId",
                table: "Employees",
                newName: "IX_Employees_ReportToID");

            migrationBuilder.AlterColumn<int>(
                name: "ReportToID",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ReportToID",
                table: "Employees",
                column: "ReportToID",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ReportToID",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "ReportToID",
                table: "Employees",
                newName: "ReportToId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_ReportToID",
                table: "Employees",
                newName: "IX_Employees_ReportToId");

            migrationBuilder.AlterColumn<int>(
                name: "ReportToId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReportToID",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ReportToId",
                table: "Employees",
                column: "ReportToId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

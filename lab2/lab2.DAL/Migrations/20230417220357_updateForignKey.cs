using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab2.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateForignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tickets_department_DepartmentId",
                table: "tickets");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_department_DepartmentId",
                table: "tickets",
                column: "DepartmentId",
                principalTable: "department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tickets_department_DepartmentId",
                table: "tickets");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_department_DepartmentId",
                table: "tickets",
                column: "DepartmentId",
                principalTable: "department",
                principalColumn: "Id");
        }
    }
}

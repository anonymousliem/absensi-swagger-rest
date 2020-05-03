using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AbsenApi.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "AbsenceId",
                keyValue: 1L);

            migrationBuilder.DropColumn(
                name: "AbsenceId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Approval",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ApprovalByAdmin",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CheckIn",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CheckOut",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "HeadDivision",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Absensi");

            migrationBuilder.AddColumn<long>(
                name: "userId",
                table: "Absensi",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Absensi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Absensi",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Absensi",
                table: "Absensi",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Absensi",
                table: "Absensi");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Absensi");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Absensi");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Absensi");

            migrationBuilder.RenameTable(
                name: "Absensi",
                newName: "Employees");

            migrationBuilder.AddColumn<long>(
                name: "AbsenceId",
                table: "Employees",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Approval",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApprovalByAdmin",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckIn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckOut",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadDivision",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "AbsenceId");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "AbsenceId", "Approval", "ApprovalByAdmin", "CheckIn", "CheckOut", "ClientName", "CompanyName", "HeadDivision", "Location", "Name", "Note", "Photo", "ProjectName", "State", "Username" },
                values: new object[] { 1L, null, null, new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "dummy", "dummy", null, null, null, "dummt", "dummy" });
        }
    }
}

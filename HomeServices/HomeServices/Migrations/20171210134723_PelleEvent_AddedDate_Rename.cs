using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HomeServices.Migrations
{
    public partial class PelleEvent_AddedDate_Rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PelleEvents",
                newName: "Status");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "PelleEvents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "PelleEvents");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "PelleEvents",
                newName: "Name");
        }
    }
}

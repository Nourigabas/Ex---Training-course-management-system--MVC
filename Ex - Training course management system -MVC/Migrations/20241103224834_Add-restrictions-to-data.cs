using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ex___Training_course_management_system__MVC.Migrations
{
    /// <inheritdoc />
    public partial class Addrestrictionstodata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("41eae902-d621-4056-9be5-8d360c264c4d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4c4c2c0f-29e9-4aaa-ad36-c61f70dba1e0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6ae61e6b-d38e-4586-8f73-59ad655a9f24"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "DurationHours", "EndDate", "InstructorId", "IsDelete", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("377f3c4f-f5a3-4f4a-bf09-ecc85759fa60"), "Learn the basics of programming using C#.", 40, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c100db04-6046-40e6-889f-7a4456ffd460"), false, "Introduction to Programming", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76cb4aea-bd20-42a8-80e7-feeb8a35c524"), "An introduction to data science concepts and tools.", 50, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4053f11d-e58c-4354-9af3-e05a512203ec"), false, "Data Science Basics", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e95d83b0-6cfe-4c90-97fc-a22343c408e7"), "Build dynamic websites using ASP.NET Core.", 60, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fd645597-2daa-42f7-ad88-ed0766345c56"), false, "Web Development with ASP.NET", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("377f3c4f-f5a3-4f4a-bf09-ecc85759fa60"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("76cb4aea-bd20-42a8-80e7-feeb8a35c524"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e95d83b0-6cfe-4c90-97fc-a22343c408e7"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "DurationHours", "EndDate", "InstructorId", "IsDelete", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("41eae902-d621-4056-9be5-8d360c264c4d"), "Build dynamic websites using ASP.NET Core.", 60, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fd645597-2daa-42f7-ad88-ed0766345c56"), false, "Web Development with ASP.NET", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c4c2c0f-29e9-4aaa-ad36-c61f70dba1e0"), "An introduction to data science concepts and tools.", 50, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4053f11d-e58c-4354-9af3-e05a512203ec"), false, "Data Science Basics", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6ae61e6b-d38e-4586-8f73-59ad655a9f24"), "Learn the basics of programming using C#.", 40, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c100db04-6046-40e6-889f-7a4456ffd460"), false, "Introduction to Programming", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}

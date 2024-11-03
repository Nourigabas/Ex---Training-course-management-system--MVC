using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ex___Training_course_management_system__MVC.Migrations
{
    /// <inheritdoc />
    public partial class addingpropisdeleteformodelcourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("00e3868f-2608-4f93-89b5-3de7c15dd30a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d1384003-8dcf-4208-93b1-223c9f2cd4f6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e8f1d781-8f54-4ec2-aed7-3e3705bc8782"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "DurationHours", "EndDate", "InstructorId", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("00e3868f-2608-4f93-89b5-3de7c15dd30a"), "Build dynamic websites using ASP.NET Core.", 60, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fd645597-2daa-42f7-ad88-ed0766345c56"), "Web Development with ASP.NET", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d1384003-8dcf-4208-93b1-223c9f2cd4f6"), "An introduction to data science concepts and tools.", 50, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4053f11d-e58c-4354-9af3-e05a512203ec"), "Data Science Basics", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e8f1d781-8f54-4ec2-aed7-3e3705bc8782"), "Learn the basics of programming using C#.", 40, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c100db04-6046-40e6-889f-7a4456ffd460"), "Introduction to Programming", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}

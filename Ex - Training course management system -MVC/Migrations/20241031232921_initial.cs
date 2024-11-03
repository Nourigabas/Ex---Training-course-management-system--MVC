using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ex___Training_course_management_system__MVC.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationHours = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("4053f11d-e58c-4354-9af3-e05a512203ec"), "michael.brown@example.com", "Michael Brown" },
                    { new Guid("c100db04-6046-40e6-889f-7a4456ffd460"), "john.smith@example.com", "John Smith" },
                    { new Guid("fd645597-2daa-42f7-ad88-ed0766345c56"), "emma.johnson@example.com", "Emma Johnson" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "DurationHours", "EndDate", "InstructorId", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("00e3868f-2608-4f93-89b5-3de7c15dd30a"), "Build dynamic websites using ASP.NET Core.", 60, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fd645597-2daa-42f7-ad88-ed0766345c56"), "Web Development with ASP.NET", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d1384003-8dcf-4208-93b1-223c9f2cd4f6"), "An introduction to data science concepts and tools.", 50, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4053f11d-e58c-4354-9af3-e05a512203ec"), "Data Science Basics", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e8f1d781-8f54-4ec2-aed7-3e3705bc8782"), "Learn the basics of programming using C#.", 40, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c100db04-6046-40e6-889f-7a4456ffd460"), "Introduction to Programming", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                column: "InstructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
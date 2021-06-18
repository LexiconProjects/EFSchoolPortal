using Microsoft.EntityFrameworkCore.Migrations;

namespace EFSchoolPortal.Data.Migrations
{
    public partial class Seeddataandrelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "Acronym", "Topic" },
                values: new object[,]
                {
                    { 1, "C001", "Data Structures" },
                    { 2, "C030", "Object Oriented Programming in Java" },
                    { 3, "C022", "Programming in C#" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Email", "Fname", "Lname" },
                values: new object[,]
                {
                    { 1, "HansDanielsson11@domain.com", "Hans", "Danielsson" },
                    { 2, "AlexsandraGustafsson23@domain.com", "Alexsandra", "Gustafsson" },
                    { 3, "Karl_Olofsson21@domain.com", "Karl", "Olofsson" }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "ID", "CourseID", "DueDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, "v40", "Linear Data Structures" },
                    { 2, 1, "v45", "Binary Tree Implementation" },
                    { 3, 2, "v42", "Inheritance and Polymorphism" },
                    { 4, 2, "v43", "Collections and Exceptions" },
                    { 5, 3, "v41", "Hello World in C#" },
                    { 6, 3, "v44", "Data types in C#" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "CourseId", "Email", "Fname", "Lname" },
                values: new object[,]
                {
                    { 1, 1, "HansAndersson11@stud.port.com", "Hans", "Andersson" },
                    { 2, 2, "CorneliaJohnsson22@stud.port.com", "Cornelia", "Johnsson" },
                    { 3, 3, "YusufEkstrom23@stud.port.com", "Yusuf", "Ekström" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}

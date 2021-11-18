using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Module4HW4.DataAccess.Migrations
{
    public partial class ClientCreateProjectRemade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Age", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 30, "t.kovalyova@gmail.com", "Tatyana", "Kovaleva" },
                    { 2, 37, "glebbb30@yahoo.com", "Gleb", "Ivanov" },
                    { 3, 28, "timisaev29@gmail.com", "Timur", "Isaev" },
                    { 4, 41, "lion29481@meta.ua", "Lev", "Novikov" },
                    { 5, 25, "timofey.kryukovv1@outlook.com", "Timofey", "Kryukov" }
                });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "OfficeId", "Location", "Title" },
                values: new object[] { 1, "Kyiv", "Main Office" });

            migrationBuilder.InsertData(
                table: "Title",
                columns: new[] { "TitleId", "Name" },
                values: new object[,]
                {
                    { 1, "Junior" },
                    { 2, "Middle" },
                    { 3, "Senior" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "FirstName", "HiredDate", "LastName", "OfficeId", "TitleId" },
                values: new object[,]
                {
                    { 4, new DateTime(1988, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ekaterina", new DateTime(2018, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ponomarenko", 1, 1 },
                    { 3, new DateTime(1980, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aleksandr", new DateTime(2016, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yakubovskiy", 1, 2 },
                    { 5, new DateTime(1991, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maria", new DateTime(2018, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belova", 1, 2 },
                    { 1, new DateTime(1995, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Igor", new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorohov", 1, 3 },
                    { 2, new DateTime(1997, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan", new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorohov", 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Budget", "ClientId", "Name", "StartedDate" },
                values: new object[,]
                {
                    { 1, 5000m, 1, "Finui Infotech", new DateTime(2016, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 7000m, 2, "Mobigradles", new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 50000m, 2, "Metacafe", new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 10000m, 3, "Binary Bit", new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 12000m, 4, "Hexagon Entertainment", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 23000m, 5, "TWS System", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeProjectId", "EmployeeId", "ProjectId", "Rate", "StartedDate" },
                values: new object[,]
                {
                    { 8, 4, 3, 50000m, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 4, 6, 23000m, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, 3, 50000m, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 3, 6, 23000m, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 5, 3, 50000m, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 5, 6, 23000m, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 1, 1, 5000m, new DateTime(2016, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 2, 7000m, new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 3, 50000m, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, 4, 10000m, new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 1, 5000m, new DateTime(2016, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, 2, 7000m, new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, 3, 50000m, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 2, 5, 12000m, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientId",
                table: "Project",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Project_ClientId",
                table: "Project");

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "OfficeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Project");
        }
    }
}

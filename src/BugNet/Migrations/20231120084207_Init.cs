using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BugNet.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    IsDone = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bugs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Description", "IsDone", "Name" },
                values: new object[,]
                {
                    { 1, "Users unable to log in due to incorrect password validation.", false, "Login Page Authentication Issue" },
                    { 2, "Graphs on the dashboard are not displaying data accurately.", true, "Dashboard Graph Rendering Error" },
                    { 3, "The mobile app crashes immediately after launching on iOS devices.", false, "Mobile App Crash on Startup" },
                    { 4, "Some form submissions are not saving user-entered data into the database.", true, "Data Loss on Form Submission" },
                    { 5, "The search feature in the application is not providing expected search results.", false, "Search Functionality Not Returning Results" },
                    { 6, "Prices in the shopping cart are not being calculated accurately.", true, "Incorrect Price Calculation in Shopping Cart" },
                    { 7, "Users encounter an error when attempting to upload documents larger than 5MB.", false, "File Upload Error in Documents Section" },
                    { 8, "Some navigation menu items are not visible to certain user roles.", true, "Missing Navigation Menu Items" },
                    { 9, "Email notifications are not being sent out to users as expected.", false, "Notification System Fails to Deliver Emails" },
                    { 10, "Font sizes vary inconsistently across different pages of the application.", true, "Inconsistent Font Sizes Across Web Pages" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bugs");
        }
    }
}

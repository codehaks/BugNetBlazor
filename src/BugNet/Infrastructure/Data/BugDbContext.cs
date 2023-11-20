using BugNet.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace BugNet.Infrastructure.Data;

public class BugDbContext : DbContext
{
    public BugDbContext(DbContextOptions<BugDbContext> options)
           : base(options)
    {
    }

    public DbSet<Bug> Bugs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        // Seed data
        modelBuilder.Entity<Bug>().HasData(
            new Bug { Id = 1, Name = "Login Page Authentication Issue", Description = "Users unable to log in due to incorrect password validation.", IsDone = false },
            new Bug { Id = 2, Name = "Dashboard Graph Rendering Error", Description = "Graphs on the dashboard are not displaying data accurately.", IsDone = true },
            new Bug { Id = 3, Name = "Mobile App Crash on Startup", Description = "The mobile app crashes immediately after launching on iOS devices.", IsDone = false },
            new Bug { Id = 4, Name = "Data Loss on Form Submission", Description = "Some form submissions are not saving user-entered data into the database.", IsDone = true },
            new Bug { Id = 5, Name = "Search Functionality Not Returning Results", Description = "The search feature in the application is not providing expected search results.", IsDone = false },
            new Bug { Id = 6, Name = "Incorrect Price Calculation in Shopping Cart", Description = "Prices in the shopping cart are not being calculated accurately.", IsDone = true },
            new Bug { Id = 7, Name = "File Upload Error in Documents Section", Description = "Users encounter an error when attempting to upload documents larger than 5MB.", IsDone = false },
            new Bug { Id = 8, Name = "Missing Navigation Menu Items", Description = "Some navigation menu items are not visible to certain user roles.", IsDone = true },
            new Bug { Id = 9, Name = "Notification System Fails to Deliver Emails", Description = "Email notifications are not being sent out to users as expected.", IsDone = false },
            new Bug { Id = 10, Name = "Inconsistent Font Sizes Across Web Pages", Description = "Font sizes vary inconsistently across different pages of the application.", IsDone = true }
        );

        base.OnModelCreating(modelBuilder);
    }
}

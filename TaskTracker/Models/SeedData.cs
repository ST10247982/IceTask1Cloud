using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskTracker.Data;
using System;
using System.Linq;
using TaskTracker.Data;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new TaskTrackerContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<TaskTrackerContext>>()))
        {
            // Look for any movies.
            if (context.Task.Any())
            {
                return;   // DB has been seeded
            }
            context.Task.AddRange(
                new TaskTracker.Models.Task
                {
                  Name = "DBAS Assignment",
                  Description = "Complete the DBAS assignment 1 ",
                  DueDate = DateTime.Parse("1-20-2024"),
                  TaskStatus = "Done",
                  TaskDifficulty = "Medium"
                },
                new TaskTracker.Models.Task
                {
                    Name = "Cloud Ice Task",
                    Description = "Create an MVC webapp for the ice task ",
                    DueDate = DateTime.Parse("1-20-2024"),
                    TaskStatus = "To-do",
                    TaskDifficulty = "Easy"

                },
                new TaskTracker.Models.Task
                {
                    Name = "Cloud Assignment",
                    Description = "Do research on cloud topics and create a base webapp ",
                    DueDate = DateTime.Parse("1-26-2024"),
                    TaskStatus = "To-do",
                    TaskDifficulty = "Medium"
                },
                new TaskTracker.Models.Task
                {
                    Name = "DBAS Assignment",
                    Description = "Complete the DBAS assignment 1 ",
                    DueDate = DateTime.Parse("1-20-2024"),
                    TaskStatus = "Done",
                    TaskDifficulty = "Medium"
                }
            );
            context.SaveChanges();
        }
    }
}
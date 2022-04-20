using System;
using Microsoft.EntityFrameworkCore;

namespace FinalPractice.Models
{
    public class QuestionContext : DbContext
    {

        // Setting up standard options
        public QuestionContext (DbContextOptions<QuestionContext> options) : base (options)
        {

        }

        public DbSet<StudentQuestion> Questions { get; set; }

        public DbSet<Assignment> Assignments { get; set; }

        // Seeding can take place here

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Assignment>().HasData(
                new Assignment { AssignmentId=1, AssignmentName="Mission 1"},
                new Assignment { AssignmentId = 2, AssignmentName = "Mission 2" },
                new Assignment { AssignmentId = 3, AssignmentName = "Mission 3" },
                new Assignment { AssignmentId = 4, AssignmentName = "Mission 4" },
                new Assignment { AssignmentId = 5, AssignmentName = "Mission 5" },
                new Assignment { AssignmentId = 6, AssignmentName = "Mission 6" },
                new Assignment { AssignmentId = 7, AssignmentName = "Mission 7" },
                new Assignment { AssignmentId = 8, AssignmentName = "Mission 8" },
                new Assignment { AssignmentId = 9, AssignmentName = "Mission 9" },
                new Assignment { AssignmentId = 10, AssignmentName = "Mission 10" },
                new Assignment { AssignmentId = 11, AssignmentName = "Mission 11" },
                new Assignment { AssignmentId = 12, AssignmentName = "Mission 12" }
                );
        }
    }
}

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

        //seeding can take place here
    }
}

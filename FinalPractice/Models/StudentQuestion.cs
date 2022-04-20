using System;
using System.ComponentModel.DataAnnotations;

namespace FinalPractice.Models
{
        public class StudentQuestion
        {
        [Key]
        [Required]
        public int QuestionID { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentNetID { get; set; }
        public string Question { get; set; }

        // Build Foreign Key Relationship
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        
        }
    
}

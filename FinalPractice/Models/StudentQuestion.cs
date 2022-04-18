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
        
        }
    
}

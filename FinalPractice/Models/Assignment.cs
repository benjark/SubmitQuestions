using System;
using System.ComponentModel.DataAnnotations;

namespace FinalPractice.Models
{
    public class Assignment
    {
        [Key]
        [Required]
        public int AssignmentId { get; set; }
        public string AssignmentName { get; set; }
    }
}

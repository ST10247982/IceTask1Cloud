using System.ComponentModel.DataAnnotations;

namespace TaskTracker.Models
{
    public class Task
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]

        public string? Name { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]

        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }
        [Display(Name = "Task Status")]
        public string? TaskStatus {  get; set; }
        [Display(Name = "Task Difficulty")]
        public string? TaskDifficulty {  get; set; }


    }
}

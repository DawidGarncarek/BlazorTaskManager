using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorTaskManager.Components.Models
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }

        public DateTime DueDate { get; set; } = DateTime.Now;
    }
}


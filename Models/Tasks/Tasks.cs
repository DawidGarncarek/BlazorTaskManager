using System;
using System.Collections.Generic;

namespace BlazorTaskManager.Models.Tasks;

public partial class TaskItem
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public bool IsCompleted { get; set; }

    public string UserName { get; set; }

    public DateTime DueDate { get; set; }
}
using BlazorTaskManager.Components.Pages;
using BlazorTaskManager.Models.Task;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTaskManager.Models
{
    public class TaskService
    {
        private readonly TaskContext _context;
        public TaskService(TaskContext context)
        {
            _context = context;
        }

        // Pobranie wszystkich zadań
        public async Task<List<TaskItem>> GetTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        // Dodanie zadania
        public async Task AddTaskAsync(TaskItem task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
        }

        // Usunięcie zadania
        public async Task DeleteTaskAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }

        // Aktualizacja statusu zadania
        public async Task ToggleCompletionAsync(TaskItem task)
        {
            task.IsCompleted = !task.IsCompleted;
            await _context.SaveChangesAsync();
        }

    }
}




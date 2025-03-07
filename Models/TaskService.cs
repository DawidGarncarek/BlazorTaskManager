using BlazorTaskManager.Components.Pages;
using BlazorTaskManager.Models.Tasks;
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

        public async Task<List<TaskItem>> GetTasksByUserAsync(string userName)
        {
            return await _context.Tasks
                .Where(t => t.UserName == userName)
                .ToListAsync();
        }

        public async Task AddTaskAsync(TaskItem objTask)
        {
            await _context.Tasks.AddAsync(objTask);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateTaskAsync(TaskItem task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }

        public async Task ToggleCompletionAsync(TaskItem task)
        {
            task.IsCompleted = !task.IsCompleted;
            await _context.SaveChangesAsync();
        }

    }
}




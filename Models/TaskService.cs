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

        //public async Task SendMessageAsync(string messageText, string userName)
        //{
        //    var newMessage = new UserChatMessages
        //    {
        //        MessageText = messageText,
        //        Date = DateTime.Now,
        //        UserName = userName
        //    };

        //    _context.UserChatMessages.Add(newMessage);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<List<UserChatMessages>> GetMessagesAsync()
        //{
        //    return await _context.UserChatMessages
        //        .OrderByDescending(m => m.Date)
        //        .ToListAsync();
        //}

    }
}




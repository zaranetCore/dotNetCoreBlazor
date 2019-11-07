using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Data
{
    public class TodoItemService
    {
        public Task<List<TodoItem>> GetTodoItems()
        {
            List<TodoItem> list = new List<TodoItem>();
            list.Add(new TodoItem() { 
                IsDone = false, Title = "zaranet",id = Guid.NewGuid().ToString()
            });
            return Task.FromResult(list);
        }
    }
}

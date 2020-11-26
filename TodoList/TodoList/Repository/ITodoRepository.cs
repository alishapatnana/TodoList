using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Repository
{
    public interface ITodoRepository
    {
        TodoItem Add(TodoItem item);
        List<TodoItem> GetAll();
        string Remove(string id);
        TodoItem Update(string id,TodoItem item);
    }
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private List<TodoItem> _todoItems;
        public TodoRepository()
        {
            _todoItems = new List<TodoItem>{
                new TodoItem {  Id="001",Name = "Conference with Client", Category = "Meeting for Project"},
                new TodoItem {  Id="002",Name = "Project Discussion", Category = "Meet with Manager"},
                new TodoItem {  Id="003",Name = "WorkFlow Discussion", Category = "Meeting for Project ID 1250043"},

            };
        }

        public TodoItem Add(TodoItem item)
        {
            _todoItems.Add(item);
            return item;
        }

        public List<TodoItem> GetAll()
        {
            return _todoItems;
        }

        public string Remove(string id)
        {
            for (var index = _todoItems.Count - 1; index >= 0; index--)
            {
                if (_todoItems[index].Id == id)
                {
                    _todoItems.RemoveAt(index);
                }
            }

            return id;
        }

        public TodoItem Update(string id, TodoItem item)
        {
            for (var index = _todoItems.Count - 1; index >= 0; index--)
            {
                if (_todoItems[index].Id == id)
                {
                    _todoItems[index] = item;
                }
            }
            return item;
        }
    }
}

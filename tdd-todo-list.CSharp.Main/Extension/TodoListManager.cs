using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main.Extension
{
    public class TodoListManager
    {
        private List<TodoItem> todoItems;

        public TodoListManager()
        {
            todoItems = new List<TodoItem>();
        }

        public void AddTodoItem(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public void RemoveTodoItem(int id)
        {
            throw new NotImplementedException();
        }

        public TodoItem GetTodoItemById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TodoItem> GetAllTodoItems(SortOrder sortOrder)
        {
            throw new NotImplementedException();
        }

        public List<TodoItem> GetCompletedTodoItems(SortOrder sortOrder)
        {
            throw new NotImplementedException();
        }

        public List<TodoItem> GetIncompleteTodoItems(SortOrder sortOrder)
        {
            throw new NotImplementedException();
        }

        public List<TodoItem> SearchTodoItems(string query, SortOrder sortOrder)
        {
            throw new NotImplementedException();
        }
    }

}

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
            todoItems.Add(item);
        }

        public void RemoveTodoItem(int id)
        {
            if (HasItemID(id)) todoItems.RemoveAt(todoItems.FindIndex(item => item.ID == id));
            else throw new InvalidOperationException($"There are no TodoItems with id={id}.");
        }

        public TodoItem GetTodoItemById(int id)
        {
            if (HasItemID(id)) return todoItems[todoItems.FindIndex((item) => item.ID == id)];
            throw new InvalidOperationException($"There are no TodoItems with id={id}.");
        }

        public List<TodoItem> GetAllTodoItems(SortOrder sortOrder = SortOrder.NotSorted)
        {
            return SortTodoItemByDescription(todoItems, sortOrder);
        }

        public List<TodoItem> GetCompletedTodoItems(SortOrder sortOrder = SortOrder.NotSorted)
        {
            List<TodoItem> completedItems = todoItems.Where(item => item.IsDone == true).ToList();
            return SortTodoItemByDescription(completedItems, sortOrder);
        }

        public List<TodoItem> GetIncompleteTodoItems(SortOrder sortOrder = SortOrder.NotSorted)
        {
            List<TodoItem> completedItems = todoItems.Where(item => item.IsDone == false).ToList();
            return SortTodoItemByDescription(completedItems, sortOrder);
        }

        public List<TodoItem> SearchTodoItems(string query, SortOrder sortOrder = SortOrder.NotSorted)
        {
            List<TodoItem> itemsThatMatchQuery = todoItems.Where(item => item.Description.ToLower().Contains(query.ToLower())).ToList();
            return SortTodoItemByDescription(itemsThatMatchQuery, sortOrder);
        }

        private bool HasItemID(int id)
        {
            return todoItems.Select(item => item.ID).ToList().Contains(id);
        }
        private List<TodoItem> SortTodoItemByDescription(List<TodoItem> todoItems, SortOrder sortOrder)
        {
            switch (sortOrder)
            {
                case SortOrder.Ascending:
                    return todoItems.OrderBy(t => t.Description, StringComparer.InvariantCultureIgnoreCase).ToList();
                case SortOrder.Descending:
                    return todoItems.OrderByDescending(t => t.Description, StringComparer.InvariantCultureIgnoreCase).ToList();
                default:
                    return todoItems;
            }
        }
    }

}

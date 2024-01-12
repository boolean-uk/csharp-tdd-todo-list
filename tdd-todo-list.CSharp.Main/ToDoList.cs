using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList 
    {
        public List<TodoItem> Items { get; private set; } = new List<TodoItem>();

        public int NextTaskId { get; set; } = 1; 

        public void AddTask(TodoItem item) 
        {
            item.Id = NextTaskId++;
            Items.Add(item);
        }

        public List<TodoItem> GetTask() 
        {
            return Items;
        }

        public TodoItem SearchTask(string taskname) 
        {
            return Items.FirstOrDefault(i => i.Title == taskname); 
        }

        public void RemoveTask(TodoItem item) 
        {
            Items.Remove(item);
        }

        public List<TodoItem> GetCompletedTasks() 
        {
            return Items.Where(i => i.IsCompleted).ToList();
        }

        public List<TodoItem> GetIncompleteTasks() 
        {
            return Items.Where(i => !i.IsCompleted).ToList();
        }

        public List<TodoItem> TasksAscendingOrder() 
        {
            return Items.OrderBy(i => i.Title).ToList();
        }

        public List<TodoItem> TasksDescendingOrder()
        {
            return Items.OrderByDescending(i => i.Title).ToList();
        }
    }
}
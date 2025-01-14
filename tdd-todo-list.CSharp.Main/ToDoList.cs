using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }

        public Task(int id, string description)
        {
            Id = id;
            Description = description;
            IsComplete = false;
        }

        public void ToggleStatus()
        {
            IsComplete = !IsComplete;
        }
    }
    public class TodoList
    {
        private List<Task> tasks = new List<Task>();
        private int nextId = 1;

        public void AddTask(string description)
        {
            tasks.Add(new Task(nextId++, description));
        }

        public void ShowTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("no tasks");
            }
            else
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine($"{task.Id}. {task.Description} - {task.IsComplete}");
                }
            }
        }
        public void RemoveTask(string description)
        {
            tasks.Remove
            Console.WriteLine("removed task");
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {


        public string Id { get; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public DateTime CreationTime { get; }

        public TodoListExtension(string id, string name)
        {
            Id = id;
            Name = name;
            IsComplete = false;
            CreationTime = DateTime.Now;
        }


        public Dictionary<string, TodoListExtension> tasks;

        public TodoListExtension()
        {
            tasks = new Dictionary<string, TodoListExtension>();
        }

        public void AddTask(string id, string name)
        {
            TodoListExtension task = new TodoListExtension(id, name);
            tasks.Add(id, task);
        }

        public TodoListExtension GetTaskById(string id)
        {
            if (tasks.ContainsKey(id))
            {
                return tasks[id];
            }
            return null;
        }

        public void UpdateTaskName(string id, string newName)
        {
            if (tasks.ContainsKey(id))
            {
                tasks[id].Name = newName;
            }
        }

        public void ChangeTaskStatus(string id, bool isComplete)
        {
            if (tasks.ContainsKey(id))
            {
                tasks[id].IsComplete = isComplete;
            }
        }

        public void PrintCreationTime(string id)
        {
            if (tasks.ContainsKey(id))
            {
                Console.WriteLine($"Task '{tasks[id].Name}' created at: {tasks[id].CreationTime}");

            }

        }





    }
}
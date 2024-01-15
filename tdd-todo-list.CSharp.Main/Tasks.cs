using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class CustomTask
    {

        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public CustomTask(string name, bool iscomplete)
        {
            Name = name;
            IsComplete = iscomplete;

        }
    }
    public class TodoList
    {
        public List<CustomTask> TaskList;
        public TodoList()
        {
            TaskList = new List<CustomTask>();
        }

        public void Add(CustomTask task)
        {
            TaskList.Add(task);
        }

        public String DisplayAllTasks()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Tasks:");
            foreach (var task in TaskList)
            {
                sb.AppendLine($"Name: {task.Name}");
            }

          
            return sb.ToString();
        }
        public void RemoveTask(CustomTask task)
        {
            TaskList.Remove(task);
        }

        public void ChangeStatus(CustomTask task)
        {
            task.IsComplete = !task.IsComplete;
        }

        public void DisplayCompleteTasks()
        {
            Console.WriteLine("Complete Tasks:");
            foreach (var task in TaskList)
            {
                if (task.IsComplete)
                {
                    Console.WriteLine($"Name: {task.Name}, Status: {task.IsComplete}");
                }
            }
        }
        public void DisplayIncompleteTasks()
        {
            Console.WriteLine("Not Completed Tasks:");
            foreach (var task in TaskList)
            {
                if (!task.IsComplete)
                {
                    Console.WriteLine($"Name: {task.Name}, Status: {task.IsComplete}");
                }
            }
        }

        public void DisplayTasksAscending()
        {
            var orderedTasks = TaskList.OrderBy(task => task.Name);

            Console.WriteLine("Tasks Ordered Alphabetically:");
            foreach (var task in orderedTasks)
            {
                Console.WriteLine($"Name: {task.Name}, Status: {task.IsComplete}");
            }
        }

        public void DisplayTasksDescending()
        {
            var orderedTasks = TaskList.OrderByDescending(task => task.Name);

            Console.WriteLine("Tasks Ordered Reverse:");
            foreach (var task in orderedTasks)
            {
                Console.WriteLine($"Name: {task.Name}, Status: {task.IsComplete}");
            }
        }

        public CustomTask SearchTaskByName(string taskName)
        {
            return TaskList.FirstOrDefault(task => task.Name.Equals(taskName, StringComparison.OrdinalIgnoreCase));
        }

    }
   


}

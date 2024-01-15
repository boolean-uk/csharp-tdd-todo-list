using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class CustomTaskExtension
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public DateTime CreatedAt { get; set; }

        public CustomTaskExtension(string name, bool isComplete)
        {
            Name = name;
            IsComplete = isComplete;
            CreatedAt = DateTime.Now;
        }
    }
public class TodoListExtension
    {
        public Dictionary<int, CustomTaskExtension> TaskDictionary;

        public TodoListExtension()
        {
            TaskDictionary = new Dictionary<int, CustomTaskExtension>();
        }

        public void AddTask(int taskId, CustomTaskExtension task)
        {
            TaskDictionary.Add(taskId, task);
        }

        public void UpdateTaskName(int taskId, string newName)
        {
            if (TaskDictionary.ContainsKey(taskId))
            {
                TaskDictionary[taskId].Name = newName;
            }
        }

        public void UpdateTaskStatus(int taskId, bool newStatus)
        {
            if (TaskDictionary.ContainsKey(taskId))
            {
                TaskDictionary[taskId].IsComplete = newStatus;
            }
        }

        public CustomTaskExtension GetTaskById(int taskId)
        {
            return TaskDictionary.ContainsKey(taskId) ? TaskDictionary[taskId] : null;
        }
        
        public void DisplayAllTasksExtension()
        {
            Console.WriteLine("Tasks:");
            foreach (var task in TaskDictionary.Values)
            {
                Console.WriteLine($"ID: {TaskDictionary.First(kvp => kvp.Value == task).Key}, Name: {task.Name}, Status: {(task.IsComplete ? "Complete" : "Not Complete")}, Created At: {task.CreatedAt}");
            }
        }
    }
}

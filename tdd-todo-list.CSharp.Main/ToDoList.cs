using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{

    public enum Priority
    {
        Low,
        Medium,
        High
    }
    public enum Category
    {
        Work,
        School,
        Life
    }

    public class ToDoList
    {
        private List<Task> tasks = new List<Task>();

        public void AddTask(string name, Priority priority, Category category)
        {
            var task = new Task(name, priority, category);
            tasks.Add(task);
        }

        public List<Task> GetAllTasks()
        {
            return tasks;
        }

        public List<Task> GetCompletedTasks()
        {
            return tasks.Where(x => x.IsComplete).ToList();
        }

        public List<Task> GetInCompletedTasks()
        {
            return tasks.Where(x => !x.IsComplete).ToList();
        }

        public List<Task> ChangeTaskStatus(Guid id, bool isComplete)
        {
            var task = tasks.Find(x => x.Id == id);
            if (task != null)
            {
                task.IsComplete = isComplete;
                task.CompletedAt = isComplete ? DateTime.Now : default;
            }
            return tasks;
        }

        public Task? SearchTask(string name)
        {
            return tasks.Find(x => x.Name == name);
        }

        public void RemoveTask(Guid id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
            }
        }

        public List<Task> GetTasksAscendingAZ()
        {
            return tasks.OrderBy(x => x.Name).ToList();
        }

        public List<Task> GetTasksDescendingAZ()
        {
            return tasks.OrderByDescending(x => x.Name).ToList();
        }

        public List<Task> GetTasksByPriority()
        {
            return tasks.OrderByDescending(x =>x.Priority).ToList();
        }

        public Task? GetTaskById(Guid id)
        {
            return tasks.Find(x => x.Id == id);
        }

        public void UpdateTaskName(Guid id, string newName)
        {
            var task = tasks.Find(x => x.Id == id);
            if ( task != null)
            {
                task.Name = newName;
            }
        }

        public void ChangeStatusById(Guid id, bool isComplete)
        {
            var task = tasks.Find(x => x.Id == id);
            if ( task != null)
            {
                task.IsComplete = isComplete;
                task.CompletedAt = isComplete ? DateTime.Now : default;
            }
        }

        public Task GetLongestCompletionTime()
        {
            return null;
        }

        public Task GetShortestCompletionTime()
        {
            return null;
        }

        public List<Task> GetTasksLongerThanDays(int days)
        {
            return null;
        }

        public List<Task> GetTasksByCategory(Category category)
        {
            return tasks.Where(x => x.Category == category).ToList();
        }
    }
}

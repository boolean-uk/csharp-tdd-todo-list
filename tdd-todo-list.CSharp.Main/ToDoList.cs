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
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public Task(int id, string name)
        {
            Id = id;
            Name = name;
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

        public void AddTask(string name)
        {
            tasks.Add(new Task(nextId++, name));
        }

        public List<string> ShowTasks()
        {
            if (tasks.Count == 0)
            {
                return new List<string> { "no tasks" };
            }

            return tasks.Select(task => $"{task.Id}. {task.Name} - {task.IsComplete}").ToList();
        }

        public string FindTask(string name)
        {
            var task = tasks.FirstOrDefault(task => task.Name == name);

            return task == null ? $"no task named: {name}" : $"{task.Name} - {task.IsComplete}";
        }

        public string RemoveTask(string name)
        {
            var taskToRemove = tasks.FirstOrDefault(task => task.Name == name);

            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
                return $"removed {name}";
            }
            else
            {
                return $"could not find: '{name}'";
            }
        }

        public bool ToggleStatus(string name)
        {
            var taskToChange = tasks.FirstOrDefault(task => task.Name == name);

            if (taskToChange != null)
            {
                taskToChange.ToggleStatus();
                return true;
            }
            return false;
        }

        public List<string> ShowComplete()
        {
            if (tasks.Count == 0)
            {
                return new List<string> { "no tasks" };
            }

            return tasks
                .Where(task => task.IsComplete)
                .Select(task => $"{task.Id}. {task.Name} - {task.IsComplete}")
                .ToList();
        }

        public List<string> ShowInComplete()
        {
            if (tasks.Count == 0)
            {
                return new List<string> { "no tasks" };
            }

            return tasks
                .Where(task => !task.IsComplete)
                .Select(task => $"{task.Id}. {task.Name} - {task.IsComplete}")
                .ToList();
        }

        public List<string> ShowAscending()
        {
            if (tasks.Count == 0)
            {
                return new List<string> { "no tasks" };
            }

            return tasks
                .OrderBy(t => t.Name)
                .Select(task => $"{task.Name}, {task.IsComplete}")
                .ToList();
        }

        public List<string> ShowDescending()
        {
            if (tasks.Count == 0)
            {
                return new List<string> { "no tasks" };
            }

            return tasks
                .OrderByDescending(t => t.Name)
                .Select(task => $"{task.Name}, {task.IsComplete}")
                .ToList();
        }
    }
}

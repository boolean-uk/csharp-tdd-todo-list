using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<TaskItem> _tasks;

        public TodoList()
        {
            _tasks = new List<TaskItem>();
        }

        public List<TaskItem> GetAllTasks() => _tasks;

        public void AddTask(string description, Priority priority = Priority.Medium)
        {
            TaskItem task = new TaskItem(description, priority);
            _tasks.Add(task);
        }

        public void RemoveTask(string description)
        {
            var task = _tasks.FirstOrDefault(t => t.GetDescription() == description);
            if (task != null) _tasks.Remove(task);
        }

        public void ChangeStatus(string description)
        {
            var task = _tasks.FirstOrDefault(t => t.GetDescription() == description);
            task?.SetStatus();
        }

        public List<TaskItem> GetOnlyCompletedTasks() =>
            _tasks.Where(t => t.GetStatus()).ToList();

        public List<TaskItem> GetOnlyIncompleteTasks() =>
            _tasks.Where(t => !t.GetStatus()).ToList();

        public string SearchForTask(string description)
        {
            var task = _tasks.FirstOrDefault(t => t.GetDescription() == description);
            return task != null ? task.GetDescription() : "Task not found";
        }

        public List<TaskItem> GetTasksSortedAscending() =>
            _tasks.OrderBy(t => t.GetDescription()).ToList();

        public List<TaskItem> GetTasksSortedDescending() =>
            _tasks.OrderByDescending(t => t.GetDescription()).ToList();

        public List<TaskItem> GetTasksByPriority(Priority priority) =>
            _tasks.Where(t => t.GetPriority() == priority).ToList();

        public List<TaskItem> GetAllTasksByPriority()
        {
            return _tasks.OrderBy(t => (int)t.GetPriority()).ToList();
        }

    }
}



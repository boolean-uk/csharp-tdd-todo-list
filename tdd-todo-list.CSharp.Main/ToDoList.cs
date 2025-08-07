using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<TaskItem> GetAllTasks()
        {
            return _tasks;
        }

        public void AddTask(string description, int priority = 2)
        {
            TaskItem task = new TaskItem(description, priority);
            _tasks.Add(task);
        }

        public void RemoveTask(string description)
        {
            TaskItem task = _tasks.FirstOrDefault(t => t.GetDescription() == description);
            if (task != null)
            {
                _tasks.Remove(task);
            }
        }

        public void ChangeStatus(string description)
        {
            TaskItem task = _tasks.FirstOrDefault(t => t.GetDescription() == description);
            if (task != null)
            {
                task.SetStatus();
            }
        }

        public List<TaskItem> GetOnlyCompletedTasks()
        {
            return _tasks.Where(t => t.GetStatus() == true).ToList();
        }

        public List<TaskItem> GetOnlyIncompleteTasks()
        {
            return _tasks.Where(t => t.GetStatus() == false).ToList();
        }

        public string SearchForTask(string description)
        {
            TaskItem task = _tasks.FirstOrDefault(t => t.GetDescription() == description);
            if (task != null)
            {
                return task.GetDescription();
            }
            return "Task not found";
        }

        public List<TaskItem> GetTasksSortedAscending()
        {
            return _tasks.OrderBy(t => t.GetDescription()).ToList();
        }

        public List<TaskItem> GetTasksSortedDescending()
        {
            return _tasks.OrderByDescending(t => t.GetDescription()).ToList();
        }

        public List<TaskItem> GetTasksByPriority(int priority)
        {
            return _tasks.Where(t => t.GetPriority() == priority).ToList();
        }
    }
}



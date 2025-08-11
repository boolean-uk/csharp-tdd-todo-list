using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private int _taskCounter = 0;
        private List<Task> _tasks = new List<Task>();

        public void addTask(string name, string description, TaskPriority priority, TaskCategory category)
        {
            _tasks.Add(new Task(_taskCounter++, name, description, TaskStatus.Incomplete, priority, category));
        }

        public Task? getTask(int id)
        {
            return _tasks.FirstOrDefault(t => t.uid.Equals(id));
        }

        public List<Task> getAllTasks()
        {
            return _tasks;
        }

        public List<Task> getAllTasks(bool ascending)
        {
            if (ascending)
            {
                return [.. _tasks.OrderBy(t => t.name)];
            }
            return [.. _tasks.OrderByDescending(t => t.name)];
        }

        public List<Task> getAllTasks(TaskStatus status)
        {
            return [.. _tasks.Where(t => t.status.Equals(status))];
        }

        public List<Task> getAllTasks(TaskCategory category)
        {
            return [.. _tasks.Where(t => t.category.Equals(category))];
        }

        public List<Task> getTasksLongerThan(TimeSpan timeDate)
        {
            return [.. _tasks.Where(t => t.timeDelta() > timeDate)];
        }

        public TimeSpan? getLargestTimeDelta()
        {
            TimeSpan? result = null;

            foreach (Task t in _tasks)
            {
                if (t.status != TaskStatus.Complete) continue;
                TimeSpan? d = t.timeDelta();
                if (d == null) continue;
                if (result == null || d > result) result = d;
            }

            return result;
        }

        public TimeSpan? getSmallestTimeDelta()
        {
            TimeSpan? result = null;

            foreach (Task t in _tasks)
            {
                if (t.status != TaskStatus.Complete) continue;
                TimeSpan? d = t.timeDelta();
                if (d == null) continue;
                if (result == null || d < result) result = d;
            }

            return result;
        }

        public bool setStatus(int id, TaskStatus status)
        {
            Task? t = _tasks.FirstOrDefault(t => t.uid.Equals(id));
            if (t == null) return false;
            t.setStatus(status);
            return true;
        }

        public bool setName(int id, string name)
        {
            Task? t = _tasks.FirstOrDefault(t => t.uid.Equals(id));
            if (t == null) return false;

            t.name = name;
            return true;


        }

        public Task findTask(string name)
        {
            Task? t = _tasks.FirstOrDefault(t => t.name.Equals(name));

            if (t != null)
            {
                return t;
            }

            throw new KeyNotFoundException($"No task with name \"{name}\"");
        }

        public bool removeTask(int id)
        {
            Task? t = _tasks.FirstOrDefault(t => t.uid.Equals(id));
            if (t == null) return false;
            return _tasks.Remove(t);
        }

        public override string ToString()
        {
            StringBuilder s = new();
            foreach (Task t in _tasks)
            {
                s.Append($"{t}");
            }

            return s.ToString();
        }
    }

    public class Task(int id, string name, string description, TaskStatus status, TaskPriority priority, TaskCategory category)
    {
        public int uid = id;
        public string name = name;
        public string description = description;
        public TaskStatus status = status;
        public TaskPriority priority = priority;
        public TaskCategory category = category;
        public DateTime created = DateTime.Now;
        public DateTime? completed = null;

        public TimeSpan? timeDelta()
        {
            if (completed == null) return DateTime.Now - created;

            return completed - created;
        }

        public void setStatus(TaskStatus newStatus)
        {
            this.status = newStatus;
            if (newStatus == TaskStatus.Complete)
            {
                this.completed = DateTime.Now;
            }
            else // Incomplete
            {
                this.completed = null;
            }
        }

        public override string ToString()
        {
            return $"{uid} | {category} | {status} | {(completed != null ? completed : "-")} | {created} | {priority} \n\tName: {name} \n\tDescriptions: {description}\n";
        }
    }

    public enum TaskPriority
    {
        Low,
        Medium,
        High,
        None
    }

    public enum TaskStatus
    {
        Complete,
        Incomplete
    }

    public enum TaskCategory
    {
        Study,
        Work,
        Admin
    }
}

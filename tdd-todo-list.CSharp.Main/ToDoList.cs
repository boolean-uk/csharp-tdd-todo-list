using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static tdd_todo_list.CSharp.Main.TodoList;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        private Dictionary<int, Task> _tasks;
        internal int _taskIdCount;

        public Dictionary<int, Task> Tasks { get { return _tasks; } }

        internal Task CreateTask(string name, bool complete = false, Priority priority = Priority.Undefined, string category = "")
        {
            _taskIdCount++;
            Task task = new Task(_taskIdCount, name, complete, priority, category);
            _tasks[task.Id] = task;
            return task;
        }

        public enum Priority
        {
            Undefined,
            Low,
            Medium,
            High
        }

        public class Task
        {
            public string Name { get; set; }
            public Priority Priority { get; set; }
            public int Id { get; }
            public bool Complete { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime CompletedAt { get; set; }
            public TimeSpan CompletionTime { get; set; }
            public string? Category { get; set; }

            public Task(int id, string name, bool complete = false, Priority priority = Priority.Undefined, string category = "")
            {
                Id = id;
                Name = name;
                Complete = complete;
                Priority = priority;
                CreatedAt = DateTime.Now;
                Category = category;
            }
        }

        public TodoList()
        {
            _tasks = new Dictionary<int, Task>();
        }

        // Sorted by completion time
        //public Task LongestTask { get { return _tasks.Values.Where(task => task.CreatedAt)} }

        public bool CompleteTask(int taskId)
        {
            if (_tasks.ContainsKey(taskId))
            {
                Task task = _tasks[taskId];
                task.Complete = true;
                task.CompletedAt = DateTime.Now;
                task.CompletionTime = task.CompletedAt - task.CreatedAt;
                return true;
            }
            return false;
        }

        public Task GetShortestTask()
        {
            int taskId = 0;
            double shortestDays = 0.0;
            foreach (var kvp in _tasks)
            {
                if (kvp.Value.Complete)
                {
                    TimeSpan timeUsed = kvp.Value.CompletedAt - kvp.Value.CreatedAt;
                    double totalDays = timeUsed.TotalDays;

                    if (totalDays < shortestDays)
                    {
                        shortestDays = totalDays;
                        taskId = kvp.Key;
                    }
                }
            }

            return _tasks[taskId];
        }

        public List<Task> GetTasksLongerThanFiveDays()
        {
            return _tasks.Values.Where(task => task.CompletionTime.TotalDays > 5).ToList();
        }


        public int Add(string name, bool complete = false, Priority priority = Priority.Undefined, string category = "")
        {
            Task task = CreateTask(name, complete, priority, category);
            return task.Id;
        }
        public bool Remove(int taskId)
        {
            return _tasks.Remove(taskId);
        }

        public List<Task> GetAll(bool complete = false, bool incomplete = false)
        {
            if (complete)
            {
                return _tasks.Where(kvp => kvp.Value.Complete).Select(kvp => kvp.Value).ToList();
            }
            else if (incomplete)
            {
                return _tasks.Where(kvp => !kvp.Value.Complete).Select(kvp => kvp.Value).ToList();
            }

            return _tasks.Values.ToList();
        }

        public bool ChangeStatus(int taskId)
        {
            if (_tasks.ContainsKey(taskId))
            {
                _tasks[taskId].Complete = !_tasks[taskId].Complete;
                return true;
            }
            return false;
        }

        public Task? GetTask(int taskId)
        {
            if (_tasks.ContainsKey(taskId))
            {
                return _tasks[taskId];
            }
            return null;
        }

        public Task? GetTask(string taskName)
        {
            foreach (var kvp in _tasks)
            {
                if (kvp.Value.Name == taskName)
                {
                    return kvp.Value;
                }
            }
            Console.WriteLine($"Task '{taskName}' not found.");
            return null;
        }

        public List<Task> GetSortedTasks(bool ascending = true)
        {
            if (ascending)
            {
                return _tasks.Values.OrderBy(t => t.Name).ToList();
            }
            return _tasks.Values.OrderByDescending(t => t.Name).ToList();
        }

        public bool SetTaskPriority(int taskId, Priority priority)
        {
            if (_tasks.ContainsKey(taskId))
            {
                _tasks[taskId].Priority = priority;
                return true;
            }
            return false;
        }

        public List<Task> GetTasksByPriority(Priority priority)
        {
            return _tasks.Where(kvp => kvp.Value.Priority == priority).Select(kvp => kvp.Value).ToList();
        }

        public List<Task> GetTasksByCategory(string category = "")
        {
            return _tasks.Values.Where(task => task.Category == category).ToList();
        }

        public bool SetTaskName(int taskId, string taskName)
        {
            if (_tasks.ContainsKey(taskId))
            {
                _tasks[taskId].Name = taskName;
                return true;
            }
            return false;
        }

        // Sorted priority member
        public List<Task> TasksByPriority { get { return _tasks.Values.OrderByDescending(task => task.Priority).ToList(); } }
        // Longest and shortest tasks
        public Task? LongestTask { get { return _tasks.Values.Where(task => task.Complete).MaxBy(task => task.CompletionTime); } }
        public Task? ShortestTask { get { return _tasks.Values.Where(task => task.Complete).MinBy(task => task.CompletionTime); } }
    }
}

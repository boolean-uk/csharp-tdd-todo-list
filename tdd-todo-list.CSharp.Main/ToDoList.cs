using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        private Dictionary<int, Task> _tasks;
        internal int _taskIdCount;

        public Dictionary<int, Task> Tasks { get { return _tasks; } }

        internal Task CreateTask(string name, bool complete = false, int priority = 0, string category = "")
        {
            _taskIdCount++;
            Task task = new Task(_taskIdCount, name, complete, priority, category);
            _tasks[task.Id] = task;
            return task;
        }

        public class Task
        {
            public string Name { get; set; }
            public int Priority { get; set; }
            public int Id { get; }
            public bool Complete { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime CompletedAt { get; set; }
            public string? Category { get; set; }

            public Task(int id, string name, bool complete = false, int priority = 0, string category = "")
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
            throw new NotImplementedException();
        }

        public Task GetTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public Task GetTask(string taskName)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetTasksByPriority(string priority)
        {
            throw new NotImplementedException();
        }

        public int Add(string name)
        {
            Task task = CreateTask(name);
            return task.Id;
        }
        public bool Remove(int taskId)
        {
            return _tasks.Remove(taskId);
        }

        public bool SetTaskPriority(int taskId, int priority)
        {
            return true;
        }

        public List<Task> GetTasksByCategory(string category = "")
        {
            throw new NotImplementedException();
        }

        public List<Task> GetSortedTasks(bool ascending = true)
        {
            throw new NotImplementedException();
        }
    }
}

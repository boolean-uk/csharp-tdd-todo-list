using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<int, Task> _tasks;
        private int _nextId;
        public TodoList() 
        {
            _tasks = new Dictionary<int, Task>();
            _nextId = 0;
        }

        public int AddTask(Task task)
        {
            _nextId++;
            _tasks.Add(_nextId, task);
            return _nextId;
        }

        public bool RemoveTask(int id) 
        {
            return _tasks.Remove(id);
        }

        public Task GetTask(string taskName)
        {
            return _tasks.Where(x => x.Value.TaskName == taskName)
                        .FirstOrDefault().Value;
        }


        public Dictionary<int, Task> GetTasks() 
        {
            return _tasks;
        }

        public Dictionary<int, Task> GetCompleteTasks()
        {
            return _tasks.Where(x => x.Value.Status == "Complete")
                        .ToDictionary(x => x.Key, x => x.Value);
        }

        public Dictionary<int, Task> GetIncompleteTasks()
        {
            return _tasks.Where(x => x.Value.Status == "Incomplete")
                        .ToDictionary(x => x.Key, x => x.Value);
        }

        public string FindTask(string taskName)
        {
            Task task = GetTask(taskName);
            if (task != null)
            {
                return "Found task";
            }
            return "Task not found";
        }

        public Dictionary<int, Task> GetOrdered(bool ascending)
        {
            if (ascending)
            {
                return _tasks.OrderBy(x => x.Value.TaskName)
                            .ToDictionary(x => x.Key, x => x.Value);
            }
            else
            {
                return _tasks.OrderByDescending(x => x.Value.TaskName)
                            .ToDictionary(x => x.Key, x => x.Value);
            }
        }

    }
}

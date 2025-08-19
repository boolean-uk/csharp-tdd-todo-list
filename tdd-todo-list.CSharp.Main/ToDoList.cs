using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<Task> _tasks = new List<Task>();
        
        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }

        public List<Task> ListTasks()
        {
            return _tasks;
        }

        public void SetTaskStatus(string name, TaskStatus status)
        {
            foreach (Task task in _tasks)
            {
                if (task.Name == name)
                {
                    task.Status = status;
                    break;
                }
            }
        }

        public List<Task> ListCompletedTasks()
        {
            return _tasks.FindAll(task => task.Status == TaskStatus.Complete);
        }

        public List<Task> ListIncompleteTasks()
        {
            return _tasks.FindAll(task => task.Status == TaskStatus.Incomplete);
        }

        public Task? FindTask(string name)
        {
            Task? task = _tasks.Find(task => task.Name == name );
            if (task == null)
            {
                Console.WriteLine($"Could not find task with name: {name}!");
            }

            return task;
        }

        public void RemoveTask(string name)
        {
            int index = _tasks.FindIndex(task => task.Name == name);
            if (index != -1)
            {
                _tasks.RemoveAt(index);
            }
        }

        public List<Task> ListTasksAlphabeticallyOrderedByAscending()
        {
            return _tasks.OrderBy(task => task.Name).ToList();
        }

        public List<Task> ListTasksAlphabeticallyOrderedByDescending()
        {
            return _tasks.OrderByDescending(task => task.Name).ToList();
        }

        public void SetTaskPriority(string name, TaskPriority priority)
        {
            Task? task = _tasks.Find(task => task.Name == name);
            if (task != null)
            {
                task.Priority = priority;
            }
            else
            {
                Console.WriteLine($"Could not find task with name: {name}!");
            }
        }

        public List<Task> ListTasksByPriority()
        {
            return _tasks.OrderByDescending(task => task.Priority).ToList();
        }
    }
}

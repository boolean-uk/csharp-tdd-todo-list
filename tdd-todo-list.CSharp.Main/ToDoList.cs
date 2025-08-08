using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<int, Task> _tasks = new Dictionary<int, Task>();
        private int _taskCount = 0;

        public Dictionary<int, Task> Tasks { get { return _tasks; } }
        public int TaskCount { get { return _taskCount; } }

        public void AddTask(string name)
        {
            Task newTask = new Task(_taskCount, name);
            _tasks.Add(_taskCount, newTask);
            _taskCount++;
        }

        public bool ToggleComplete(string taskName)
        {
            Task? task = GetTaskByName(taskName);
            if (task != null) { 
                task.IsCompleted = !task.IsCompleted;
                task.TimeCompleted = DateTime.Today;
                return true;
            }
            return false;
        }

        public List<Task> GetCompleteTasks()
        {
            List<Task> completeTasks = new List<Task>();
            foreach (Task task in _tasks.Values) {
                if (task.IsCompleted)
                {
                    completeTasks.Add(task);
                }
            }
            return completeTasks;
        }

        public List<Task> GetIncompleteTasks()
        {
            List<Task> incompleteTasks = new List<Task>();
            foreach (Task task in _tasks.Values)
            {
                if (!task.IsCompleted)
                {
                    incompleteTasks.Add(task);
                }
            }
            return incompleteTasks;
        }

        public Task? GetTaskByName(string taskName)
        {
            Task? resultTask = null;
            foreach (KeyValuePair<int, Task> task in _tasks)
            {
                if (task.Value.Name == taskName)
                {
                    resultTask = task.Value;
                    break;
                }
            }

            if (resultTask == null)
            {
                Console.WriteLine($"Task {taskName} not found");
            }

            return resultTask;
        }

        public bool RemoveTask(string taskName)
        {
            Task? task = GetTaskByName(taskName);

            if (task == null)
            {
                return false;
            }

            return _tasks.Remove(task.ID);

        }

        public List<Task> GetAllTasksSortedByName(bool useAscendingOrder)
        {
            if (useAscendingOrder)
            {
                return _tasks.Values.OrderBy(task => task.Name).ToList();
            }
            return _tasks.Values.OrderByDescending(task => task.Name).ToList();
     
        }

        public bool GiveTaskPriority(string taskName, int priority)
        {
            Task? task = GetTaskByName(taskName);
            if (task == null)
            {
                return false;
            }
            task.Priority = priority;
            return true;
        }

        public List<Task> SortTasksByPriority()
        {
            return _tasks.Values.OrderBy(task => task.Priority).ToList();
        }

        public Task? GetTaskByID(int taskID)
        {
            if (_tasks.ContainsKey(taskID))
            {
                return _tasks[taskID];
            }
            return null;
        }

        public bool UpdateTaskName(int taskID, string newName)
        {
            if (_tasks.ContainsKey(taskID))
            {
                _tasks[taskID].Name = newName;
                return true;
            }
            return false;
        }

        public bool UpdateTaskStatus(int taskID)
        {
            if (_tasks.ContainsKey(taskID))
            {
                _tasks[taskID].IsCompleted = !_tasks[taskID].IsCompleted;
                return true;
            }
            return false;
        }

        public List<(Task, DateTime)> GetAllTaskTimeCreated()
        {
            List<(Task, DateTime)> timeCreatedList = new List<(Task, DateTime)> ();
            foreach (Task task in _tasks.Values)
            {
                timeCreatedList.Add((task, task.TimeCreated));
            }
            return timeCreatedList;
        }

        public List<(Task, DateTime)> GetAllTaskTimeCompleted()
        {
            List<(Task, DateTime)> timeCompletedList = new List<(Task, DateTime)> ();
            foreach (Task task in _tasks.Values)
            {
                if (task.IsCompleted)
                {
                    timeCompletedList.Add((task, task.TimeCompleted));
                }
            }
            return timeCompletedList;
        }

        public Task GetTaskWithLongestCompletionTime()
        {
            int longestCompletionTime = 0;
            Task? longestCompletionTask = null;
            List<(Task, DateTime)> completedTaskList = GetAllTaskTimeCompleted();
            foreach ((Task, DateTime) listItem in completedTaskList)
            {
                Task task = listItem.Item1;
                if (task.CompletionTime == null)
                {
                    task.CalculateCompletionTime();
                }
                if (task.CompletionTime > longestCompletionTime)
                {
                    longestCompletionTime = (int)task.CompletionTime;
                    longestCompletionTask = task;
                }

            }
            return longestCompletionTask!;

        }

        public Task GetTaskWithShortestCompletionTime()
        {
            // Assuming no completion times will exceed 100 days
            int shortestCompletionTime = 100;
            Task? shortestCompletionTask = null;
            List<(Task, DateTime)> completedTaskList = GetAllTaskTimeCompleted();
            foreach ((Task, DateTime) listItem in completedTaskList)
            {
                Task task = listItem.Item1;
                if (task.CompletionTime == null)
                {
                    task.CalculateCompletionTime();
                }
                if (task.CompletionTime < shortestCompletionTime)
                {
                    shortestCompletionTime = (int)task.CompletionTime;
                    shortestCompletionTask = task;
                }

            }
            return shortestCompletionTask!;
        }

        public List<Task> GetTasksByCompletionTime(int daysLimit)
        {
            List<Task> tasks = new List<Task>();
            List<(Task, DateTime)> completedTaskList = GetAllTaskTimeCompleted();
            foreach ((Task, DateTime) listItem in completedTaskList)
            {
                Task task = listItem.Item1;
                if (task.CompletionTime == null)
                {
                    task.CalculateCompletionTime();
                }
                if (task.CompletionTime > daysLimit)
                {
                    tasks.Add(task);
                }
            }
            return tasks;

        }

        public bool SetTaskCategory(string taskName, string category)
        {
            Task task = GetTaskByName(taskName);

            if (task == null) { 
                return false;
            }

            task.Category = category;
            return true;

        }
    }
}

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

        public void ToggleComplete(int taskID)
        {
            _tasks[taskID].IsCompleted = !_tasks[taskID].IsCompleted;
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
    }
}

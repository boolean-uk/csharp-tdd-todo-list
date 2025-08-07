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
    }
}

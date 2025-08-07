using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoObject
    {
        private readonly int id;
        public string TaskStr { get; set; } = " ";
        public string Priority { get; set; } = " ";
        public bool Completed { get; set; } = false;

        public TodoObject(int id, string taskStr) 
        {
            this.id = id;
            this.TaskStr = taskStr;
        }

        public TodoObject(int id,string taskStr, string priority)
        {
            this.id = id;
            this.TaskStr = taskStr;
            this.Priority = priority;
        }
    }

    public class TodoList
    {
        private int _UNIQUE_IDS = 0;
        public Dictionary<int, TodoObject> Todo = new Dictionary<int, TodoObject>();

        public void Add(string task)
        {
            TodoObject newTask = new TodoObject(_UNIQUE_IDS, task);
            Todo[_UNIQUE_IDS] = newTask;
            _UNIQUE_IDS++;
        }
    }
}

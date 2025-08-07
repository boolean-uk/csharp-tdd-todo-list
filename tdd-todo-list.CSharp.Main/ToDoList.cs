using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    internal class TodoObject
    {
        public string TaskStr { get; set; } = " ";
        public string Priority { get; set; } = " ";
        public bool Completed { get; set; } = false;

        public TodoObject(string taskStr) 
        { 
            this.TaskStr = taskStr;
        }

        public TodoObject(string taskStr, string priority)
        {
            this.TaskStr = taskStr;
            this.Priority = priority;
        }
    }

    public class TodoList
    {
        private Dictionary<string, TodoObject> _todo = new Dictionary<string, TodoObject>();


    }
}

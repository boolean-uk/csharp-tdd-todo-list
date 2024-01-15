using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> todoList = new Dictionary<string, bool>();
        
        public TodoList() { }

        public bool AddTask(string task)
        {
            if (!todoList.ContainsKey(task) && task != "") {
                todoList.Add(task, false);
                return true;
            }
            return false;
        }
        public Dictionary<string, bool> GetList() 
        {
            if (todoList.Count > 0)
            {
                return todoList;
            }
            return null;
        }
    }
}

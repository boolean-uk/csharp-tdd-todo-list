using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _todoList = new Dictionary<string, bool>();
        public bool Add(string task)
        {
            //I assume a task is initially not completed
            _todoList.Add(task, false);
            return true;
        }
    }
}

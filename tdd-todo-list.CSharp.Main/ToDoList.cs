using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string,string> _ToDoList;

        public Dictionary<string, string> ToDoList { get => _ToDoList;  }

        public bool Add(string task)
        {
            throw new NotImplementedException();
        }
    }
}

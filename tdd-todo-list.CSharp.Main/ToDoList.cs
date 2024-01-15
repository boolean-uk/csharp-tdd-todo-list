using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _toDoList = new Dictionary<string, bool>();
        public TodoList() { }
        public bool Add(string s, bool b)
        {
            if (!_toDoList.ContainsKey(s))
            {
                _toDoList.Add(s, b);
                return true;
            }
            return false;
        }

        public int PrintTasks()
        {
            foreach (var item in _toDoList)
            {
                Console.WriteLine($"Task: {item.Key}, Complete?: {item.Value}");
            }
            return _toDoList.Count();
        }

        public int PrintComplete()
        {
            return 0;
        }
    }
}

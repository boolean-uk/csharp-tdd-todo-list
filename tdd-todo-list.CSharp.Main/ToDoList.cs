using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private SortedDictionary<string, bool> _todoList = new SortedDictionary<string, bool>();
        private int _count = 0; // Added as an extra example for properties

        public void add(string task, bool status)
        {
            _todoList.Add(task, status);
            _count = _todoList.Count;
        }

        public void change(string task, bool status)
        {
            throw new NotImplementedException();
        }

        public SortedDictionary<string, bool> Todo { get { return _todoList; } }

        public int Count { get { return _count; } } // getter property for count
    }
}



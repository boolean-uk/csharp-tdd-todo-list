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

        public void changeStatus(string task)
        {
            _todoList[task] = !_todoList[task];
        }

        public List<string> getIncomplete()
        {
            List<string> result = new List<string>();
            result = _todoList.Where(pair => pair.Value.Equals(false)).Select(pair => pair.Key).ToList();
            return result;
        }

        public List<string> getComplete()
        {
            List<string> result = new List<string>();
            result = _todoList.Where(pair => pair.Value.Equals(true)).Select(pair => pair.Key).ToList();
            return result;
        }

        public string getTask(string task)
        {
            throw new NotImplementedException();
        }

        public SortedDictionary<string, bool> Todo { get { return _todoList; } }

        public int Count { get { return _count; } } // getter property for count
    }
}



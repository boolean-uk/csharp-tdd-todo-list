using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Main
{
    // Overcomplicated todo list that stores an ascending and descending SortedDictionary,
    // and points a todolist variable to one of them
    public class TodoList
    {
        private SortedDictionary<string, bool> _todoList;
        private SortedDictionary<string, bool> _ascending;
        private SortedDictionary<string, bool> _descending;
        private int _count = 0; // Added as an extra example for properties

        // A class to create a descending comparer
        private class DescendingComparer<T> : IComparer<T> where T : IComparable<T>
        {
            public int Compare(T x, T y) { return y.CompareTo(x); }
        }

        public TodoList()
        {
            _ascending = new SortedDictionary<string, bool>();
            _descending = new SortedDictionary<string, bool>(new DescendingComparer<string>());

            _todoList = _ascending;
        }

        public void add(string task, bool status)
        {
            _ascending.Add(task, status);
            _descending.Add(task, status);
            _count = _todoList.Count;
        }

        public void changeStatus(string task)
        {
            _ascending[task] = !_ascending[task];
            _descending[task] = !_descending[task];

        }

        public string getTask(string task)
        {
            if (_todoList.ContainsKey(task))
            {
                return task;
            }
            return "not found";
        }

        public string remove(string task)
        {
            if ( _todoList.ContainsKey(task))
            {
                _ascending.Remove(task);
                _descending.Remove(task);
                return task;
            }
            return "not found";
        }

        public SortedDictionary<string, bool> ascending()
        {
            _todoList = _ascending;
            return _todoList;
        }

        public SortedDictionary<string, bool> descending()
        {
            _todoList = _descending;
            return _todoList;
        }

        public SortedDictionary<string, bool> Todo { get { return _todoList; } }

        public int Count { get { return _count; } } // getter property for count

        public List<string> Incomplete
        {
            get {
                List<string> result = new List<string>();
                result = _todoList.Where(pair => pair.Value.Equals(false)).Select(pair => pair.Key).ToList();
                return result;
            }
        }

        public List<string> Complete
        {
            get {
                List<string> result = new List<string>();
                result = _todoList.Where(pair => pair.Value.Equals(true)).Select(pair => pair.Key).ToList();
                return result;
            }
        }
    }
}



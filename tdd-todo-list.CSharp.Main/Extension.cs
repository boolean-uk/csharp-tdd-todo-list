using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        // Using a tuple for storing data (which is not easily modifiable... classes soon surely...)
        // Dictionary<int, Task> _todoList (the dream...)

        private Dictionary<int, (string, bool, DateTime)> _todoList;
        public TodoListExtension()
        {
            _todoList = new Dictionary<int, (string, bool, DateTime)>();
        }

        public bool add(int id, string task, bool status, DateTime dateTime)
        {
            if (_todoList.ContainsKey(id)) return false;
            _todoList.Add(id, (task, status, dateTime));
            return true;
        }

        public void changeStatus(int id)
        {
            var tuple = (_todoList[id].Item1, !_todoList[id].Item2, _todoList[id].Item3);
            _todoList[id] = tuple;
        }

        public (string, bool, DateTime) getTask(int id)
        {
            return _todoList[id];
        }

        public void updateTask(int id, string v)
        {
            var tuple = (v, _todoList[id].Item2, _todoList[id].Item3);
            _todoList[id] = tuple;
        }

        public DateTime taskCreated(int id)
        {
            return _todoList[id].Item3;
        }
    }
}

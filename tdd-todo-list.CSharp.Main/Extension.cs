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
        Dictionary<int, (string, bool, DateTime)> _todoList;
        public TodoListExtension()
        {
            _todoList = new Dictionary<int, (string, bool, DateTime)>();
        }

        public void add(int id, string task, bool status, DateTime dateTime)
        {
            _todoList.Add(id, (task, status, dateTime));
        }

        public void changeStatus(int id)
        {
            throw new NotImplementedException();
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
    }
}

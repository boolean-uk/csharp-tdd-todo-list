using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        // Could use another dictionary within the dictionary, but that sounds like extra work!
        // so we're using a tuple instead
        Dictionary<int, (string, bool, DateTime)> _todoList;
        public TodoListExtension()
        {
            _todoList = new Dictionary<int, (string, bool, DateTime)>();
        }

        public void add(int id, string task, bool status, DateTime dateTime)
        {
            _todoList.Add(id, (task, status, dateTime));
        }

        public (string, bool, DateTime) getTask(int id)
        {
            return _todoList[id];
        }

        public void updateTask(int id, string v)
        {
            throw new NotImplementedException();
        }
    }
}

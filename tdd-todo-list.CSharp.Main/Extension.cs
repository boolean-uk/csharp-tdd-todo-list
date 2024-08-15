using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {

        private Dictionary<int, TaskItem> _toDoList = new Dictionary<int, TaskItem>();

        public Dictionary<int, TaskItem> List { get { return _toDoList; } }



        public TodoListExtension() { }

        public string GetTask(int v)
        {
            throw new NotImplementedException();
        }

        public List<TaskItem> UpdateName(int id, string name)
        {
            throw new NotImplementedException();
        }

        public Status ChangeStatus(int v)
        {
            throw new NotImplementedException();
        }
    }
}

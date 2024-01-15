using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        Dictionary<string, ToDoItem> _items = new Dictionary<string, ToDoItem>();

        public bool Add(string task, out string ID) 
        {
            throw new NotImplementedException();
        }

        public ToDoItem RetrieveTask(string ID) 
        {
            throw new NotImplementedException();
        }

        public bool UpdateTaskName(string ID, string newName) 
        {
            throw new NotImplementedException();
        }

        public bool ChangeTaskStatus(string ID) 
        {
            throw new NotImplementedException();
        }

        public void RetrieveTaskDate() 
        {
            throw new NotImplementedException();
        }
    }
}

using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private TodoList _toDoList = new TodoList();
        

        public Task GetTask(int id)
        {
            Task task1 = null;
            foreach (Task task in _toDoList.ToDoList)
            {
                if (task.Id == id)
                {
                   task1 = task;
                }
            }
            return task1;
        }

        public Task UpdateName(int id, string name)
        {
            Task task = GetTask(id);
            task.Name = name;

            return task;
        }

        public Task ChangeStatus(int id)
        {
            _toDoList.ChangeStatus(GetTask(id).Name);
            return GetTask(id);
        }

        public TodoList ToDoList { get { return _toDoList; }}
    }
}

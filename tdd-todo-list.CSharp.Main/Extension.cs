using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

        public TaskItem GetTask(int id)
        {

            return _toDoList[id];

        }

        public TaskItem UpdateName(int id, string name)
        {

            _toDoList[id].Task = name;

            return _toDoList[id];
        }

        public Status ChangeStatus(int id)
        {

            if (_toDoList[id].Status == Status.COMPLETE)
            {
                _toDoList[id].Status = Status.INCOMPLETE;

            }
            else if (_toDoList[id].Status == Status.INCOMPLETE)
            {

                _toDoList[id].Status = Status.COMPLETE;

            }

            return _toDoList[id].Status;
        }


        public bool AddTask(int id, TaskItem task)
        {
            if (!_toDoList.ContainsKey(id))
            {
                _toDoList.Add(id, task);
                return true;

            }
            return false;
        }

    }  
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class ToDoTask
    {

        private int _ID;
        private string _name;
        private bool _done;
        private int _priority;


        public ToDoTask(string task, int id, bool done = false, int priority=0)
        {
            _name = task;
            _ID = id;
            _priority = priority;
            _done = done;
        }

        public void ChangeStatus(bool status)
        {
            _done = status;
        }

        public void ChangePriority(int priority)
        {
            _priority = priority;
        }

        public bool getStatus() { return _done; }

        public string getName() { return _name; }

        public int getPriority() { return _priority; }

        public void setName(string name) { _name = name; }

        public void setStatus(bool status) { _done = status; }
    }
}

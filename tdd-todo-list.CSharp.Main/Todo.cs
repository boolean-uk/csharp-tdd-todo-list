using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Todo
    {
        private string _task;
        private int _id;
        private bool _complete;

        public Todo(string task, int id)
        {
            _task = task;
            _id = id;
            _complete = false;
        }

        public bool Complete
        {
            get { return _complete; } 
            set { _complete = value; }
        }

        public int id { get { return _id; } }

        public string task { get { return _task; } }

    }
}

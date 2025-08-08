using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        private int _id = 0;
        private string _name;
        private bool _status = false;
        private Priority _priority = Priority.low;

        public Task(string name) 
        {
            _id = _id + 1;
            _name = name;
        }

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }

        public bool Status { get { return _status; } set { _status = value; } }

        public Priority Priority { get { return _priority; } set { _priority = value; } }
    }
}

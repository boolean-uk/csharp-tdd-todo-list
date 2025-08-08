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
        private Category _category;

        public Task(string name) 
        {
            _name = name;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }

        public bool Status { get { return _status; } set { _status = value; } }

        public Priority Priority { get { return _priority; } set { _priority = value; } }
        public Category Category { get { return _category; } set { _category = value; } }
    }
}

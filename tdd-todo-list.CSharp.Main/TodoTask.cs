using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
{
        private bool _complete = false;
        private string _name;
        private string _description;

        public TodoTask(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public void ToggleComplete()
        {
            _complete = !_complete;
        }

        public bool Complete { get { return _complete; } set { _complete = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }

    }
}

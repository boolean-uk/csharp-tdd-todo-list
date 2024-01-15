using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
{
        private string _description;
        private bool _completed;

        public Task(string description, bool completed)
        {
            _description = description;
            _completed = completed;
        }

        public string description { get { return _description; } set { _description = value; } }
        public bool completed { get { return _completed; } set { _completed = value; }  }
    }
}

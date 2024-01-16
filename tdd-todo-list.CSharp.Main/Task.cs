using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        string _name;
        bool _isComplete;

        public string Name { get => _name; set => _name = value; }
        public bool Completed { get => _isComplete; set => _isComplete = value; }
        public Task(string name) { 
            _name = name;
            _isComplete = false;
        }


    }
}

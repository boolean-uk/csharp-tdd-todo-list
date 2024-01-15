using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class PTask
    {
        public PTask(string name, bool isComplete = false)
        {
            _name = name;
            _isComplete = isComplete;
        }

        private string _name;
        private bool _isComplete;

        public string Name { get => _name; set => _name = value; }
        public bool IsComplete { get => _isComplete; set => _isComplete = value; }
    }
}

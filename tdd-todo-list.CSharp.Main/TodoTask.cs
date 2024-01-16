using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        private string _description;
        private bool _isCompleted;


        public TodoTask(string description)
        {
            _description = description;
            _isCompleted = false;
        }

        public void Complete()
        {
            _isCompleted = true;
        }
        public void Incomplete()
        {
            _isCompleted = false;
        }
        public bool IsCompleted { get { return _isCompleted; } }

        public string Description { get { return _description; } }

        public override string ToString()
        {
            if (IsCompleted) return $"[\u2713] {Description}";
            return $"[  ] {Description}";
        }

    }
}

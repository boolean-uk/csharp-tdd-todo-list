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
        private bool _isDone;


        public TodoTask(string description)
        {
            _description = description;
            _isDone = false;
        }

        public void MarkDone()
        {
            _isDone = true;
        }
        public void MarkUndone()
        {
            _isDone = false;
        }
        public bool IsDone { get { return _isDone; } }

        public string Description { get { return _description; } }

        public override string ToString()
        {
            if (IsDone) return $"[\u2713] {Description}";
            return $"[  ] {Description}";
        }

    }
}

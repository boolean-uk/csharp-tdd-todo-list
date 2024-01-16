using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class ToDoTask
    {
        private string _name;
        private bool _isComplete;

        public ToDoTask(string name, bool isComplete)
        {
            Name = name;
            IsComplete = isComplete;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public bool IsComplete { get { return _isComplete; } set { _isComplete = value; } }

        public void ChangeStatus()
        {
            if (IsComplete)
            {
                IsComplete = false;
            } if (!IsComplete)
            {
                IsComplete = true;
            }
        }
    }
}

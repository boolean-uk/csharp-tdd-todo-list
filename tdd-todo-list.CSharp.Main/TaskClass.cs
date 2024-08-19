using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskClass
    {
        
        private string _task;
        private bool _isComplete = false;

        public TaskClass(string TaskMessage)
        {
            this._task = TaskMessage;
        }


        public void ChangeStatus()
        {
            _isComplete = !IsComplete;
        }

        public bool IsComplete { get => _isComplete; }
        public string Task { get => _task; }
    }
}

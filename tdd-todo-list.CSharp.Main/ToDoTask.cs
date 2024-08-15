using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        private string _taskName;
        private Status _status;

        public TodoTask(string taskName) 
        {
            this._taskName = taskName;
            this._status = Status.Incomplete;
        }

        public string Taskname { get => _taskName; set => _taskName = value; }
        public Status Status { get => _status; set => _status = value; }


    }
}

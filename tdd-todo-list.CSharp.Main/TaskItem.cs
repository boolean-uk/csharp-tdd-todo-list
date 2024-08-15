using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskItem
    {
        private string _task;
        private Status _status;

        public string Task { get; set; }
        public Status Status { get; set; }
            //time and date

        public TaskItem() { }

        public TaskItem(string task, Status status)
        {
            this._task = task;
            this._status = status;
        }
    }
}

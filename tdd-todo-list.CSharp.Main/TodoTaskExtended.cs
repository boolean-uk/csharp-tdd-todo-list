using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTaskExtended
    {
        
            private string _taskName;
            private Status _status;
            private DateTime _dateTime;
            private int _id;

            public TodoTaskExtended(string taskName, int id)
            {
                this._taskName = taskName;
                this._status = Status.Incomplete;
                this._dateTime = DateTime.Now;
                this._id = id;
            }
            public TodoTaskExtended(string taskName, Status s, int id)
            {
                this._taskName = taskName;
                this._status = s;
                this._dateTime = DateTime.Now;
                this._id = id;
            }

            public string Taskname { get => _taskName; set => _taskName = value; }
            public Status Status { get => _status; set => _status = value; }
            public DateTime Datetime { get => _dateTime; set => _dateTime = value; }
            public int Id { get => _id; set => _id = value; }

        
    }
}

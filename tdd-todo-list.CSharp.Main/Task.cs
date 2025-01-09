using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        private string _taskName;
        private string _status;
        private DateTime _dateCreated;

        public Task(string taskName) 
        {
            _taskName = taskName;
            _status = "Incomplete";
            _dateCreated = DateTime.Now;
        }

        public string TaskName { set { _taskName = value; } get { return _taskName; } }

        public string Status { set { _status = value; } get { return _status; } }

        public DateTime GetDateTime { get { return _dateCreated; } }
    }
}

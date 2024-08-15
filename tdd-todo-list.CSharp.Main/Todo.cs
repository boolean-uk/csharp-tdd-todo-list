using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Todo
    {
        private string _task;
        private int _id;
        private bool _complete;
        private DateTime _dateOfCreation;
        private TimeSpan _timeOfCreation;

        public Todo(string task, int id)
        {
            _task = task;
            _id = id;
            _complete = false;
            _dateOfCreation = DateTime.Now;
            _timeOfCreation = new TimeSpan(36, 0, 0, 0);
            _dateOfCreation = _dateOfCreation.Add(_timeOfCreation);
        }

        public bool Complete
        {
            get { return _complete; } 
            set { _complete = value; }
        }

        public int id { get { return _id; } }

        public string task 
        { 
            get { return _task; } 
            set { _task = value; }
        }

        public DateTime DateOfCreation { get { return _dateOfCreation; } }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class ToDoTask
    {

        private int _ID;
        private string _name;
        private bool _done;
        private int _priority;
        private DateTime _created;
        private DateTime _finished;
        private Type _typeOfTask;
        private TimeSpan? _timeToCompletion = null;

        public ToDoTask(string task, int id, bool done = false, int priority = 0)
        {
            _name = task;
            _ID = id;
            _priority = priority;
            _done = done;
            _created = DateTime.Now;
            _typeOfTask = Type.Standard;
        }

        public ToDoTask(string task, int id, Type type)
        {
            _name = task;
            _ID = id;
            _priority = 0;
            _done = false;
            _created = DateTime.Now;
            _typeOfTask = type;
        }

        public void ChangeStatus(bool status)
        {
            _done = status;
        }

        public void ChangePriority(int priority)
        {
            _priority = priority;
        }

        public bool Status { get { return _done; } set { _done = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int getPriority() { return _priority; }

        public DateTime TimeCreated { get { return _created; } }
        public DateTime TimeFinished { get { return _finished; } }

        public void markAsFinished() { _finished = DateTime.Now; _timeToCompletion = _finished.Subtract(_created); }
        public Type TypeOfTask { get { return _typeOfTask; } set { _typeOfTask = value; } }
        public TimeSpan? TimeSpan { get { return _timeToCompletion is null ? DateTime.Now.Subtract(_created) : _timeToCompletion; }
        }
    }
}

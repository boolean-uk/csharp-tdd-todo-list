using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class ToDoTask
    {
        private int _id;
        private string _name;
        private bool _isComplete;
        private DateTime _dateTime;

        public ToDoTask(string name, bool isComplete)
        {
            Name = name;
            IsComplete = isComplete;
            _dateTime = DateTime.Now;

        }
        public ToDoTask(int id, string name, bool isComplete)
        {
            _id = id;
            Name = name;
            IsComplete = isComplete;
            _dateTime = DateTime.Now;

        }

        public int id { get { return _id; } }
        public string Name { get { return _name; } set { _name = value; } }
        public bool IsComplete { get { return _isComplete; } set { _isComplete = value; } }
        public DateTime dateTime { get { return _dateTime; } }//extension


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

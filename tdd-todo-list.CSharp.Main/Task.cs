using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        private string _name;
        private int _id;
        private bool _isCompleted = false;
        private int _priority = 3;
        private string _category = String.Empty;
        private DateTime _timeCreated;
        private DateTime _timeCompleted;
        private int? _completionTime = null;

        public Task(int count, string name)
        {
            _id = count;
            _name = name;
            _timeCreated = DateTime.Today;
        }

        public void CalculateCompletionTime()
        {
            if (IsCompleted) {
                _completionTime = (int)(_timeCompleted - _timeCreated).TotalDays;
            }
        }

        public string Name { get { return _name; } set { _name = value; } }
        public int ID { get { return _id; } }
        public bool IsCompleted { get { return _isCompleted; } set { _isCompleted = value; } }
        public int Priority { get { return _priority; } set { _priority = value; } }
        public DateTime TimeCreated { get { return _timeCreated; } set { _timeCreated = value;} }
        public DateTime TimeCompleted { get { return _timeCompleted; } set { _timeCompleted = value; } }
        public int? CompletionTime { get { return _completionTime; } }
        public string Category { get { return _category; } set { _category = value; } }
    }
}

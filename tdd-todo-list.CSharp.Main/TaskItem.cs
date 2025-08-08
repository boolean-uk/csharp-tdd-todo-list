using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskItem
    {
        private static int _nextId = 1;
        
        private int _id;
        private string _name;
        private bool _statusComplete;
        private string _text;
        private int _priority;
        private string _category;
        public DateTime _created;
        public DateTime _completed;
   

        public TaskItem(string name, string text, int priority, string category, bool statusComplete=false)
        {
            _id = _nextId++;
            _name = name;
            _text = text;
            _priority = priority;
            _statusComplete = statusComplete;
            _created = DateTime.Now;
        
        }
        public bool StatusComplete { get { return _statusComplete; } set { _statusComplete = value; } }
        public string Text { get { return _text; } }
        public string Name { get { return _name; } set { _name = value; } } 
        public int Id { get { return _id; } }
        public DateTime Completed { get { return _completed; } set { _completed = value; } }
        public int Priority { get { return _priority; } }

        override
        public string ToString()
        {
            return $" id: {_id} name: {_name} - text: {_text} - priority: {_priority} - status: {_statusComplete}";
        }

        public string ShowDateTimeOfCreation()
        {
            return _created.ToString() ;
        }

        public string ShowDateTimeOfCompletion()
        {
            return _completed.ToString();
        }

        public void ChangeStatus()
        {
            _statusComplete = !_statusComplete;
            _completed = _statusComplete ? DateTime.Now : DateTime.MaxValue;
        }

       







    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskItem
    {
        
        private int _id;
        private string _status = "incomplete";
        private string _text;
        private int _priority;
        private string _category;
        public DateTime _created;
        public DateTime _completed;
   

        public TaskItem(int id, string name, string text, int priority, string category, string status="incomplete")
        {
            _id = id;
            Name = name;
            _text = text;
            _priority = priority;
            _status = status;
            _created = DateTime.Now;
        
        }
        public string Status { get { return _status; } set { _status = Status; } }
        public string Text { get { return _text; } }
        public string Name {  get; set; }
        public int Id { get { return _id; } }

        override
        public string ToString()
        {
            return $"name: {Name} - text: {_text} - priority: {_priority} - status: {_status}";
        }

        

    }
}

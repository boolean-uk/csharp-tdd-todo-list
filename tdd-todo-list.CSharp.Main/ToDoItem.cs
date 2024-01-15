using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class ToDoItem
    {
        string _name;
        bool _status;

        private DateTime _creationDate = DateTime.Now;

        public ToDoItem(string taskName)
        {
            _name = taskName;
        }

        public string Name 
        {
            get { return _name; } 
            set { _name = value; }
        }

        public bool Status 
        {
            get { return _status; } 
            set { _status = value; }
        }



        public string RetrieveDateTime()
        {
            return $"{_creationDate.ToString("yyyy-MM-dd")} {_creationDate.ToString("HH:mm:ss")}";
        }
    }
}

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

        DateTime _creationDate;
        string _creationTime;

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

        public ToDoItem(string taskName) 
        {
            _name = taskName;
        }

        public string RetrieveDateTime() 
        {
            throw new NotImplementedException();
        }
    }
}

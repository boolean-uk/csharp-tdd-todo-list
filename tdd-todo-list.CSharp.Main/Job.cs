using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Job
    {
        private bool _complete;
        private string _name;
        private string _description;
        private DateTime _created;

        public bool Complete { get { return _complete; } }
        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public string Created { get { return DateTime.Now.ToString(); } }

        public Job(string name, string description) 
        { 
            _complete = false;
            _name = name;
            _description = description;
            _created = DateTime.Now;
        }

        public bool ChangeStatus(bool newStatus)
        {
            this._complete = newStatus;
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
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

        public string Name { get { return _name; } }

        public Job(string name, string description) 
        { 
            _complete = false;
            _name = name;
            _description = description;
            _created = DateTime.Now;
        }
    }
}

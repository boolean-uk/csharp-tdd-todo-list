using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        private string _name;
        private bool _completed;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }
        private int _id { get; set; }

        public TodoTask(string name)
        {
            _name = name;
            _completed = false;
        }

        public TodoTask(string name, bool completed)
        {
            _name = name;
            _completed = completed;

        }



    }
}

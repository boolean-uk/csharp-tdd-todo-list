using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Tasks
    {
        private string _name;

        private bool _status = false;
        public string name { get { return _name; } }

        public bool status { get { return _status; } }

        public Tasks(string name)
        {
            this._name = name;
        }

        public bool ChangeStatus()
        {
            _status = !_status;
            return _status;
        }

    }
}

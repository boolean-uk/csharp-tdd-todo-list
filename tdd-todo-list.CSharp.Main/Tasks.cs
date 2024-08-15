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
        public string name { get { return _name; } }

        public Tasks(string name)
        {
            this._name = name;
        }
    }
}

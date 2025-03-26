using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    internal class TodoTask
    {
        public string _name { get; set; }
        public bool _isCompleted { get; set; }
        public DateTime _date { get; set; }

        public TodoTask(string name)
        {
            _name = name;
            _isCompleted = false;
            _date = DateTime.Now;
        }
    }
}

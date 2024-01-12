using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        public string _description { get; set; }
        public bool _done { get; set; }

        public TodoTask(string description, bool done) 
        {
            _description = description;
            _done = done;
            
        }
    }
}

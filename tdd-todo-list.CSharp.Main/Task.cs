using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
{
        public string Description;
        public bool Completed;

        public Task(string description, bool completed)
        {
            Description = description;
            Completed = completed;
        }

        public string description { get { return Description; } set { Description = value; } }
        public bool completed { get { return Completed; } set { Completed = value; }  }
    }
}

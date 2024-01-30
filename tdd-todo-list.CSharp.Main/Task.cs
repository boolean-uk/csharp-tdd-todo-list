using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list
{
    public class Task
{
        public string name { get; set; }
        public bool isComplete { get; set; }

        public Task(string name)
        {
            this.name = name;
            this.isComplete = false;
        }

        public Task(string name, bool complete)
        {
            this.name = name;
            this.isComplete = complete;
        }

        public override string ToString()
        {
            return $"{this.name} - {(this.isComplete ? "Complete" : "Incomplete")}";
        }
}
   
}

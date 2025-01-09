using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        public bool isFinished { get; set; }
        public string taskName { get; set; }

        public TodoTask(string taskName) 
        {  
            this.taskName = taskName;
            this.isFinished = false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Taskname: " + this.taskName + '\n');
            sb.Append("Finished: " + this.isFinished.ToString()+'\n');
            return sb.ToString();

        }
    }
}

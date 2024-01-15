using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class pTask
{
        public string ptask { get; set; }
        public bool isComplete { get; set; }
        public Guid taskID { get; set; }

        public pTask() 
       { 
            taskID = Guid.NewGuid();
       }
        public pTask(string ptask)
        {
            this.ptask = ptask;
        }
    }
}

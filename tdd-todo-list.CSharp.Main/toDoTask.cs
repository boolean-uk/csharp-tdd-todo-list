using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class toDoTask
{

        public string taskName { get; set; }

        public bool taskComplete { get; set; }


        public toDoTask(string TaskName, bool TaskComplete) {

            taskName = TaskName;
            taskComplete=TaskComplete;
        
        }

}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class toDoTask
{


        public int Id { get; set; }
        public string taskName { get; set; }

        public bool taskComplete { get; set; }

        public DateTime creationDate { get; set; }




        public toDoTask(int id,string TaskName, bool TaskComplete, DateTime CreationDate) {

            Id = id;
            taskName = TaskName;
            taskComplete=TaskComplete;
            creationDate = CreationDate;
        
        }

}
}

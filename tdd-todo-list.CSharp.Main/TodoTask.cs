using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        public string name { get; set; }
        public Status status { get; set; }

        public TodoTask(string name, Status status)
        {
            this.name = name;
            this.status = status;
        }
    }

    public enum Status
    {
        COMPLETE,
        INCOMPLETE
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        public string task;
        public bool isCompleted = false;

        public Task(string task)
        {
            this.task = task;
            this.isCompleted = false;
        }
        public Task (string task, bool isCompleted)
        {
            this.task = task;
            this.isCompleted = isCompleted;
        }

        public override string ToString()
        {
            return task;
        }
    }
}

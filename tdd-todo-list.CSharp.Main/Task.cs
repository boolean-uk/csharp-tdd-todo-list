using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task(string task)
    {
        public string task = task;
        public bool isCompleted = false;

        public override string ToString()
        {
            return task;
        }
    }
}

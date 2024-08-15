using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskItem
{
        public String Name { get; set; }
        public bool IsComplete { get; set; } = false;

        public TaskItem (String name)
        {
            Name = name; 
        }
    }
}

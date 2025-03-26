using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        public Task(string name, bool status)
        {
            TaskName = name;
            bIsComplete = status;
            Id = idCount++;
            DateCreated = DateTime.Now;
        }
        public string TaskName { get; set; }
        public bool bIsComplete { get; set; }
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }

        public static int idCount { get; set; } = 0;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main {
    public class TaskItem
    {
        //public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }
        public bool IsCompleted { get; set; } = false;
        public Priority Priority { get; set; } 
    }
}

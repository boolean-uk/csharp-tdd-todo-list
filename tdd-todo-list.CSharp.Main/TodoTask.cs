using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; } = false;
        public Priority Priority { get; set; }
    }
}

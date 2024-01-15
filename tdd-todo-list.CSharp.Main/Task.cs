using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        public Guid Id {  get; set; }
        public string Message { get; set; }
        public bool Completed { get; set; }
        public DateTime date { get; set; }
    }
}

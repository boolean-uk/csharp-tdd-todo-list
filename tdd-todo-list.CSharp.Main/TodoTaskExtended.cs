using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTaskExtended
    {
        public int id { get; set; }
        public string name { get; set; }
        public Status status { get; set; }
        public DateTime time { get; set; }

        public TodoTaskExtended(int id, string name, Status status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            time = DateTime.Now;
        }
    }
}

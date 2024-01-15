using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension {


        public List<Task> tasks { get; set; }
        public struct Task {
            public int _id;
            public string task;
            public bool state;

            public Task(int _id, string task, bool state) {
                this._id = _id;
                this.task = task;
                this.state = state;
            }
        }


        public TodoListExtension() {
            tasks = new List<Task>();
        }










    }
}

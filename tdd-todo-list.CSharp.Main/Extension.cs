using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {

        private List<IdTask> _tasks = new List<IdTask>();

        public List<IdTask> Tasks { get => _tasks; }

        public TodoListExtension() { }

        public IdTask Add(string name)
        {
            IdTask task = new IdTask(name);
            _tasks.Add(task);
            return task;
        }

        public IdTask Get(string id)
        {
            return new IdTask("");
        } 

        public void Rename(string id, string name)
        {

        }

        public void Complete(string id)
        {

        }

        public string PrintCreated()
        {
            return "";
        }
    }
}

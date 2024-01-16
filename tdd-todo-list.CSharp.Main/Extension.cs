using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;

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
            return _tasks.ToList().Where(i => i.Id == id).First();
        } 

        public void Rename(string id, string name)
        {
            _tasks.ToList().Where(i => i.Id == id).First().Name = name;
        }

        public void Complete(string id)
        {
            _tasks.ToList().Where(i => i.Id == id).First().Completed = true;
        }

        public string PrintCreated()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IdTask task in _tasks)
            {
                sb.Append($"{task.Name} {task.Created.ToString("MM/dd/yyyy HH:mm")}");
            }
            return sb.ToString();
        }
    }
}

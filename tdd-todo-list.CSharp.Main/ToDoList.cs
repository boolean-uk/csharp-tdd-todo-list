using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        List<Task> _tasks = new List<Task>();
        public List<Task> Tasks { get => _tasks; set => _tasks = value; }
        public TodoList() { 
            
        }

        public Task Add(string name) 
        {
            return null;
        }

        public string PrintAll()
        {
            return "";
        }

        public Task Complete(Task task)
        {
            return task;
        }

        public List<Task> GetComplete()
        {
            return new List<Task>();
        }

        public List<Task> GetIncomplete()
        {
            return new List<Task>();
        }

        public Task Search(string name)
        {
            return new Task("");
        }

        public bool Remove(Task task)
        {
            return false;
        }

        public string PrintOrderASC()
        {
            return "";
        }

        public string PrintOrderDESC()
        {
            return "";
        }
    }
}

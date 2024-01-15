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
            Task task = new Task(name);
            _tasks.Add(task);
            return task;
        }

        public string PrintAll()
        {
            StringBuilder temp = new StringBuilder();
            foreach(Task task in _tasks)
            {
                temp.Append($"{task.Name}\n{task.Completed}\n");
            }
            return temp.ToString();
        }

        public Task Complete(Task task)
        {
            task.Completed = true;
            return task;
        }

        public List<Task> GetComplete()
        {
            List<Task> tasks = _tasks.ToList().Where(task => task.Completed).ToList();

            return tasks;
        }

        public List<Task> GetIncomplete()
        {
            List<Task> tasks = _tasks.ToList().Where(task => !task.Completed).ToList();

            return tasks;
        }

        public Task Search(string name)
        {
            Task task = _tasks.ToList().Where(task => task.Name == name).ToList()[0];
            return task;
        }

        public bool Remove(Task task)
        {
            if (_tasks.Remove(task)) return true;
            return false;
        }

        public string PrintOrderASC()
        {
            StringBuilder temp = new StringBuilder();
            List<Task> tasks = _tasks.ToList().OrderBy(task => task.Name).ToList();
            foreach(Task task in tasks)
                temp.Append($"{task.Name}\n{task.Completed}\n");
            return temp.ToString();
        }

        public string PrintOrderDESC()
        {
            StringBuilder temp = new StringBuilder();
            List<Task> tasks = _tasks.ToList().OrderByDescending(task => task.Name).ToList();
            foreach (Task task in tasks)
                temp.Append($"{task.Name}\n{task.Completed}\n");
            return temp.ToString();
        }
    }
}

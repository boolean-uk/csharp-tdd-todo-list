using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<Task> _tasks = new List<Task>();

        public TodoList()
        {

        }

        public void addTaskToList(Task t)
        {
            _tasks.Add(t);
        }

        public void removeTaskFromList(Task t)
        {
            _tasks.Remove(t);
        }

        public List<Task> completedTasks()
        {
            return _tasks.Where(t => t.completed == true).ToList();
        }

        public List<Task> uncompletedTasks()
        {
            return _tasks.Where(t => t.completed == false).ToList();
        }

        public void displayList()
        {
            Console.WriteLine("TODO list");
        }

        public string search(string s)
        {
            return "";
        }

        public List<Task> orderByAscending()
        {
            return _tasks;
        }

        public List<Task> orderByDescending()
        {
            return _tasks;
        }

        public List<Task> tasks
        {
            get { return _tasks; }
            set { _tasks = value; }

        }
    }
}

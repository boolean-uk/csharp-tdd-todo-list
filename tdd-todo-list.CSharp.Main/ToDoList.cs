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
            List<Task> completed = _tasks.Where(t => t.completed == true).ToList();
            return completed;
        }

        public List<Task> uncompletedTasks()
        {
            return _tasks.Where(t => t.completed == false).ToList();
        }

        public void displayList()
        {

            _tasks.ForEach(t => { Console.WriteLine($"Task: {t.description} [{boolToString(t.completed)}]"); });
        }
        private string boolToString(bool completed)
        {
            return completed ? "X" : " ";
        }
        public string search(string s)
        {
            Task t = _tasks.FirstOrDefault(t => t.description == s);
            if (t != null)
            {
                return $"{t.description}";
            }
            return "Task does not exist";
        }

        public List<Task> orderByAscending()
        {
            _tasks = _tasks.OrderBy(t => t.description).ToList();
            return _tasks;
        }

        public List<Task> orderByDescending()
        {
            _tasks = orderByAscending();
            _tasks.Reverse();
            return _tasks;
        }

        public void changeCompleteStatus(Task t)
        {
            if (t.completed == true)
            {
                t.completed = false;
            } if (t.completed == false)
            {
                t.completed = true;
            }
        }

        public List<Task> tasks
        {
            get { return _tasks; }
            set { _tasks = value; }

        }
    }
}

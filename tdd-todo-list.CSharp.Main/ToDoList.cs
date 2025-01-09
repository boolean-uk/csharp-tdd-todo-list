using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<ToDoTask> _tasks { get; set; }
        public TodoList() {
            _tasks = new List<ToDoTask>();
        }
        public void Add(ToDoTask task)
        {
            _tasks.Add(task);
        }

        public List<ToDoTask> GetCompletedTasks()
        {
            return _tasks.Where(x => x.IsComplete).ToList();
        }

        public List<ToDoTask> GetIncompleteTasks()
        {
            return _tasks.Where(x => !x.IsComplete).ToList();
        }

        public List<ToDoTask> GetTasks()
        {
            return _tasks;
        }

        public List<ToDoTask> GetTasksAscending()
        {
            return _tasks.OrderBy(x => x.Name).ToList();
        }

        public List<ToDoTask> GetTasksDescending()
        {
            return _tasks.OrderByDescending(x => x.Name).ToList();
        }

        public void Remove(string name)
        {
            _tasks.Remove(SearchTask(name));
        }

        public ToDoTask SearchTask(string searchString)
        {
            try
            {
                return _tasks.Where(x => x.Name.Equals(searchString)).First();
            }
            catch (Exception ex) {
                throw;
            }
        }
    }
}

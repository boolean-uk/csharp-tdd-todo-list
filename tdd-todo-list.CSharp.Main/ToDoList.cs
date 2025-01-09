using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        public string title { get; }
        private bool _completed;
        public bool completed
        {
            get { return this._completed; }
        }

        public TodoTask(string title)
        {
            this.title = title;
            this._completed = false;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", this.title, this._completed);
        }

        public TodoTask(string title, bool completed)
        {
            this.title = title;
            this._completed = completed;
        }

        public void ToggleCompleted()
        {
            this._completed = !this._completed;
        }
    }

    public class TodoList
    {
        private List<TodoTask> _tasklist;

        public TodoList()
        {
            this._tasklist = new List<TodoTask>();
        }

        public bool Add(TodoTask task)
        {
            bool duplicate = this._tasklist.Where((listTask) => listTask.title == task.title).Any();
            if (!duplicate)
            {
                this._tasklist.Add(task);
            }
            return !duplicate;
        }

        public List<TodoTask> GetTasks()
        {
            return this._tasklist;
        }

        public TodoTask? Search(string title)
        {
            return this._tasklist.Find((task) => task.title == title);
        }

        public void ToggleComplete(string title)
        {
            TodoTask? task = this.Search(title);
            if (task == null)
            {
                return;
            }
            task.ToggleCompleted();
        }

        public List<TodoTask> GetCompleted()
        {
            return this._tasklist.Where((task) => task.completed).ToList();
        }

        public List<TodoTask> GetIncomplete()
        {
            return this._tasklist.Where((task) => !task.completed).ToList();
        }

        public List<TodoTask> GetOrderedTasks(bool ascending)
        {
            if (ascending)
            {
                return this._tasklist.OrderBy((a) => a.title).ToList();
            }
            else
            {
                return this._tasklist.OrderByDescending((a) => a.title).ToList();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public List<TodoTask> _tasks = new List<TodoTask>();
        public TodoList() 
        { 
        
        }

        public void Add(string description)
        {
            TodoTask task = new TodoTask(description, false);
            _tasks.Add(task);
        }

        public void Remove(string description) 
        {
            _tasks.RemoveAll(s => s._description  == description);
        }

        public void Ascending()
        {
            this._tasks = _tasks.OrderBy(x => x._description).ToList();
        }

        public void Descending()
        {
            this._tasks = _tasks.OrderBy(x => x._description).Reverse().ToList();
        }

        public List<TodoTask> ListAll()
        {
            return _tasks;
        }

        public string search(string desc)
        {

            foreach (TodoTask task in _tasks)
            {
                if (task._description == desc)
                {
                    return "Task present!";
                }

            }

            return "Task missing!";
        }

        public void MarkAsComplete(string desc)
        {
            foreach (TodoTask task in _tasks)
            {
                if (task._description == desc)
                {
                    task._done = true;
                }
            }
        }

        public void MarkAsIncomplete(string desc)
        {
            foreach (TodoTask task in _tasks)
            {
                if (task._description == desc)
                {
                    task._done = false;
                }
            }
        }

        public List<TodoTask> GetCompleted() 
        {
            List<TodoTask> done = new List<TodoTask>();

            foreach (TodoTask task in _tasks)
            {
                if (task._done == true)
                {
                    done.Add(task);
                }
            }
            return done;
        }

        public List<TodoTask> GetNotCompleted()
        {
            List<TodoTask> done = new List<TodoTask>();

            foreach (TodoTask task in _tasks)
            {
                if (task._done == false)
                {
                    done.Add(task);
                }
            }
            return done;
        }

    }


}

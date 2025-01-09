using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        public string _task { get; set; }
        public bool _completed { get; set; } = false;
        public int _id { get; set; } = 0;
        public string _time { get; set; }

        public TodoTask(string task)
        {
            _task = task;
            _time = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        }
        public TodoTask(string task, int id)
        {
            _task = task;
            _id = id;
            _time = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        }
        public void ChangeStatus()
        {
            _completed = !_completed;
        }
    }
    public class TodoList
    {
        public List<TodoTask> _todo;

        public TodoList()
        {
            _todo = new List<TodoTask>();
        }

        public void Add(string v)
        {
            _todo.Add(new TodoTask(v));
        }

        public List<TodoTask> GetTasks()
        {
            return _todo;
        }
        public List<TodoTask> CompletedTasks()
        {
            return _todo.Where(t => t._completed == true).ToList();
        }
        public List<TodoTask> IncompleteTasks()
        {
            return _todo.Where(t => t._completed != true).ToList();
        }
        public TodoTask? SearchTask(string task)
        {
            foreach (TodoTask v in _todo)
            {
                if (v._task == task)
                {
                    return v;
                }
            }
            return null;
        }
        public void RemoveTask(string task)
        {
            _todo.RemoveAll(t => t._task == task);
        }
        public List<TodoTask> SortAsc()
        {
            return _todo.OrderBy(t => t._task).ToList();
        }

        public List<TodoTask> SortDesc()
        {
            return _todo.OrderByDescending(t => t._task).ToList();
        }
    }
}

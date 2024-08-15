using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{



    public class TodoList
    {
        private List<TodoTask> _tasks;
        public TodoList()
        {
            this._tasks = new List<TodoTask>();
        }

        public List<TodoTask> Tasks { get => _tasks; set => _tasks = value; }

        public bool AddTask(TodoTask t)
        {
            if(t.Taskname == "")
            {
                return false;
            }
            this._tasks.Add(t);
            return true;
        }

        public bool RemoveTask(TodoTask t)
        {
            if (this._tasks.Contains(t))
            {
                this._tasks.Remove(t);
                return true;
            }
            return false;
        }

        public List<TodoTask> GetAllTasks()
        {
            return this._tasks;
        }

        public Status ChangeTaskStatus(TodoTask t, Status newstatus) 
        {
            t.Status = newstatus;
            return newstatus;
        }

        public List<TodoTask> GetCompleteTasks()
        {
            return this._tasks.Where((t) => t.Status == Status.Complete).ToList();
        }

        public List<TodoTask> GetIncompleteTasks() 
        {   
            return this._tasks.Where((t) => t.Status == Status.Incomplete).ToList();
        }

        public string FindTask(string taskname)
        {
            return this._tasks.Any((t) => t.Taskname == taskname) ? "This task was found" : "This task was not found";
        }

        public List<TodoTask> GetSortedTasksAsc()
        {
            this._tasks.Sort((a, b) => a.Taskname.CompareTo(b.Taskname));
            return this._tasks;
        }

        public List<TodoTask> GetSortedTasksDesc()
        {
            this._tasks.Sort((a, b) => b.Taskname.CompareTo(a.Taskname));
            return this._tasks;
        }


        
    }
}

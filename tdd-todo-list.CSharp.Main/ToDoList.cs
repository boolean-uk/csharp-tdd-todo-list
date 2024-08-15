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
            List<TodoTask> completedTasks = new List<TodoTask>();

            foreach(TodoTask t in this._tasks)
            {
                if(t.Status == Status.Complete)
                {
                    completedTasks.Add(t);
                }
            }

            return completedTasks;
        }
        public List<TodoTask> GetIncompleteTasks() 
        {   
            List<TodoTask> incompletedTasks = new List<TodoTask>();

            foreach(TodoTask t in this._tasks)
            {
                if (t.Status == Status.Incomplete) 
                {
                    incompletedTasks.Add(t);
                }
            }

            return incompletedTasks;
        }
        public string FindTask(string taskname)
        {
            bool found = this._tasks.Any((t) => t.Taskname == taskname);

            if (found)
            {
                return "This task was found";
            }
            return "This task was not found";
        
        }
        public List<TodoTask> GetSortedTasksAsc()
        {
            throw new NotImplementedException();
        }
        public List<TodoTask> GetSortedTasksDesc()
        {
            throw new NotImplementedException();
        }


        
    }
}

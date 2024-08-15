using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtended
    {
        private List<TodoTaskExtended> _tasks;
        private int _idCount;
        public TodoListExtended()
        {
            this._tasks = new List<TodoTaskExtended>();
            this._idCount = 0;
        }

        public bool AddTask(string taskname)
        {   
            if(taskname == "")
            {
                return false;
            }
            _tasks.Add(new TodoTaskExtended(taskname, _idCount));
            _idCount++;
            return true;
        }

        public TodoTaskExtended GetTaskById(int id)
        {
            TodoTaskExtended task = _tasks.Find(x => x.Id == id);
            return task;

        }

        public bool UpdateTask(int id, string taskname) {
            if (this._tasks.Any((t) => t.Id == id))
            {
                TodoTaskExtended task = GetTaskById(id);
                task.Taskname = taskname;
                return true;
            }
            return false;
        }

        public bool ChangeTaskStatus(int id, Status status) 
        {
            if (this._tasks.Any((t) => t.Id == id))
            {
                TodoTaskExtended task = GetTaskById(id);
                task.Status = status;
                return true;
            }
            return false;
        }


    }
}

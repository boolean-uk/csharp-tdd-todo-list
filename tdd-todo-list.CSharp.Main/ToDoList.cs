using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
//using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<Tasks> _tasks = new List<Tasks>();

        //public TodoList();

        public bool Add(Tasks task)
        {
            _tasks.Add(task);
            return true;
        }

        public bool ChangeStatus(string taskName)
        {
            Tasks task = _getTask(taskName);
            return task.ChangeStatus();
        }

        public void SetTasks(List<Tasks> tasks)
        {
            _tasks = tasks;
        }

        public string FindTask(string taskName)
        {
            Tasks task = _getTask(taskName);
            if (task != null)
            { 
                return "Success";
            }
            return "Failed";
        }

        private Tasks _getTask(string name)
        {
            foreach (Tasks task in _tasks)
            {
                if(task.name == name) 
                {
                    return task;
                }
            }
            return null;
        }

        public List<Tasks> GetCompleted()
        {
            List<Tasks> tasks  = new List<Tasks>();
            foreach (Tasks task in _tasks)
            {
                if (task.status)
                {
                    tasks.Add(task);
                }
            }
            return tasks;
        }

        public List<Tasks> GetIncompleted()
        {

            //List<Tasks> tasks = _tasks.GroupBy(task => task.status).ToList();
            List<Tasks> tasks = new List<Tasks>();
            foreach (Tasks task in _tasks)
            {
                if (!task.status)
                {
                    tasks.Add(task);
                }
            }
            return tasks;
        }

        public List<Tasks> GetTodoList()
        {
            return _tasks;
        }

        public void RemoveTask(string name)
        {
            _tasks.Remove(_getTask(name));
        }

        public List<Tasks> SortAscending()
        {
            return _tasks.OrderBy(task => task.name).ToList();
        }

        public List<Tasks> SortDescending()
        {
            return _tasks.OrderByDescending(task => task.name).ToList();
        }
    }
}

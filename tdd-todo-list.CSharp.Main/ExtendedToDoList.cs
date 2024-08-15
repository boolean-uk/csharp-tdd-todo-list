using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Main
{
    public class ExtendedToDoList
    {
        private List<ExtendedTasks> _tasks = new List<ExtendedTasks>();

        //public TodoList();

        public bool Add(ExtendedTasks task)
        {
            _tasks.Add(task);
            return true;
        }

        public bool ChangeStatus(int id)
        {
            ExtendedTasks task = _getTask(id);
            return task.ChangeStatus();
        }

        public void SetTasks(List<ExtendedTasks> tasks)
        {
            _tasks = tasks;
        }

        public string FindTask(string taskName)
        {
            ExtendedTasks task = _getTask(taskName);
            if (task != null)
            {
                return "Success";
            }
            return "Failed";
        }

        private ExtendedTasks _getTask(string name)
        {
            foreach (ExtendedTasks task in _tasks)
            {
                if (task.name == name)
                {
                    return task;
                }
            }
            return null;
        }

        private ExtendedTasks _getTask(int Id)
        {
            foreach (ExtendedTasks task in _tasks)
            {
                if (task.id == Id)
                {
                    return task;
                }
            }
            return null;
        }

        public List<ExtendedTasks> GetCompleted()
        {
            List<ExtendedTasks> tasks = new List<ExtendedTasks>();
            foreach (ExtendedTasks task in _tasks)
            {
                if (task.status)
                {
                    tasks.Add(task);
                }
            }
            return tasks;
        }

        public List<ExtendedTasks> GetIncompleted()
        {

            //List<Tasks> tasks = _tasks.GroupBy(task => task.status).ToList();
            List<ExtendedTasks> tasks = new List<ExtendedTasks>();
            foreach (ExtendedTasks task in _tasks)
            {
                if (!task.status)
                {
                    tasks.Add(task);
                }
            }
            return tasks;
        }

        public List<ExtendedTasks> GetTodoList()
        {
            return _tasks;
        }

        public void RemoveTask(string name)
        {
            _tasks.Remove(_getTask(name));
        }

        public List<ExtendedTasks> SortAscending()
        {
            return _tasks.OrderBy(task => task.name).ToList();
        }

        public List<ExtendedTasks> SortDescending()
        {
            return _tasks.OrderByDescending(task => task.name).ToList();
        }

        public ExtendedTasks GetTask(int id)
        {
            return _getTask(id);
        }

        public bool UpdateName(int Id, string NewName)
        {
            ExtendedTasks tasks = _getTask(Id);
            if (tasks != null)
            {
                tasks.name = NewName;
                return true;
            }
            return false;
        }

        public object GetDateTime(int id)
        {
            ExtendedTasks task = _getTask(id);
            return task.datetime;
        }
    }
}


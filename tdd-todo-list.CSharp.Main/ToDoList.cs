using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_todo_list.CSharp.Main
{
    
    public enum Priority
    {
        Low,
        Medium,
        High
    }

    public class TaskItem
    {
        
        private string _taskName;
        //flase = incomplete, true = complete
        private bool _status = false;
        //set to low as a default
        private Priority _priority = Priority.Low;
        private string _category;
        
        

        public TaskItem(string taskName) 
        {
            _taskName = taskName;
        }



        
        public string TaskName { get { return _taskName; } set { _taskName = value; } }

        public bool Status { get { return _status; } set { _status = value; } }

        public Priority Priority { get { return _priority; } set { _priority = value; } }


        
        //public Guid Id { get; set; } = Guid.NewGuid();
        //public Category Category { get { return _category; } set { _category = value; } }

    }






    public class TodoList
    {
        public List<TaskItem> _tasks = new List<TaskItem>();


        public void Add(string taskName)
        {
            TaskItem taskAdd = new TaskItem(taskName);
            _tasks.Add(taskAdd);
        }


        public void RemoveTask(string task) 
        {
            foreach (var item in _tasks)
            {
                if (item.TaskName == task)
                {
                    _tasks.RemoveAt(_tasks.IndexOf(item));
                    break;
                }
            }
        }

        public List<TaskItem> GetAll()
        {
            return _tasks;
        }

        public void ChangeStatus(string task, bool status)
        {
            foreach (var item in _tasks)
            {
                if (item.TaskName == task)
                {
                    item.Status = status;
                    break;
                }
            }
        }

        public List<TaskItem> GetCompleted()
        {
            List<TaskItem> result = new List<TaskItem>();
            foreach (var item in _tasks) 
            {
                if (item.Status)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public List<TaskItem> GetIncomplete()
        {
            List<TaskItem> result = new List<TaskItem>();
            foreach (var item in _tasks)
            {
                if (!item.Status)
                {
                    result.Add(item);
                }
            }
            return result;

        }


        public bool SearchTask(string task)
        {
            foreach (var item in _tasks)
            {
                if (item.TaskName == task)
                {
                    return true;
                    
                }
                else
                {
                    Console.WriteLine($"{task} is not in the list");
                    return false;
                }
            }
            return false;
        }


        public TodoList ShowAlpAscending()
        {
            TodoList result = new TodoList();
            List<string> taskNames = new List<string>();

            foreach (var item in _tasks)
            {
                taskNames.Add(item.TaskName);
            }

            taskNames.Sort();

            foreach (var item in taskNames)
            {
                result.Add(item);
            }
            return result;
        }


        public TodoList ShowAlpDecending()
        {
            TodoList result = new TodoList();
            List<string> taskNames = new List<string>();

            foreach (var item in _tasks)
            {
                taskNames.Add(item.TaskName);
            }

            taskNames.Sort();
            taskNames.Reverse();

            foreach (var item in taskNames)
            {
                result.Add(item);
            }
            return result;
        }

        public bool SetPriority(string name, Priority priority)
        {
            foreach (var item in _tasks)
            {
                if (item.TaskName == name)
                {
                    item.Priority = priority;
                    return true;
                }
            }
            return false;
        }


        public List<TaskItem> ShowByPriority()
        {
            return _tasks.OrderBy(task => task.Priority).ToList();
        }


        

    }
}

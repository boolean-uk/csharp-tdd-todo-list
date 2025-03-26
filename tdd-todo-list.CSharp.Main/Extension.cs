using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        List<TaskExtension> _toDoList = new List<TaskExtension>();
        public TodoListExtension(List<TaskExtension> toDoList)
        {
            _toDoList = toDoList;
        }

        public TaskExtension GetTask(int id)
        {
            foreach (TaskExtension task in _toDoList)
            {
                if (task.ID == id)
                {
                    return task;
                }
            }
            return null;
        }
        public bool UpdateName(int id, string name)
        {
            foreach (TaskExtension task in _toDoList)
            {
                if (task.ID == id)
                {
                    task.Name = name;
                    return true;
                }
                
            }
            return false;
        }

        public bool ChangeStatus(int id)
        {
            foreach (TaskExtension task in _toDoList)
            {
                if (task.ID == id)
                {
                    task.Status = !task.Status;
                    return true;
                }
            }
            return false;
        }

        public List<DateTime> GetTimes()
        {
            List<DateTime> times = new List<DateTime>();
            foreach (TaskExtension task in _toDoList)
            {
                times.Add(task.CreatedOn);
            }
            return times;
        }
    }



    public class IDGenerator
    {
        static int count = 0;
        public static int GetID()
        {
            count++;
            return count;
        }
    }

}

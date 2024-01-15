using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public List<pTask> todoListEx = new List<pTask>();

        public TodoListExtension() { }

        public bool addTask(string task)
        {
            //Check if name exists, if there is no duplicate, add it
            if (!todoListEx.Any(item => item.ptask == task))
            {
                todoListEx.Add(new pTask() { ptask = task, isComplete = false });
                return true;
            }
            return false;
        }

        public pTask GetTask(Guid id) => todoListEx.FirstOrDefault(item => item.taskID == id);

        public pTask edit(Guid id,  string text)
        {
            pTask t = todoListEx.FirstOrDefault(item => item.taskID == id);

            //Check if t exists and the name isnt taken
            if (t != null && !todoListEx.Any(item => item.ptask == text))
            {
                t.ptask = text;
                return t;
            }
            return null;
        }
        public pTask edit(Guid id, bool status)
        {
            pTask t = todoListEx.FirstOrDefault(item => item.taskID == id);
            if (t != null)
            {
                t.isComplete = status;
                return t;
            }
            return null;
        }
        public List<DateTime> GetDateTime()
        {
            List<DateTime> list = new List<DateTime>();
            foreach (var item in todoListEx)
            {
                list.Add(item.dateTime);
            }
            return list;
        }

    }
}

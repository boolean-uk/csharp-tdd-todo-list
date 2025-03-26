using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private string task;
        private bool complete;

        public Dictionary<string, bool> myList;

        public TodoList(string task, bool complete)
        {
            this.task = task;
            this.complete = complete;
        }
        public TodoList()
        {
            myList = new Dictionary<string, bool>();
        }

        public List<TodoList> tasks = new List<TodoList>();
        
        public Dictionary<string, bool> Add(String task, bool completed)
        {
            myList.Add(task, completed);
            return myList;
        }

        public Dictionary<string, bool> AllTasks()
        {
            return myList;
        }

        public bool changeStatus(string task, bool completed)
        {
            bool taskUpdated = false;
            if (myList.ContainsKey(task))
            {
                myList[task] = completed;
                taskUpdated = true;
            } else
            {
                myList.Add(task, completed);
                taskUpdated = true;
            }
            return taskUpdated;
        }

        public List<string> GetComplete()
        {
            var completed = myList.Where(task => task.Value == true).Select(task => task.Key).ToList();

            return completed;
        }
        public List<string> GetIncomplete()
        {
            var incompleted = myList.Where(task => task.Value == false).Select(task => task.Key).ToList();

            return incompleted;
        }

        public bool Find(string name)
        {
            bool found = false;
            try
            {
                if (myList.ContainsKey(name))
                {
                    found = true;
                    Console.WriteLine($"Found task: {myList[name]}");
                }
                else if (!myList.ContainsKey(name))
                {
                    found = false;
                    Console.WriteLine($"Could not find task: {myList[name]}");
                }
            } catch(Exception ex)
            {
                Console.Write(ex.ToString());
            }
            
            return found;
        }

        public bool Remove(string name)
        {
            //dictionary already has a .Remove function
            return true;
        }

        public Dictionary<string, bool> AllTasksAsc(Dictionary<string, bool> myList)
        {
            var listAsc = myList.OrderBy(x => x.Key).ThenBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            return listAsc;
        }
        public Dictionary<string, bool> AllTasksDsc(Dictionary<string, bool> myList)
        {
            var listDsc = myList.OrderByDescending(x => x.Key).ThenBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            return listDsc;
        }

        public string Task
        {
            get { return task; }
            set { task = value; }
        }
        public bool Complete
        {
            get { return complete; }
            set { complete = value; }
        }
    }
}

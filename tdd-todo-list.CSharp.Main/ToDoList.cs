using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
       // private List<ToDoTask> tasks = new List<ToDoTask>;
        public Dictionary<string, bool> Tasks { get; set; } = new Dictionary<string, bool>();

        public TodoList()
        {
            
        }

        public bool AddTask(string task)
        {
            if (!Tasks.ContainsKey(task))
            {
                Tasks.Add(task, false); 
                return true;
            }
            return false;
        }

        // Denne kan slettes

        public void AddTaskToTasks(ToDoTask tdt)
        {
            Tasks.TryAdd(tdt.Name, tdt.IsComplete);
        }
        

        public List<string> GetAllTasks()
        {
            return Tasks.Keys.ToList();
        }

       
        public List<string> GetCompleteTasks()
        {
            return Tasks.Where(task => task.Value == true).Select(task => task.Key).ToList();

        }

        public List<string> GetIncompleteTasks()
        {
            return Tasks.Where(task => !task.Value == true).Select(task => task.Key).ToList();

        }


        public string SearchTask(string taskName)
        {
            if (Tasks.ContainsKey(taskName))
            {
                return "Exists";
            }
            else
            {
                return "Not Found";
            }
        }
        public bool RemoveTask(string task)
        {
            if (Tasks.ContainsKey(task))
            {
                Tasks.Remove(task);
                return true;
            }
            return false;
        }

        public List<string> OrderTasksAscending()
        {
            return Tasks.Keys.OrderBy(task => task).ToList();
        }

        public List<string> OrderTasksDescending()
        {
            return Tasks.Keys.OrderByDescending(task => task).ToList();
        }

        



    }
}

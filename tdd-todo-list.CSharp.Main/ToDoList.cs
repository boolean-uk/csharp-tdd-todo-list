using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        // Introduce new dict for tasks
        public Dictionary<string, int> tasks {  get; set; }

        //Constructor
        public TodoList()
        {
            tasks = new Dictionary<string, int>();
        }

        //Method to add tasks
        public void addTask(string taskName) 
        {
            if (!tasks.ContainsKey(taskName)) 
            {
                tasks.Add(taskName, 0);
            }

        }

        //Method to return all tasks:
        public string[] showAllTasks() 
        {  
            return tasks.Keys.ToArray(); 
        }

        //Method to change status of task
        public void changeStatus(string status, int statusValue) 
        {
            if (tasks.ContainsKey(status)) 
            {
                tasks[status] = statusValue;
            }
        }

        //Method to search for task
        public bool searchForTask(string taskName) 
        {
            bool found = false;
            foreach (string task in tasks.Keys) 
            {
                if (task == taskName)
                    {
                        found = true; 
                        break; 
                    }
            
            }
            return found;
        }

        //Method that removes task
        public void removeTask(string taskName) 
        {
            if (tasks.ContainsKey(taskName)) 
            {
                tasks.Remove(taskName);
            }
        }

        //Method that return incomplete tasks as a list
        public List<string> ShowIncompleteTasks()
        {
            List<string> incompleteTasks = new List<string>();

            foreach (string taskName in tasks.Keys) 
            {
                if (tasks[taskName] == 0) 
                {
                    incompleteTasks.Add(taskName);
                }
            }
            return incompleteTasks;
        }

        public List<string> ShowCompleteTasks()
        {
            List<string> completeTasks = new List<string>();

            foreach (string taskName in tasks.Keys)
            {
                if (tasks[taskName] == 1)
                {
                    completeTasks.Add(taskName);
                }
            }
            return completeTasks;
        }

        public string[] showTasksAlphabeticAsc() 
        {
            string[] allTasks = showAllTasks();
            string[] allTasksSorted = allTasks.OrderBy(task => task).ToArray();

            return allTasksSorted;
        }

        public string[] showTasksAlphabeticDesc()
        {
            string[] allTasks = showAllTasks();
            string[] allTasksSortedDesc = allTasks.OrderByDescending(task => task).ToArray();

            return allTasksSortedDesc;
        }

    }

}

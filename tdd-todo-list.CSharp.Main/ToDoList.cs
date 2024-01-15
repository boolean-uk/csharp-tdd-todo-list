using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        Dictionary<string, string> toDoList;

        public TodoList()
        {
            toDoList = new Dictionary<string, string>();
        }

        public void add(string task, string status)
        {
            toDoList.Add(task, status);
        }





        public List<string> getList()
        {
            List<string> listOfTasks = new List<string>();
            foreach (var item in toDoList.Keys)
            {
                string task = item;  // Corrected line
                listOfTasks.Add(task);
            }
            return listOfTasks;
        }




        public void changeStatus(string task)
        {
            if (toDoList.ContainsKey(task))
            {
                string currentStatus = toDoList[task];

                // Toggle the status
                if (currentStatus == "incomplete")
                {
                    toDoList[task] = "complete";
                }
                else
                {
                    toDoList[task] = "incomplete";
                }
            }
        }


        public string GetTaskStatus(string task)
        {
            if (toDoList.ContainsKey(task))
            {
                return toDoList[task];
            }
            return null; // or some default value if the task is not found
        }






         public void completedTasks()
         {
             foreach (var kvp in toDoList.ToList())  // Create a copy of the dictionary to avoid modification issues
             {
                 if (kvp.Value == "incomplete")
                 {
                     // Do whatever you need to do with completed tasks
                     // In this example, we'll remove them from the toDoList
                     toDoList.Remove(kvp.Key);
                 }
             }
         }








        public void incompletedTasks()
        {
            foreach (var kvp in toDoList.ToList())  // Create a copy of the dictionary to avoid modification issues
            {
                if (kvp.Value == "complete")
                {
                    // Do whatever you need to do with completed tasks
                    // In this example, we'll remove them from the toDoList
                    toDoList.Remove(kvp.Key);
                }
            }
        }



        public bool search(string task)
        {
            if (toDoList.ContainsKey(task))
            {
                return true;
            }
            return false;
        }

        public void removeTask(string task)
        {
            if (toDoList.ContainsKey(task))
            {
                toDoList.Remove(task);
            }
        }


        public void sortAscending()
        {
            toDoList = toDoList.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public void sortDescending()
        {
            toDoList = toDoList.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }


    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Item
    {
        public Item(string task, bool complete)
        {
            Task = task;
            Complete = complete;
        }
        public string Task { get; set; }
        public bool Complete { get; set; }
    }
    
    public class TodoList
    {
        public List<Item> ToDoList = new List<Item>();

        public void AddTask(string task)
        {
            Item newTask = new Item(task, false);
            ToDoList.Add(newTask);
        }

        public string ViewList()
        {
            StringBuilder allTasks = new StringBuilder();
            foreach (Item item in ToDoList)
            {
                allTasks.AppendLine(item.Task.ToString());
            }
            return allTasks.ToString();
        }

        public void SetStatus(string task,  bool newStatus)
        {
            Item currentItem = new Item(task, newStatus);
            foreach (var taskX in ToDoList)
            {
                if (taskX.Task == task)
                    taskX.Complete = newStatus;
            }

        }

        public string GetCompletedTasks()
        {
            StringBuilder completedTasks = new StringBuilder();
            foreach (var taskX in ToDoList)
            {
                if (taskX.Complete == true)
                {
                    completedTasks.AppendLine(taskX.Task.ToString());
                }
            }
            return completedTasks.ToString();
        }

        public string GetIncompleteTasks()
        {
            StringBuilder incompleteTasks = new StringBuilder();
            foreach (var TaskX in ToDoList)
            {
                if (TaskX.Complete == false)
                {
                    incompleteTasks.AppendLine(TaskX.Task.ToString());
                }
            }
            return incompleteTasks.ToString();
        }

        public string Search(string lookupTask)
        {
            string response = "";
            foreach (var TaskX in ToDoList)
            {
                if (TaskX.Task == lookupTask)
                { response = "Task found"; }
                else
                { response = "Task not found"; }
            }
            return response ;
        }

        public void RemoveTask(string removeTask)
        {
            for (int i = 0; i < ToDoList.Count; i ++)
            {
                if (ToDoList[i].Task == removeTask)
                { ToDoList.RemoveAt(i); }
                    
            }
        }

        public string ListAscending()
        {
            
            ToDoList.Sort(delegate (Item x, Item y)
            {
                if (x.Task == null && y.Task == null) return 0;
                else if (x.Task == null) return -1;
                else if (y.Task == null) return -1;
                else return x.Task.CompareTo(y.Task);
            });

            StringBuilder listAsc = new StringBuilder();
            foreach (var task in ToDoList)
            {
                listAsc.AppendLine($"{task.Task.ToString()}, completed: {task.Complete.ToString()}");
            }

            return listAsc.ToString();
        }

        public string ListDescending()
        {
            ToDoList.Sort(delegate (Item y, Item x)
            {
                if (x.Task == null && y.Task == null) return 0;
                else if (x.Task == null) return -1;
                else if (y.Task == null) return -1;
                else return x.Task.CompareTo(y.Task);
            });

            StringBuilder listDesc = new StringBuilder();
            foreach (var task in ToDoList)
            {
                listDesc.AppendLine($"{task.Task.ToString()}, completed: {task.Complete.ToString()}");
            }

            return listDesc.ToString();
        }


    }
}

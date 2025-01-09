using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string,bool> taskList = new Dictionary<string, bool>();

        public void AddTask(string task, bool status)
        {
            taskList.Add(task, status);
        }

        public void ChangeStatus(string task)
        {
            taskList[task] = !taskList[task];
        }

        public void PrintList(Dictionary<string, bool> list)
        {
            foreach(string task in list.Keys)
                {
                if (list[task])
                    Console.WriteLine("Task: " + task + " Status: Completed");
                else
                    Console.WriteLine("Task: " + task + " Status: Not Completed");
            }
        }

        public bool Search(string word)
        {
            if (taskList.ContainsKey(word))
            {
                Console.WriteLine("Found the task");
                return true;
            } else
            {
                Console.WriteLine("Task not found");
                return false;
            }
        }

        public object? GetTasks(bool v)
        {
            Dictionary<string, bool> resultList = new Dictionary<string, bool>();


            foreach (string task in taskList.Keys) 
            { 
                if (taskList[task] == v)
                    resultList.Add(task, v);
            }

            return resultList;
        }

        public void RemoveTask(string v)
        {
            taskList.Remove(v);
        }

        public object? AscSortList()
        {
            taskList.OrderBy(x => x.Key);
            PrintList(taskList);
            return taskList;
        }

        public object? DescSortList()
        {
            taskList.OrderByDescending(x => x.Key);
            PrintList(taskList);
            return taskList;
        }

        public Dictionary<string, bool>  GetList {get { return taskList; }}
    }
}

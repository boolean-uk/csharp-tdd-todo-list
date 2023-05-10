﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> todo = new Dictionary<string, bool>();
        Dictionary<string, bool> completedList = new Dictionary<string, bool>();
        Dictionary<string, bool> incompletedList = new Dictionary<string, bool>();
        
        public void AddTask(string task, bool status)
        {
            todo.Add(task, status);
        }

        public string GetTasks()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string task in todo.Keys) 
            {
                sb.Append($"{task}; ");
            }
            return sb.ToString();
        }

        public void UpdateTaskStatus(string task, bool status)
        {
            todo[task] = status;
        }

        public void CompletedTasks()
        {
            foreach(string task in todo.Keys)
            {
                if (todo[task] == true)
                {
                    completedList.Add(task, todo[task]);
                }

            }
        }

        public void IncompletedTasks()
        {
            foreach (string task in todo.Keys)
            {
                if (todo[task] == false)
                {
                    incompletedList.Add(task, todo[task]);
                }

            }
        }

        public string TodoContainsTask(string task)
        {
            if (!todo.ContainsKey(task))
            {
                return "Task not found";
            }
            else
            {
                return "Task found";
            }
        }

        public Dictionary<string,bool> TodoAlphabetically()
        {
            return todo.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }
        public Dictionary<string, bool> TodoAlphabeticallyReverse()
        {
            return todo.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public void RemoveTask(string task)
        {
            todo.Remove(task);
        }

        public Dictionary<string, bool> TaskList { get { return todo; } }
        public Dictionary<string, bool> CompletedList { get { return completedList; } }
        public Dictionary<string, bool> IncompletedList { get { return incompletedList; } }
    }
}

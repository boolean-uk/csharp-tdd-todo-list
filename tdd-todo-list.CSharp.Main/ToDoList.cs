﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary <string, string> ToDoList = new Dictionary<string, string> ();

        public bool AddTask(string task)
        {
            string defaultTaskStatus = "incomplete";

            if (!ToDoList.ContainsKey(task)) 
            {
                ToDoList.Add(task, defaultTaskStatus);
                return true;
            }
            return false;
            
        }

        public string ChangeTaskStatus(string task, string taskStatus) 
        {
            if (!ToDoList.ContainsKey(task)) return "Task does not exist";
            else
            {
                return ToDoList[task] = taskStatus;
            }
                
        }

        public Dictionary<string, string> ViewToDoList { get { return ToDoList; } }


    }
}

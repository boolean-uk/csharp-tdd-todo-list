﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string,string> _toDoList = new Dictionary<string, string>();

        public Dictionary<string, string> ToDoDict { get => _toDoList;  }

        public void Add(string task)
        {
            string status = "incomplete";
            _toDoList.Add(task, status);
        }

        public string[] Print()
        {
            string[] keys = new string[ToDoDict.Count];
            int counter = 0;
            foreach (string key in _toDoList.Keys)
            {
                //Console.WriteLine(key);
                keys[counter]= key;
                counter++;

            }
            return keys;
        }
    }
}

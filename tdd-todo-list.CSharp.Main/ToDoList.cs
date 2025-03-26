﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public int taskCount { get { return _todoList.Count; } }

        private Dictionary<string, bool> _todoList { get; set; } = new Dictionary<string, bool>();

        public Dictionary<string, bool> todoList { get { return _todoList; } }

        public Dictionary<string, bool> tasksAscending { get { return _todoList.Keys.OrderBy(x => x).ToDictionary(x => x, x => _todoList[x]); } }
        public Dictionary<string, bool> tasksDescending { get { return _todoList.Keys.OrderByDescending(x => x).ToDictionary(x => x, x => _todoList[x]); } }

        public List<string> completedTasks { get { return _todoList.Keys.Where(x => _todoList[x] == true).ToList(); } }

        public List<string> inCompletedTasks { get { return _todoList.Keys.Where(x => _todoList[x] == false).ToList(); } }


        public bool Add(string task)
        {
            //I assume a task is initially not completed
            _todoList.Add(task, false);
            return true;
        }
        public bool Remove(string taskToBeRemoved)
        {
            if (_todoList.ContainsKey(taskToBeRemoved))
            {
                _todoList.Remove(taskToBeRemoved);
                return true;
            }
            return false;
        }

        public bool ChangeTask(string task)
        {
            if (_todoList.ContainsKey(task))
            {
                if (_todoList[task] == true)
                {
                    _todoList[task] = false;
                    return true;
                }
                _todoList[task] = true;
                return true;
            }
            return false;
        }

        public bool Search(string task)
        {
            if (_todoList.ContainsKey(task)) { return true; }
            return false;
        }
    }
}

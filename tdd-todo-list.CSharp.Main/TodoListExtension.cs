﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private int _idCounter = 0;
        private Dictionary<int, TodoTask> _todoList { get; set; } = new Dictionary<int, TodoTask>();

        public Dictionary<string, DateTime> dateList { get { return _todoList.Values.ToDictionary(x => x._name, x => x._date); } }

        public void Add(string taskName)
        {
            TodoTask task = new TodoTask(taskName);
            _todoList.Add(_idCounter, task);
            _idCounter++;
        }

        public bool ChangeStatus(int id)
        {
            if (_todoList.ContainsKey(id))
            {
                if (_todoList[id]._isCompleted)
                {
                    _todoList[id]._isCompleted = false;
                    return true;
                }
                _todoList[id]._isCompleted = true;
                return true;
            }
            return false;
        }

        public bool ChangeTaskName(int id, string taskName)
        {
            if (_todoList.ContainsKey(id))
            {
                _todoList[id]._name = taskName;
                return true;
            }
            return false;
        }

        public string GetTask(int v) => _todoList[v]._name;

    }
}

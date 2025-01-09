﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskClass
    {
        
        private string _task;
        private bool _isComplete = false;
        private string _name = "NoNameGiven";
        private DateTime now = DateTime.Now;

        public TaskClass(string TaskMessage)
        {
            this._task = TaskMessage;
        }


        public void ChangeStatus()
        {
            _isComplete = !IsComplete;
        }

        public void UpdateName(string newName)
        {
            _name = newName;
        }

        public bool IsComplete { get => _isComplete; }
        public string TaskHolder { get => _task; }
        public string Name { get => _name; }
        public DateTime DateAndTime { get => now;  }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask : ITodoTask
    {
        private string _taskContent = "";
        private bool _isCompleted = false;
        private TaskPriorityEnum _priority = TaskPriorityEnum.Medium;
        private DateTime _timeCompleted;
        private TimeSpan _timeToComplete;
        private TaskCategoryEnum _category;

        public int Id { get; }
        public bool IsCompleted { get { return _isCompleted; } }

        public string TaskContent { get { return _taskContent; } }
        public TaskPriorityEnum Priority { get { return _priority; } }

        public DateTime TimeCreated { get; }
        public DateTime TimeCompleted { get { return _timeCompleted; } }
        public TimeSpan TimeToComplete { get { return _timeToComplete; } }

        public TaskCategoryEnum Category { get { return _category; } }

        public TodoTask(int id, string taskContent)
        {
            Id = id;
            _taskContent = taskContent;
            TimeCreated = DateTime.Now;
        }
        public void ChangeTaskContent(string taskContent)
        {
            _taskContent = taskContent;
        }

        public void CompleteTask()
        {
            _timeCompleted= DateTime.Now;
            _timeToComplete = (TimeCompleted - TimeCreated);
            _isCompleted = true;
        }

        public void ChangeTaskPriority(TaskPriorityEnum priority)
        {
            _priority = priority;
        }

        public void ChangeTaskCategory(TaskCategoryEnum category)
        {
            _category = category;
        }


    }

}

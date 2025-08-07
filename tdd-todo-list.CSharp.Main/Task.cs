using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        private string _taskContent = "";
        private bool _isCompleted = false;
        private TaskPriorityEnum _priority;
        private DateTime _timeCompleted;
        private TimeSpan _timeToComplete;

        public int Id { get; }
        public bool IsCompleted { get { return _isCompleted; } }

        public string TaskContent { get { return _taskContent; } }
        public TaskPriorityEnum Priority { get { return _priority; } }

        public DateTime TimeCreated { get; }
        public DateTime TimeUpdated { get { return _timeCompleted; } }
        public TimeSpan TimeToComplete { get { return _timeToComplete; } }

        public TaskCategoryEnum Category { get; set; }

        public void ChangeTaskContent(string taskContent)
        {
            _taskContent = taskContent;
        }

        public Task(int id, string taskContent)
        {
            Id = id;
            _taskContent = taskContent;
        }

        public void CompleteTask()
        {
            _timeCompleted= DateTime.Now;
            _timeToComplete = (TimeUpdated - TimeCreated);

        }


    }

}

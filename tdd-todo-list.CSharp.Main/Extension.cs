using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskItem
    {
        private int _taskId;
        private string _name;
        private bool _isComplete;
        private string _dateTime;

        public TaskItem()
        {
            _taskId = 0;
            _name = "write some more code";
            _isComplete = false;
            _dateTime = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");
        }

        public TaskItem(int taskId, string name, bool isComplete)
        {
            _taskId = taskId;
            _name = name;
            _isComplete = isComplete;
            _dateTime = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");
        }

        public int TaskId { get => _taskId; }
        public string Name { get => _name; }
        public bool IsComplete { get => _isComplete; }
    }

    public class TodoListExtension
    {
        List<TaskItem> _list = new List<TaskItem>();

        public void Add(TaskItem task)
        {
            _list.Add(task);
        }

        public TaskItem GetTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTaskName(int taskId, string name)
        {
            throw new NotImplementedException();
        }

        public bool ChangeTaskStatus(int taskId, bool isComplete)
        {
            throw new NotImplementedException();
        }

        public string GetTaskDates()
        {
            throw new NotImplementedException();
        }
    }
}

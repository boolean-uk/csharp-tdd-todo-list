using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskItem
    {
        private int _id;
        private string _name;
        private bool _isComplete;
        private string _dateTime;

        public TaskItem()
        {
            _id = 0;
            _name = "write some more code";
            _isComplete = false;
            _dateTime = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");
        }

        public TaskItem(int taskId, string name, bool isComplete)
        {
            _id = taskId;
            _name = name;
            _isComplete = isComplete;
            _dateTime = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt");
        }

        public int Id { get => _id; }
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
            return _list.Find(t => t.Id == taskId);
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

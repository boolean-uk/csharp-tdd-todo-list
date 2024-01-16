using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<TodoTask> _tasks;

        public TodoList()
        {
            _tasks = new List<TodoTask>();
        }

        public void AddTask(TodoTask task)
        {
            _tasks.Add(task);
        }

        public string FindTask(string v)
        {
            List<TodoTask> task = _tasks.Where(t => t.Title() == v).ToList();
            if (task.Count == 0) { return "There was no match"; }
            else { return task[0].Title(); }
        }

        public List<TodoTask> GetAllTasksAcending()
        {
            return _tasks.OrderBy(t => t.Title()).ToList();
        }

        public List<TodoTask> GetAllTasksDecending()
        {
            return _tasks.OrderByDescending(t => t.Title()).ToList();
        }

        public List<TodoTask> GetCompletedTasks()
        {
            return _tasks.Where(t => t.IsComplete()).ToList();
        }

        public List<TodoTask> GetIncompletedTasks()
        {
            return _tasks.Where(t => ! t.IsComplete()).ToList();
        }

        public void RemoveTask(TodoTask task)
        {
            _tasks.Remove(task);
        }
    }

    public class TodoTask
    {
        private bool _isComplete;
        private string _title = "";

        public TodoTask()
        {
        }

        public TodoTask(string title)
        {
            _isComplete = false;
            _title = title;
        }

        public void ChangeCompleteStatus()
        {
            _isComplete = !IsComplete();
        }

        public bool IsComplete()
        {
            return _isComplete;
        }

        public string Title() { return _title; }
    }
}

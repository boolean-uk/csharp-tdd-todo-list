using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _todoList = [];

        public void Add(string task)
        {
            _todoList.Add(task, false);
        }

        public bool IsComplete(string task)
        {
            return _todoList.GetValueOrDefault(task, false);
        }

        public bool ToggleTask(string task)
        {
            if (_todoList.ContainsKey(task))
            {
                _todoList[task] = !_todoList[task];
                return _todoList[task];
            }
            throw new Exception("That task does not exists!");
        }

        public List<string> GetCompleted()
        {
            return _todoList.Keys.Where(task => _todoList[task]).Select(GetTaskString).ToList();
        }

        public List<string> GetIncomplete()
        {
            return _todoList.Keys.Where(task => !_todoList[task]).Select(GetTaskString).ToList();
        }

        public string Get(string task)
        {
            if (_todoList.ContainsKey(task)) return GetTaskString(task);

            return "Task not found";
        }

        public bool RemoveTask(string task)
        {
            return _todoList.Remove(task);
        }
        public List<string> GetSortedTaskList()
        {
            return TaskList.OrderBy(x => x).ToList();
        }

        public List<string> GetSortedTaskList(bool asc)
        {
            return asc ? GetSortedTaskList() : TaskList.OrderBy(x => x).Reverse().ToList();
        }

        public List<string> TaskList { get { return _todoList.Select(item => GetTaskString(item.Key)).ToList(); } }

        private string GetTaskString(string task)
        {
            return $"{task} - {(_todoList[task] ? "completed" : "not completed")}";
        }

    }
}

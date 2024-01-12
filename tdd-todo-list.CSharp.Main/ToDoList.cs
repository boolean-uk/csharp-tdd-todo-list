using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _toDoList = new Dictionary<string, bool>();
        public Dictionary<string, bool> ToDoList { get { return _toDoList; } }

        public void Add(string task, bool complete = false)
        {
            _toDoList.Add(task, complete);
        }
        public List<string> Show()
        {
            List<string> result = new List<string>();
            foreach (KeyValuePair<string, bool> task in _toDoList)
            {
                if (task.Value) result.Add($"{task.Key}   COMPLETED");
                else result.Add($"{task.Key}   NOT COMPLETED");
            }
            return result;
        }

        public string Search(string task, out bool complete)
        {
            if (_toDoList.ContainsKey(task))
            {
                complete = _toDoList[task];
                return task;
            }
            complete = false;
            return $"{task} doesn't exist";
        }
        public void Remove(string task)
        {
            _toDoList.Remove(task);
        }
        public void OrderAscending()
        {
            _toDoList.Order();
        }

        public void OrderDescending()
        {
            _toDoList.OrderDescending();
        }
        /// <summary>
        /// Returns false when task doesn't exist, true otherwise
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool ToggleCompletion(string task)
        {
            if (!_toDoList.ContainsKey(task)) return false;
            _toDoList[task] = !_toDoList[task];
            return true;
        }

        public Dictionary<string, bool> CompletedTasks()
        {
            Dictionary<string, bool> result = new Dictionary<string, bool>();
            foreach (KeyValuePair<string, bool> task in _toDoList)
            {
                if (task.Value) result.Add(task.Key, task.Value);
            }
            return result;
        }
        public Dictionary<string, bool> IncompleteTasks()
        {
            Dictionary<string, bool> result = new Dictionary<string, bool>();
            foreach (KeyValuePair<string, bool> task in _toDoList)
            {
                if (!task.Value) result.Add(task.Key, task.Value);
            }
            return result;
        }

    }

}

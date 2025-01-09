using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _todoList = new Dictionary<string, bool>();

        public TodoList()
        {

        }

        public void Add(string task)
        {
            _todoList.Add(task, false);
        }

        public List<string> ListAllTasks()
        {
            return new List<string>(_todoList.Keys);
        }

        public void ChangeStatus(string task)
        {
            _todoList[task] = !_todoList[task];
        }

        public List<string> GetComplete()
        {
            List<string> completed = new List<string>();

            foreach (KeyValuePair<string, bool> task in _todoList)
            {
                if (task.Value)
                    completed.Add(task.Key);
            }

            return completed;
        }

        public List<string> GetIncomplete()
        {
            List<string> incompleted = new List<string>();

            foreach (KeyValuePair<string, bool> task in _todoList)
            {
                if (!task.Value)
                    incompleted.Add(task.Key);
            }

            return incompleted;
        }

        public string SearchTask(string task)
        {
            if (_todoList.ContainsKey(task))
                return "Task found.";
            return "Task not found.";
        }

        public void Remove(string task)
        {
            if (_todoList.ContainsKey(task))
                _todoList.Remove(task);
        }

        public List<string> OrderAsc()
        {
            List<string> list = new List<string>(_todoList.Keys);
            list.Sort();
            return list;
        }

        public List<string> OrderDesc()
        {
            List<string> list = new List<string>(_todoList.Keys);
            list.Sort((a, b) => b.CompareTo(a));
            return list;
        }

        public Dictionary<string, bool> todoList { get { return _todoList; } }
    }
}

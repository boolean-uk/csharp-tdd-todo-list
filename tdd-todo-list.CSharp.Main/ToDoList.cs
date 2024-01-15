using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _TaskList =[];
        
        
        public void addTask(string task)
        {
            _TaskList.Add(task,false);
        }
        public void addTask(string task, bool completed)
        {
            _TaskList.Add(task, completed);
        }

        public List<string> getTotalList()
        {
            List<string> list = new List<string>();
            foreach (var key in _TaskList.Keys)
            {
                list.Add(key);
            }
            return list;
        }

        public List<string> getIncomplete()
        {
            List<string> IncompleteStrings = new List<string>();
            
            foreach(string key in _TaskList.Keys)
            {
                if (_TaskList[key] == false)
                {
                    IncompleteStrings.Add(key);
                }
            }

            return IncompleteStrings;
        }

        public List<string> getCompleted()

        {
            List<string> CompletedStrings = new List<string>();

            foreach (string key in _TaskList.Keys)
            {
                if (_TaskList[key] == true)
                {
                    CompletedStrings.Add(key);
                }
            }

            return CompletedStrings;
        }

        public string findTask(string task)
        {
            string message = string.Empty;
            if (_TaskList.ContainsKey(task))
            {
                message = $"You have the task {task} in your list";
            }
            else
            {
                message = "The requested task wasn't found in your list";
            }

            return message;
        }

        public bool removeTask(string task)
        {
            if (_TaskList.ContainsKey(task)) {
                _TaskList.Remove(task);
                return true;
            }
            else { return false; }

        }

        public List<string> getListAscending()
        {
            List<string> orderedList = _TaskList.Keys.OrderBy(x => x).ToList();

            return orderedList;
        }
        public List<string> getListDescending()
        {
            List<string> orderedList = _TaskList.Keys.OrderByDescending(x => x).ToList();
            return orderedList;
        }

        public Dictionary<string,bool> TaskList {
            get { return _TaskList; } 
            set { _TaskList = value; }  // set method 
        }
    }
}

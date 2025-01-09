using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, string> _taskList;

        public TodoList()
        {
            _taskList = new Dictionary<string, string>();

            _taskList.Add("Dishes", "Complete");
            _taskList.Add("Laundry", "Incomplete");
            _taskList.Add("Grocery Shopping", "Incomplete");
            _taskList.Add("Smile", "Complete");
            _taskList.Add("AA", "Complete");
            _taskList.Add("BB", "Complete");
            _taskList.Add("CC", "Complete");




        }

        public bool AddTask(string taskDescription)
        {
            if (_taskList.ContainsKey(taskDescription)){
                return false;
            } else {
                _taskList.Add(taskDescription, "Incomplete");
                return true;
            }
                    
        }

        public bool RemoveTask(string taskDescription)
        {

            if (_taskList.ContainsKey(taskDescription))
            {
                _taskList.Remove(taskDescription);
                return true;
            }

            return false;
        }
          
        public string viewTasks()
        {

            string list = "";

            _taskList.ToList().ForEach(task =>
            {
                list += task.Key + " - " + task.Value + "\n";
            });

            return list;
        }

        public bool UpdateTask(string taskDescription) 
        {
            if (_taskList[taskDescription] == "Incomplete") {
                _taskList[taskDescription] = "Complete";
                return true;
            }
            else if (_taskList[taskDescription] == "Complete")
            {
                _taskList[taskDescription] = "Incomplete";
                return true;
            }
            return false;
        }

        public string viewCompletedTasks()
        {

            string list = "";

            _taskList.ToList().ForEach(task =>
            {
                if (task.Value == "Complete")
                {
                    list += task.Key + " - " + task.Value + "\n";
                }
                
            });

            return list;
        }

        public string viewIncompletedTasks()
        {

            string list = "";

            _taskList.ToList().ForEach(task =>
            {
                if (task.Value == "Incomplete")
                {
                    list += task.Key + " - " + task.Value + "\n";
                }

            });

            return list;
        }

        public string SearchTask(string taskDescription)
        {
            string theTask = "";

            _taskList.ToList().ForEach(task =>
            {
                if (_taskList.ContainsKey(taskDescription)) 
                {
                    theTask = taskDescription + " - " + _taskList[taskDescription];

                }

            });

            return theTask;
        }

        public List<KeyValuePair<string, string>> SortAscTask()
        {
            return _taskList.OrderBy(task => task.Key).ToList();
        }


        public List<KeyValuePair<string, string>> SortDescTask()
        {
            return _taskList.OrderByDescending(task => task.Key).ToList();
        }

    }
}

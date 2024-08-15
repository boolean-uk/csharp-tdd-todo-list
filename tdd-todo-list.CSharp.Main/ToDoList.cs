using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _taskList = new Dictionary<string, bool>();
        public Dictionary<string, bool> TaskList { get { return this._taskList; } }

        public void Add(string task, bool isComplete)
        {
            _taskList.Add(task, isComplete);
        }

        public bool ChangeStatus(string task, bool isComplete)
        {
            if (_taskList.ContainsKey(task))
            {
                _taskList[task] = isComplete;

                return true;
            }

            return false;
        }

        public Dictionary<string, bool> GetCompleteTasks()
        {
            return _taskList.Where(task => task.Value == true).ToDictionary();
        }

        public Dictionary<string, bool> GetIncompleteTasks()
        {
            return _taskList.Where(task => task.Value == false).ToDictionary();
        }

        public Dictionary<string, bool> GetList()
        {
            return TaskList;
        }

        public Dictionary<string, bool> GetListInAscendingOrder()
        {

            var ordered = _taskList.OrderBy(task => task.Key).ToDictionary(x => x.Key, x => x.Value);

            return ordered;
        }

        public Dictionary<string, bool> GetListInDescendingOrder()
        {
            var ordered = _taskList.OrderByDescending(task => task.Key).ToDictionary(x => x.Key, x => x.Value);

            return ordered;
        }

        public bool Remove(string task)
        {
            if (_taskList.ContainsKey(task))
            {
                _taskList.Remove(task);
                return true;
            } else
            {
                return false;
            }
        }

        public Dictionary<string, bool> SearchFor(string task)
        {
            Dictionary <string, bool> relevantTasks = new Dictionary<string, bool>();
            
            foreach (var tasks in _taskList)
            {
                if (tasks.Key.Contains(task))
                {
                    relevantTasks.Add(tasks.Key, tasks.Value);
                }
            }

            return relevantTasks;
        }
    }
}

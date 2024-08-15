using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private string _complete = " | Complete\n";
        private string _incomplete = " | Incomplete\n";
        Dictionary<string, bool> tasks = new Dictionary<string, bool>();

        private string _List(Dictionary<string, bool> taskList)
        {
            string output = string.Empty;
            foreach (var task in taskList)
            {
                if (task.Value)
                {
                    output += task.Key + _complete;
                }
                else
                {
                    output += task.Key + _incomplete;
                }
            }
            return output;
        }
        public bool Add(string task)
        {
            if (tasks.ContainsKey(task))
            {
                return false;
            }
            tasks.Add(task, false);
            return true;
        }

        public bool ChangeStatus(string task, bool status)
        {
            if (tasks.ContainsKey(task))
            {
                tasks[task] = status;
                return true;
            }
            return false;
        }

        public string List()
        {
            return _List(tasks);
        }

        public string ListAscending()
        {
            return _List(tasks.OrderBy(x => x.Key).ToDictionary());
        }

        public string ListCompleteTasks()
        {
            string output = string.Empty;
            foreach(var task in tasks)
            {
                if (task.Value)
                {
                    output += task.Key + _complete;
                }
            }
            return output;
        }

        public string ListIncompleteTasks()
        {
            string output = string.Empty;
            foreach(var task in tasks)
            {
                if(!task.Value)
                {
                    output += task.Key + _incomplete;
                }
            }
            return output;
        }

        public bool Remove(string task)
        {
            if (tasks.ContainsKey(task))
            {
                tasks.Remove(task);
                return true;
            }
            return false;
        }

        public string Search(string task)
        {
            if(tasks.ContainsKey(task))
            {
                return "Task found!";
            }
            return "Task does not exist!";
        }
    }
}

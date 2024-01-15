using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public Dictionary<string, int> Tasks = new Dictionary<string, int>();

        public bool AddTask(string task) {
        if (!Tasks.ContainsKey(task))
        {
            Tasks.Add(task, 0);
            return true;
        }
        return false;
        }

        public bool ChangeStatus(string task, int status) {
            if(Tasks.Count == 0)
                return false;
            foreach (string item in Tasks.Keys)
            {
                if(item == task) {
                    if (Tasks[task] == 1)
                        Tasks[task] = 0;
                    else
                        Tasks[task] = 1;
                    return true;
                }
            }
            return false;
        }

        public Dictionary<string, int> GetTasks() {
            return Tasks;
        }

        public List<string> GetTasksByStatus(int status) {
            
            List<string> completed = new List<string>();

            foreach (string item in Tasks.Keys)
            {
                if(Tasks[item] == status) {
                    completed.Add(item);
                }
            }
            return completed;
        }

        private string DoExist(string task) {
            if(Tasks.ContainsKey(task)) {
                return task;
            }
            return "";
        }

        public string Search(string task) {
            if(DoExist(task) == "")
                return "Not Found";
            return "Exists";
        }

        public bool RemoveTask(string task) {
            if(DoExist(task) == task) {
                Tasks.Remove(task);
                return true;
            }
            return false;
        }

        public List<string> OrderAlphabetically() {
            List<string> temp = new List<string>(Tasks.Keys);
            temp.Sort();
            return temp;
        }

        public List<string> OrderByDescending() {
            return [.. Tasks.Keys.OrderByDescending(x => x)];
        }
    }
}

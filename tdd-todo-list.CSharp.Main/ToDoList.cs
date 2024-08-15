using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        private Dictionary<string, int> taskList = new Dictionary<string, int>();

        public bool Add(string task, int status)
        {
            //if not in dict -> add
            if(!taskList.ContainsKey(task))
            {
                taskList.Add(task, status);
                return true;
            }
            return false;
        }

        public List<string> GetTaskList()
        {
            List<string> tasks = new List<string>();

            foreach (string task in taskList.Keys)
            {
                tasks.Add(task);
            }
            
            return tasks;
        }
    }
}

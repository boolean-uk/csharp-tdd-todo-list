using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, string> TaskList;
        public TodoList()
        {
            TaskList = new Dictionary<string, string>();
        }

        public void AddTask(string task)
        {
            TaskList.Add(task, "incomplete");

        }

        public int getTodoCount()
        {
            return TaskList.Count;
        }

        public void DisplayTasks()
        {

            foreach (string task in TaskList.Keys)
            {
                Console.WriteLine($"{task} : {TaskList[task]}");

            }


        }

        public bool ContainsTask(string task, string status)
        {
            return TaskList[task] == status;
        }

        public void ChangeStatus(string task, string status)
        {
            if (TaskList.ContainsKey(task))
            {
                TaskList[task] = status;
            }
            else
            {
                throw new Exception("The task you want to change doesnt exist.");
            }
        }

        public List<string> GetCompletedTask()
        {
            List<string> CompletedTasks = new List<string>();

            foreach (string key in TaskList.Keys)
            {
                if (TaskList[(key)] == "complete")
                {
                    CompletedTasks.Add(key);
                }
            }
            return CompletedTasks;
        }

        public List<string> GetInCompletedTask()
        {
            List<string> InCompletedTasks = new List<string>();

            foreach (string key in TaskList.Keys)
            {
                if (TaskList[(key)] == "incomplete")
                {
                    InCompletedTasks.Add(key);
                }
            }
            return InCompletedTasks;
        }

        public string RetrieveTask(string task)
        {
            if (!TaskList.ContainsKey(task))
            {
                return "The task has not been created yet";
            }

            return $"{task} : {TaskList[task]}";
        }

        public void RemoveTask(string task)
        {
            TaskList.Remove(task);
        }

        public bool TaskExists(string task)
        {
            return TaskList.ContainsKey(task);
        }

        public List<string> AscendingOrder()
        {
            List<string> returnlist = new List<string>();

            foreach (string key in TaskList.Keys)
            {
                returnlist.Add(key);
            }

            returnlist.Sort((x, y) => string.Compare(x, y));

            return returnlist;
        }

        public List<string> DescendingOrder()
        {
            List<string> returnlist = new List<string>();

            foreach (string key in TaskList.Keys)
            {
                returnlist.Add(key);
            }

            returnlist.Sort((x, y) => string.Compare(y, x));

            return returnlist;
        }

        
    }
}

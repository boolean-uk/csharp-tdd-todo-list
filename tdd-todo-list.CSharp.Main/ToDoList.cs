using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        public Dictionary<string, bool> tasks;

        public TodoList()
        {
            tasks = new Dictionary<string, bool>();
        }

        public void AddTask(string task)
        {
            tasks.Add(task, false);
        }
        
        public List<string> GetAllTasks()
        {
            return new List<string>(tasks.Keys);
        }

        public void ChangeTaskStatus(string task, bool isComplete)
        {
            if (tasks.ContainsKey(task))
            {
                tasks[task] = isComplete;
            }
        }

        public List<string> GetCompleteTasks()
        {
            List<string> completeTasks = new List<string>();
            foreach (var task in tasks)
            {
                if (task.Value)
                {
                    completeTasks.Add(task.Key);
                }
            }
            return completeTasks;
        }
        
        public List<string> GetIncompleteTasks()
        {
            List<string> incompleteTasks = new List<string>();
            foreach (var task in tasks)
            {
                if (!task.Value)
                {
                    incompleteTasks.Add(task.Key);
                }
            }
            return incompleteTasks;
        }

        public bool SearchTask(string task)
        {
            return tasks.ContainsKey(task);
        }

        public void RemoveTask(string task)
        {
            if (tasks.ContainsKey(task))
            {
                tasks.Remove(task);
            }
        }

        public List<string> GetAllTasksOrderedAscending()
        {
            List<string> orderedTasks = new List<string>(tasks.Keys);
            orderedTasks.Sort();
            return orderedTasks;
        }

        public List<string> GetAllTasksOrderedDescending()
        {
            List<string> orderedTasks = new List<string>(tasks.Keys);
            orderedTasks.Sort();
            orderedTasks.Reverse();
            return orderedTasks;
        }


    }
}

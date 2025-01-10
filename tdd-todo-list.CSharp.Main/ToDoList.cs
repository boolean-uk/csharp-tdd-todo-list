using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public List<Task> tasks;

        public TodoList()
        {
            this.tasks = new List<Task>();
        }

        public Task AddTask(string name)
        {
            Task createdTask = new Task(name);
            tasks.Add(createdTask);
            return createdTask;
        }

        public string showTasks()
        {
            string allTasksFormattedToPrint = "";
            foreach(Task task in tasks)
            {
                allTasksFormattedToPrint += $"{task._name} - {task._status} \n";
            }
            return allTasksFormattedToPrint;
        }

        public string showCompleteTasks()
        {
            string allCompletedTasksFormattedToPrint = "";
            foreach(Task task in tasks)
            {
                if(task._status)
                {
                    allCompletedTasksFormattedToPrint += $"{task._name} - {task._status} \n";
                }
            }
            return allCompletedTasksFormattedToPrint;
        }

        public string showIncompleteTasks()
        {
            string allCompletedTasksFormattedToPrint = "";
            foreach (Task task in tasks)
            {
                if (!task._status)
                {
                    allCompletedTasksFormattedToPrint += $"{task._name} - {task._status} \n";
                }
            }
            return allCompletedTasksFormattedToPrint;
        }
        public string search(string name)
        {
            var task = tasks.Find(x => x._name == name);
            return task != null ? "Found" : "NotFound";
        }


        // Returns true if removed one or more item
        public bool delete(string name)
        {    
            return tasks.RemoveAll(task => task._name == name) >= 1;
        }

        public void OrderTasksAsc()
        {
            if (tasks.Count > 0)
            {
                tasks.Sort((a, b) => a._name.CompareTo(b._name));
            }
        }

        public void OrderTasksDsc()
        {
            if (tasks.Count > 0)
            {
                tasks.Sort((a, b) => b._name.CompareTo(a._name));
            }
        }


    }
}

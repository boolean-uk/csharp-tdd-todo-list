using NUnit.Framework;
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

        public TodoList() { 
            this.tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            this.tasks.Add(task);
        
        }

        public void ShowTasks()
        {
            foreach (Task task in  this.tasks)
            {
                Console.WriteLine(task.ToString());
            }
        }

        public bool ChangeStatus(Task task)
        {
            if (this.tasks.Contains(task)){
                task.isComplete = !task.isComplete;
                return true;
            }
            return false; 
        }

        public List<Task> GetComplete()
        {
            List<Task> completedTasks = new List<Task>();
            foreach (Task task in this.tasks)
            {
                if (task.isComplete)
                {
                    completedTasks.Add(task);
                }
            }
            return completedTasks;
        }

        public List<Task> GetIncomplete()
        {
            List<Task> incompleteTasks = new List<Task>();
            foreach (Task task in this.tasks)
            {
                if (!task.isComplete)
                {
                    incompleteTasks.Add(task);
                }
            }
            return incompleteTasks;
        }

        public string SearchTask(Task task)
        {
            if (this.tasks.Contains(task))
            {
                return task.name;
            }
            return "The task was not found";
        }

        public string RemoveTask(Task task)
        {
            if (this.tasks.Contains(task))
            {
                this.tasks.Remove(task);
                return $"{task.name} removed from Todo List";
            }
            return "The task was not found";
        }

        public List<Task> SortAsc()
        {
            List<Task> sortedList = this.tasks.OrderBy(task => task.name).ToList();
            return sortedList;
        }

        public List<Task> SortDesc()
        {
            List<Task> sortedList = [.. this.tasks.OrderByDescending(task => task.name)];
            return sortedList;
        }
    }
}

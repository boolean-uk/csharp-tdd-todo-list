using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    
    public class TodoList
    {
        public List<Task> tasks {  get; set; }

        public TodoList()
        {
            tasks = new List<Task>();

        }


       
        public Task Add(string title, string description)
        {
            // Tasks needs different titles
            if (tasks.Where(x => x.title == title).Any() || title == "")
            {
                return new Task("", "");
            }
            Task taskToAdd = new Task(title, description);
            tasks.Add(taskToAdd); 
            return new Task(taskToAdd);
        }

        public List<Task> GetTasks()
        {
            return new List<Task>(tasks);
        }

        public Task GetTask(string title)
        {
            Task? queried_task = tasks.FirstOrDefault(x => x.title == title) ?? new Task("", "");
            
            return new Task(queried_task);
        }

        public Task ChangeTask(string title, bool status)
        {
            Task? taskToUpdate = tasks.FirstOrDefault(x => x.title == title) ?? new Task("", "");
            taskToUpdate.status = status;
            return new Task(taskToUpdate);
        }

        public List<Task> GetCompletedTasks()
        {
            List<Task>? completedTasks = tasks.Where(x => x.status).ToList() ?? new List<Task>();
            return new List<Task>(completedTasks);
        }

        public List<Task> GetIncompleteTasks()
        {
            List<Task>? completedTasks = tasks.Where(x => !x.status).ToList() ?? new List<Task>();
            return new List<Task>(completedTasks);
        }

        

        public Task RemoveTask(string title)
        {
            Task? taskToRemove = tasks.FirstOrDefault(x => x.title == title) ?? new Task("", "");
            if (taskToRemove.title == "")
            {
                return taskToRemove;
            }
            tasks.Remove(taskToRemove);
            return new Task(taskToRemove);
        }

        public List<Task> SortTasksAlphabetically(bool ascending)
        {
            List<Task> sortedTasks = new List<Task> ();
            if (ascending)
            {
                sortedTasks = tasks.OrderBy(x => x.title).ToList();
            }
            else
            {
                sortedTasks = tasks.OrderByDescending(x => x.title).ToList();
            }

            return new List<Task>(sortedTasks);
        }

       
    }

    public class Task
    {
        public string title {  get; set; }
        public string description { get; set; }
        public bool status { get; set; }

        public Task(string title, string description)
        {
            this.title = title;
            this.description = description;
            status = false;
        }

        public Task(Task t)
        {
            this.title = t.title;
            this.description = t.description;
            status = t.status;
        }


        public bool Equals(Task other)
        {
            return this.title == other.title; //Check whether the identifier of a task are equal
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{

    // task 
    public class Task
    {

        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public Task(string name)
        {
            Name = name;
            IsComplete = false;
        }


    }

    // list of tasks to do
    public class TodoList
    {
        private List<Task> tasks;

        public TodoList()
        {
            tasks = new List<Task>();
        }

        // add new task to the list

        public void AddTask(string taskName)
        {
            tasks.Add(new Task(taskName));
        }

        // return the number of tasks in the list
        public int Count => tasks.Count;

        // return the task with index

        public Task GetTask(int index)
        {
            return tasks[index]; 
        }

        // return the task with Name

        public Task GetTask(string taskName)
        {
            return tasks.FirstOrDefault(t => t.Name == taskName);
        }

        // return all the tasks
        public List<Task> GetAllTasks() 
        {
            return tasks;
        }


        // change the task status
        public void ChangeTaskStatus(string taskName, bool status)
        {
            var task = GetTask(taskName);
            if (task != null)
            {
                task.IsComplete = status;
            }
        }

        // return completed tasks
        public List<Task>GetCompletedTasks()
        {
            return tasks.Where(t => t.IsComplete).ToList();
        }

        
        // return incompleted tasks
        public List<Task>GetIncompletedTasks()
        {
            return tasks.Where(t => !t.IsComplete).ToList();
        }

        // return message is task is not found

        public string SearchTask(string taskName)
        {
            return tasks.Any(t => t.Name == taskName) ? "Task is found!" : "Task is not found!";
        }

        // remove task

        public void RemoveTask(string taskName)
        {
            var task = tasks.FirstOrDefault(task => task.Name == taskName);
            if (task != null)
            {
                tasks.Remove(task);
            }
        }
    }

}

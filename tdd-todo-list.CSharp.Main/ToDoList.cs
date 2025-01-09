using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        List<Task> tasks = new List<Task>();

        public int ListLength()
        {
            return tasks.Count;
        }
        public List<Task> GetAllTasks()
        {
            return tasks;
        }

        public void AddTask(string description)
        {
            Task newTask = new Task();
            newTask.description = description;
            newTask.completed = false;
            tasks.Add(newTask);
        }
        public void Completed(Task task)
        {
            task.completed = true;
        }
        public void Uncompleted(Task task)
        {
            task.completed = false;
        }
        public List<Task> GetCompletedTasks()
        {
            List<Task> result = new List<Task>();
            foreach (Task task in tasks)
            {
                if (task.completed)
                {
                    result.Add(task);
                }
            }
            return result;
        }
        public List<Task> GetIncompletedTasks()
        {
            List<Task> result = new List<Task>();
            foreach (Task task in tasks)
            {
                if (!task.completed)
                {
                    result.Add(task);
                }
            }
            return result;
        }
        //returns a Task objekt if task was found, else return a string message
        public Task SearchTask(string description)
        {
            foreach (Task task in tasks)
            {
                if (task.description == description)
                {
                    return task;
                }
            }
            Console.WriteLine("the requested task was not found in the ToDo list");
            return new Task(); //returns empty task if no task found
        }
        //returns true if removal succesfull, else false
        public bool RemoveTask(Task task)
        {
            Object? toRemove = tasks.Where(x => x.Equals(task));
            if (toRemove != null)
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    if (tasks[i].Equals(task))
                    {
                        tasks.RemoveAt(i);
                        return true;
                    }
                }

            }
            return false;
        }
        public List<Task> GetAllTasksAscending()
        {
            List<Task> sorted = tasks.OrderBy(x => x.description).ToList();
            return sorted;
        }
        public List<Task> GetAllTasksDescening()
        {
            List<Task> sorted = tasks.OrderBy(x => x.description).ToList();
            sorted.Reverse();   
            return sorted;
        }
    }
}
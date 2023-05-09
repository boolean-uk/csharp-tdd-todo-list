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


        // check if task status
        public void TaskStatus(string taskName, bool status)
        {
            var task = GetTask(taskName);
            if (task != null)
            {
                task.IsComplete = status;
            }
        }

        

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{ 
    public class Task
    {
        public int Id { get; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime DateTime { get; set; }

        public Task(int id, string name, bool status, DateTime creationDateTime)
        {
            Id = id;
            Name = name;
            Status = status;
            DateTime = creationDateTime;
        }
    }

    public class TodoListExtension
    {
        private List<Task> tasks;

        public TodoListExtension()
        {
            tasks = new List<Task>();
        }

        public void AddTask(string name)
        {
            int newId = tasks.Count + 1;
            Task newTask = new Task(newId, name, false, DateTime.Now);
            tasks.Add(newTask);
        }

        public List<Task> GetTasks()
        {
            return tasks;
        }

        public Task GetTaskById(int id)
        {
            return tasks.FirstOrDefault(task => task.Id == id);
        }

        public void UpdateTaskName(string name, int id)
        {
            Task taskToUpdate = tasks.FirstOrDefault(task => task.Id == id);

            if (taskToUpdate != null)
            {
                taskToUpdate.Name = name;
            }
            else
            {
                Console.WriteLine("Task not found with the given ID.");
            }
        }

        public void UpdateTaskStatus(int id)
        {
            Task taskToUpdate = tasks.FirstOrDefault(task => task.Id == id);

            if(taskToUpdate != null)
            {
                taskToUpdate.Status = true; 
            }
            else
            {
                Console.WriteLine("Task not found with the given ID.");     
            }

        }
    }
}

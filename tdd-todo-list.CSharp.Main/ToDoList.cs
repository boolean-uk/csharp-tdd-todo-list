using System;
using System.Collections.Generic;
using System.Linq;

namespace tdd_todo_list.CSharp.Main
{
    public class ToDoList
    {
        private List<Task> tasks;

        public ToDoList()
        {
            tasks = new List<Task>();
        }

        public List<Task> ToggleStatusAndGetCompletedTasks(string[] taskTitles)
        {
            List<Task> completedTasks = new List<Task>();

            foreach (var title in taskTitles)
            {
                Task taskToComplete = SearchTask(title);

                if (taskToComplete != null)
                {
                    taskToComplete.ToggleStatus(); // Toggles status to completed
                    completedTasks.Add(taskToComplete);
                }
            }

            return completedTasks;
        }


        public void AddTask(string title, string description)
        {
            Task newTask = new Task(title, description);
            tasks.Add(newTask);
            Console.WriteLine($"Added task: {newTask}");
        }

        public void RemoveTask(string title)
        {
            Task taskToRemove = tasks.FirstOrDefault(task => task.Title == title);
            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
                Console.WriteLine($"Removed task: {taskToRemove.Title}");
            }
            else
            {
                Console.WriteLine($"Task with title '{title}' not found.");
            }
        }

        public List<Task> GetAllTasks()
        {
            return new List<Task>(tasks);
        }

        public List<Task> GetCompletedTasks()
        {
            return tasks.Where(task => task.IsComplete).ToList();
        }

        public List<Task> GetIncompleteTasks()
        {
            return tasks.Where(task => !task.IsComplete).ToList();
        }

        public Task SearchTask(string title)
        {
            return tasks.FirstOrDefault(task => task.Title == title);
        }

        public List<Task> OrderByTitleAscending()
        {
            return tasks.OrderBy(task => task.Title).ToList();
        }

        public List<Task> OrderByTitleDescending()
        {
            return tasks.OrderByDescending(task => task.Title).ToList();
        }

        public void DisplayAllTasks()
        {
            Console.WriteLine("All Tasks:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        public static void Main()
        {
            // Example usage
            ToDoList todoList = new ToDoList();

            // Adding tasks
            todoList.AddTask("Task 1", "Description for Task 1");
            todoList.AddTask("Task 2", "Description for Task 2");
            todoList.AddTask("Task 3", "Description for Task 3");

            // Displaying all tasks
            todoList.DisplayAllTasks();

            // Changing status of Task 1 to complete
            Task task1 = todoList.SearchTask("Task 1");
            if (task1 != null)
            {
                task1.ToggleStatus();
                Console.WriteLine($"Changed status of {task1.Title} to complete.");
            }

            // Displaying completed tasks
            Console.WriteLine("Completed Tasks:");
            foreach (var completedTask in todoList.GetCompletedTasks())
            {
                Console.WriteLine(completedTask);
            }
        }
    }
}

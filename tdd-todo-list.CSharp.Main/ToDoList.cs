using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList  // list for tasks
    {
        public List<TodoTask> Tasks { get; private set; } = new List<TodoTask>();

        public int NextTaskId { get; set; } = 1; //setting id

        public void AddATask(TodoTask task) // method for adding task
        {
            task.Id = NextTaskId++;
            Tasks.Add(task);
        }

        public List<TodoTask> GetTask() // method to get all tasks
        {
            return Tasks;
        }

        public TodoTask FindATask(string nameOfTask) //added linq https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.firstordefault?view=net-7.0 for finding the task
        {
            return Tasks.FirstOrDefault(t => t.Title == nameOfTask); //lambda expression with t from task
        }

        public void RemoveATask(TodoTask task) // method for removing task
        {
            Tasks.Remove(task);
        }

        public List<TodoTask> GetCompleteTask() //method for getting complete task with IsCompleted https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.iscompleted?view=net-7.0
        {
            return Tasks.Where(t => t.IsCompleted).ToList();
        }

        public List<TodoTask> GetIncompleteTask() // method to get incomplete tasks
        {
            return Tasks.Where(t => !t.IsCompleted).ToList();
        }

        public List<TodoTask> TaskAscendingOrder() //method to order tassk in ascending order https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby?view=net-7.0
        {
            return Tasks.OrderBy(t => t.Title).ToList();
        }
        //method to order tasks in descending order  https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderbydescending?view=net-7.0
        public List<TodoTask> TaskDescendingOrder()
        {
            return Tasks.OrderByDescending(t => t.Title).ToList();
        }
    }

    public class TodoTask
    {
        public int Id { get; set; } //id for every task
        public string Title { get; set; } // title of task
        public bool IsCompleted { get; set; } // status of task

        public TodoTask(string title) // constructor for starting task
        {
            Title = title;
            IsCompleted = false;
        }

        public void ChangeTask (bool isComplete)
        {
            IsCompleted = isComplete;
        }
    }
}

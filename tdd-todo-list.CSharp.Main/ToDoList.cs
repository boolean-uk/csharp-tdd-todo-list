using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }

        public TodoTask(string inputName, bool inputIsCompleted)
        {
            Name = inputName;
            IsCompleted = inputIsCompleted;
        }

        //Seems I have to add this code block below to be able to compare two lists with objects in them
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            TodoTask other = (TodoTask)obj;
            return Name == other.Name && IsCompleted == other.IsCompleted;
        }

        public override int GetHashCode()
        {
            return (Name, IsCompleted).GetHashCode();
        }
    }

    public class TodoList
    {
        private List<TodoTask> tasks;
        public TodoList(){
            tasks = new List<TodoTask>();
        }
        public bool AddTask(string name){
            bool taskExists = tasks.Any(task => task.Name == name);

            if (taskExists)
            {
                return false;
            }

            tasks.Add(new TodoTask(name, false));

            return true;
        }
        public bool RemoveTask(string name){

            int removedCount = tasks.RemoveAll(task => task.Name == name);

            return removedCount > 0;
        }
        public string TaskExists(string name)
        {
            bool taskExists = tasks.Any(task => task.Name == name);

            if (taskExists)
            {
                return "Task found in todo list";

            }   
            return "Task not found in list";

        }
        public bool ToggleComplete(string name){
            bool taskExists = tasks.Any(task => task.Name == name);

            if (taskExists)
            {
                foreach (var task in tasks)
                {
                    if (task.Name == name)
                    {
                        task.IsCompleted = !task.IsCompleted;
                    }
                }
                return true;
            }   

            return false;

        }
        public List<TodoTask> ShowAllTasks(){
            return tasks;
        }

        public List<TodoTask> ShowCompletedTasks(){
            List<TodoTask> newList = new List<TodoTask>();
            foreach (var task in tasks)
            {
               if (task.IsCompleted){
                newList.Add(task);
               }
            }
            return newList;
        }

        public List<TodoTask> ShowIncompletedTasks(){
            List<TodoTask> newList = new List<TodoTask>();
            foreach (var task in tasks)
            {
               if (!task.IsCompleted){
                newList.Add(task);
               }
            }
            return newList;
        }

        public List<TodoTask> SortedTasksAsc(){
            List<TodoTask> SortedList = tasks.OrderBy(o=>o.Name).ToList();

            return SortedList;
        }
        public List<TodoTask> SortedTasksDesc(){
            List<TodoTask> SortedList = tasks.OrderByDescending(o=>o.Name).ToList();

            return SortedList;
        }
    }
}

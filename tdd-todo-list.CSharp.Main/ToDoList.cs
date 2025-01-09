using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public List<Task> todolist = new List<Task>();


        public string Add(string Task)
        {
            Task task = new Task(Task);
            todolist.Add(task);
            return task.ToString();
        }
        public Task Add(Task task)
        {
            todolist.Add(task);
            return task;
        }

        public string ChangeStatus(string Task)
        {
            foreach (var item in todolist)
            {
                if (item.task.ToLower().Contains(Task.ToLower()))
                {
                    item.isCompleted = !item.isCompleted;
                    return $"{item.task} went from {item.isCompleted} to {!item.isCompleted}";
                }
            }
            return "Task not found";
        }

        public object Remove(string taskToRemove)
        {
            var task = todolist.FirstOrDefault(t => t.task.Equals(taskToRemove));
            if (task != null)
            {
               todolist.Remove(task);
                return task;
            }
            return "Task not found";
        }

        public object Search(string taskToFind)
        {
            var task = todolist.FirstOrDefault(t => t.task.Equals(taskToFind));
            if(task == null)
            {
                return "Task not found";
            }
            return task;
        }

        public List<Task> ViewCompletedTasks()
        {
            return todolist.Where(item => item.isCompleted == true).ToList();
        }

        public List<Task> ViewInCompletedTasks()
        {
            return todolist.Where(item => item.isCompleted == false).ToList();
        }

        public List<string> ViewTasks()
        {
            return todolist.Select(task => task.ToString()).ToList();
        }
    }
}

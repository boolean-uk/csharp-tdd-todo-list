using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<TaskItem> _tasks = new List<TaskItem>();

        public TodoList()
        {
         
        
        }
       

        public void AddTask(TaskItem task)
        {
            _tasks.Add(task);
        }

        public void PrintAllTasks()
        {
            foreach (var task in _tasks)
            {
                Console.WriteLine(task.ToString());
            }
        }

        public List<TaskItem> GetAllTasks()
        {
            return _tasks;
        }

        public void ChangeStatus(TaskItem task)
        {
            task.Status = (task.Status.Equals("incomplete") ? "complete" : "incomplete");
        }

        public List<TaskItem> GetCompletedTasks()
        {
            return _tasks.Where(t => t.Status.Equals("complete")).ToList();
        }

        public List<TaskItem> GetIncompleteTasks()
        {
            return _tasks.Where(t => t.Status.Equals("incomplete")).ToList();
        }

        public void RemoveTask(TaskItem task)
        {
            _tasks.Remove(task);
        }

        public List<TaskItem> GetAllTasksInOrder()
        {
           return _tasks.OrderBy(t => t.Name).ToList();
        }

        public List<TaskItem> GetAllTasksInReverseOrder()
        {
            return _tasks.OrderByDescending(t => t.Name).ToList();
        }

        public void PrintListOfTasks(List<TaskItem> tasks)
        {
            foreach(var task in tasks)
            {
                Console.WriteLine(task.ToString());
            }
        }

        public TaskItem GetTaskById(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }

        public void UpdateNameById(int id, string name)
        {
            TaskItem t = GetTaskById(id);
            t.Name = name;
        }

        public void UpdateStatusById(int id, string status)
        {
            TaskItem t = GetTaskById(id);
            t.Status = status;
        }
    }
    
}

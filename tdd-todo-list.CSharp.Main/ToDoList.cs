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

        //public List<TaskItem> Tasks { get { return _tasks; } }
       

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
            task.StatusComplete = !task.StatusComplete;
            

            task.Completed = task.StatusComplete ? DateTime.Now : DateTime.MaxValue;
        }

        public List<TaskItem> GetCompletedTasks()
        {
            return _tasks.Where(t => t.StatusComplete.Equals("complete")).ToList();
        }

        public List<TaskItem> GetIncompleteTasks()
        {
            return _tasks.Where(t => t.StatusComplete.Equals("incomplete")).ToList();
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

        public List<TaskItem> GetAllTasksSortedByPriority()
        {
            return _tasks.OrderBy(t => t.Priority).ToList();
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
            return _tasks.First(t => t.Id == id);
        }

        public void UpdateNameById(int id, string name)
        {
            
            GetTaskById(id).Name = name;
        }

        public void UpdateStatusById(int id, bool statusComplete)
        {
            TaskItem t = GetTaskById(id);
            t.StatusComplete = statusComplete;

            t.Completed = t.StatusComplete ? DateTime.Now : DateTime.MaxValue;
        }

        public bool DoesTaskExistByName(string name)
        {
            return _tasks.Any(t => t.Name == name);
        }

        public bool DoesTaskExist(TaskItem t)
        {
            return _tasks.Contains(t);
        }
    }
    
}

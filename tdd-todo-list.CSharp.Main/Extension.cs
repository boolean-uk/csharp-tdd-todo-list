using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{    
    public class TodoListExtension
    {
        public List<Task> tasks { get; set; } = new List<Task>();

        public bool ChangeTaskStatus(Guid id, bool newStatus)
        {
            Task? task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.Completed = newStatus;
                return true;
            }
            return false;
        }

        public Task GetTimeOfCreation(Guid id)
        {
            try
            {
                Task? task = tasks.Find(t => t.Id == id);
                return task ?? null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Task? Search(Guid id)
        {
            try 
            {
                Task? task = tasks.Find(t => t.Id == id);
                return task ?? null;
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public bool Update(Guid id, string newTask)
        {
            Task? task = tasks.Find(t => t.Id == id);
            if (task != null) 
            {
                task.Message = newTask;
                return true;
            }
            return false;
        }
    }
}

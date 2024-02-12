using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension()
    {
        
        public List<Task> tasks = new List<Task>();

        public bool FindById(int id)
        {
            bool found = false;
            try
            {
                foreach(Task task in tasks)
                {
                    if (task.Id == id)
                    {
                        found = true;
                        Console.WriteLine($"Found task");
                    }
                    else
                    {
                        found = false;
                        Console.WriteLine($"Could not find task");
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }

            return found;
        }

        public Task updateTaskName (int id, string name)
        {
            var taskToUpdate = tasks.First(t => t.Id == id);

            taskToUpdate.Name = name;

            return taskToUpdate;
        }
        
        public bool changeStatus (int id)
        {
            var task = tasks.Find(t => t.Id == id);
            var taskStatus = false;
            if (task.Complete == true)
            {
                task.Complete = false;
                taskStatus = true;
                Console.WriteLine("Status changed to not completed");
            } else if (task.Complete == false)
            {
                task.Complete = true;
                taskStatus = true;
                Console.WriteLine("Status changed to completed");
            }
            return taskStatus;
        }

        public DateTime Created(Task task)
        {
            return task.CreatedAt;
        }
    }
}

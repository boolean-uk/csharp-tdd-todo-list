using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        List<UserTask> tasks = new List<UserTask>();

        public string Add(UserTask taskname)
        {
            tasks.Add(taskname);
            if (tasks.Contains(taskname))
            {
                return taskname.taskname;
            }
            else
            {
                return "Task not added";
            }
        }

        public string FindTaskById(int id)
        {
            UserTask thistask = tasks.FirstOrDefault(item => item.id == id);
            if (thistask != null) 
            {
                return thistask.taskname+" with ID: "+thistask.id.ToString()+" found!";
            }
            else
            {
                return "Woopsie, no such task found";
            }
        }

        public string ChangeTaskName(int id, string taskname)
        {
            foreach (UserTask task in tasks) 
            {
                if (task.id == id) 
                {
                    task.taskname = taskname;
                    return "Task ID: " + id.ToString() + " is now called: " + taskname;
                }
                else
                {
                    return "Error";
                }
            }
            return "Error";
        }

        public string ChangeStatus(int id)
        {
            return "Nothing";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        List<UserTask> tasks = new List<UserTask>();
        public string Add(UserTask taskname)
        {
            tasks.Add(taskname);
            if (tasks.Contains(taskname)) {
                return taskname.taskname;
            }
            else
            {
                return "Task not added";
            }
        }

        public string ListAll()
        {
            string concat = "";
            if (tasks.Count > 0) 
            {
                foreach (UserTask task in tasks) 
                {
                    concat += task.taskname + " ";
                }
                return concat;
            }
            else
            {
                return "No tasks found";
            }
        }

        public bool ChangeStatus(UserTask taskname)
        {
            int index = tasks.IndexOf(taskname);
            bool taskstatus = tasks[index].isComplete;

            if (taskstatus == true) 
            {
                taskstatus = false;
                return taskstatus;
            }
            else
            {
                taskstatus = true;
                return taskstatus;
            }
        }

        public string ListIncomplete()
        {
            return "Nothing";
        }
    }
}

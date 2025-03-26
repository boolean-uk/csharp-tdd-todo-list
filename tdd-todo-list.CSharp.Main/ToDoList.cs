﻿using System;
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
            string concat = "";

            foreach (UserTask task in tasks) 
            {
                if (task.isComplete == false) 
                {
                    concat += task.taskname + " ";
                }
                else
                {

                }
            }
            return concat;
        }

        public string ListComplete() 
        {
            string concat = "";

            foreach (UserTask task in tasks)
            {
                if (task.isComplete == true)
                {
                    concat += task.taskname + " ";
                }
                else
                {

                }
            }
            return concat;
        }

        public string FindTask(UserTask taskname)
        {
            if (tasks.Contains(taskname))
            {
                return taskname.taskname;
            }
            else
            {
                return "Task not found";
            }
        }

        public string RemoveTask(UserTask taskname)
        {

            if (tasks.Remove(taskname))
            {
                return "Task named: " + taskname.ToString()+ ", has been removed";
            }
            else
            {
                return "No such task found, nor removed";
            }
        }

        public string ListAlphabetically()
        {
            string concat = "";
            tasks.Sort();
            foreach (UserTask task in tasks)
            {
                concat += task.taskname+" ";
            }
            return concat;
        }

        public string ListReverseAlphabetically() 
        {
            string concat = "";
            tasks.Sort();
            tasks.Reverse();
            foreach (UserTask task in tasks)
            {
                concat += task.taskname + " ";
            }
            return concat;
        }
    }
}
